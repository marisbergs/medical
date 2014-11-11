using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.ServiceProcess;
using System.Text;
using System.Timers;
using Core;
using Core.Bll;
using Core.Dal;
using Entities;

namespace PreMedicScheduler
{
    public partial class Service1 : ServiceBase
    {
        private System.Timers.Timer timer;
        public Service1()
        {
            InitializeComponent();
        }

        private ISession _session;
        private ISession Session
        {
            get
            {
                if (_session == null || !_session.IsOpen)
                {
                    Manager.Instance.SetDefaultConnectionTarget(ConnectionTarget.Central);
                    _session = Manager.Instance.OpenSession();
                }
                if (!_session.IsConnected) _session.Reconnect();
                return _session;
            }
        }

        protected override void OnStart(string[] args)
        {
            int interval = 0;
            System.Configuration.AppSettingsReader appSetting = new System.Configuration.AppSettingsReader();
            string val = appSetting.GetValue("Interval", typeof(string)).ToString();
            if (!int.TryParse(val, out interval))
            {
                interval = 360;
            }
            timer = new System.Timers.Timer();
            timer.Elapsed += timer_Elapsed;
            timer.Interval = interval * 1000;
            timer.Enabled = true;
            timer.Start();

            EventLog.WriteEntry("PreMedic Scheduler", "sevice started @" + DateTime.Now + "with interval " + interval);
        }

        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            
            //atrodam konfigurâcijas failu un nolasam sms
            // sûtîðanas linku
            System.Configuration.AppSettingsReader appSetting = new System.Configuration.AppSettingsReader();
            string log = appSetting.GetValue("log", typeof(string)).ToString();
            if (log == "true")
                EventLog.WriteEntry("PreMedic Scheduler", "sevice run @" + DateTime.Now);

            string val = appSetting.GetValue("address", typeof(string)).ToString();
            val += "&" + appSetting.GetValue("username", typeof(string));
            val += "&" + appSetting.GetValue("password", typeof(string));
            val += "&" + appSetting.GetValue("from", typeof(string));
            val += "&" + appSetting.GetValue("to", typeof(string));
            val += "&" + appSetting.GetValue("text", typeof(string));
            if (log == "true")
                EventLog.WriteEntry("PreMedic Scheduler link", val);
            try
            {
                _session = null;
                BirthDateGenerator b = new BirthDateGenerator();
                KeyValuePair<bool, SMSMessages> d = b.NeedGenerate(Session);
                if (d.Key)
                {
                    Entities<Patient> res = b.generateSms(Session, d.Value);
                    foreach (var item in res)
                    {                        
                        SMSSendingList mesage = new SMSSendingList();
                        mesage.Patient = item;
                        mesage.Sended = SmsSendStatus.NotSent;
                        mesage.Message = String.Format(d.Value.MeesageText, item.Name);
                        mesage.SendTime = DateTime.Now.Date.AddHours(d.Value.SendTime.Hour).AddMinutes(d.Value.SendTime.Minute);
                        Send(mesage, log, val, false);
                        if (mesage.Sended == SmsSendStatus.Sent)
                        {
                            item.BirthdateGreetingsSend = Convert.ToInt16(DateTime.Now.Year);
                            _session.SaveOrUpdate(item);
                            _session.Commit();
                        }
                    }
                }
                _session = null;

                Entities<SMSSendingList> list = Entities<SMSSendingList>.GetAll(Session,
                    new Core.Dal.Expressions.Eq("Sended", SmsSendStatus.NotSent),
                    new Core.Dal.Expressions.Le("SendTime", DateTime.Now));

                if (log == "true")
                    EventLog.WriteEntry("PreMedic Scheduler link", list.Count.ToString());
                foreach (SMSSendingList o in list)
                {
                    Send(o, log, val, true);
                }
            }
            catch (Exception ex)
            {
                    EventLog.WriteEntry("PreMedic Scheduler global", ex.ToString());
            }
            _session = null;
            Manager.SetInstanceNull();
        }

        private bool Send(SMSSendingList o, string log, string val, bool save)
        {
            string phone = "";
                    if (!string.IsNullOrEmpty(o.Patient.MobilePhone))
                    {
                        phone = o.Patient.MobilePhone;
                        if (o.Patient.MobilePhone.Length == 8)
                            phone = "371" + o.Patient.MobilePhone;
                        else if (o.Patient.MobilePhone.Length != 11)
                        {
                            if (save)
                            {
                                o.Response = "nepareizs telefona numurs";
                                o.Sended = SmsSendStatus.InvalidPhone;
                                Session.SaveOrUpdate(o);
                                Session.Commit();
                                EventLog.WriteEntry("PreMedic Scheduler invalid phone", "klientam " + o.Patient.FullName + " nepareizs telefona numurs");
                            }
                            return false;
                        }
                    }
                    if (log == "true")
                        EventLog.WriteEntry("PreMedic Scheduler link", string.Format(val, phone, o.Message));
                    try
                    {
                        WebRequest returnValue = WebRequest.Create(string.Format(val, phone, o.Message));
                        returnValue.Timeout = 240000;
                        WebResponse response = returnValue.GetResponse();
                        Stream res = response.GetResponseStream();
                        StreamReader readStream = new StreamReader(res);
                        Char[] read = new Char[256];

                        // Read 256 charcters at a time.    
                        int count = readStream.Read(read, 0, 256);
                        StringBuilder sb = new StringBuilder();
                        while (count > 0)
                        {
                            // Dump the 256 characters on a string and display the string onto the console.
                            String str = new String(read, 0, count);
                            sb.Append(str);
                            count = readStream.Read(read, 0, 256);
                        }
                        // Release the resources of stream object.
                        readStream.Close();

                        // Release the resources of response object.
                        response.Close();
                        o.Response = sb.ToString().Length<2600 ? sb.ToString() : sb.ToString().Substring(0, 2659);
                        o.Sended = SmsSendStatus.Sent;
                        if (save)
                            _session.Commit();
                    }
                    catch (Exception exs)
                    {
                        EventLog.WriteEntry("PreMedic Scheduler send ex", exs.ToString());
                        return false;
                    }
            return true;
        }

        protected override void OnStop()
        {
            
        }
    }
}
