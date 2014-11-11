using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;
using System.Text;
using System.Media;
using System.Windows.Forms;
using System.Timers;
using Core.Bll;
using Core.Dal;
using TpaisEntities;
using System.Collections;


namespace Scheduler
{
    public partial class Scheduler : ServiceBase
    {
        private System.Timers.Timer timer;
        private DateTime _dnsUpdateTimeFrom;
        private DateTime _dnsUpdateTimeUntil;
        private DateTime _classifiersUpdateTime;
        private bool _continuousClassifierUpdate;
        private bool _continuousReportSend;
        private DateTime _emailSendTime;
        private Entities.SystemParameter _emailNextSend;
        private Entities.SystemParameter _classifiersNextUpdate;
        private ISession _session;
        private Nullable<DateTime> temp;
        private ISession Session
        { 
            get
            {
                if (_session == null || !_session.IsOpen)
                {
                    Core.Dal.Manager.Instance.SetDefaultConnectionTarget(ConnectionTarget.Central);
                    _session = Core.Dal.Manager.Instance.OpenSession();
                }
                if (!_session.IsConnected) _session.Reconnect();
                return _session; 
            }
        }
        private void RefreshConfigValues ()
        {
            if (Session.Get<Entities.SystemParameter>("WS_REQUEST_CLASSIFIERS_COUNTINUOUS").Value == "0")
            {
                temp = Session.Get<Entities.SystemParameter>("WS_REQUEST_CLASSIFIERS_AT_TIME").ParamDate;
                if (temp.HasValue)
                {
                    _classifiersUpdateTime = temp.Value;
                }
                else
                {
                    _classifiersUpdateTime = DateTime.Now;
                }

                _classifiersNextUpdate = Session.Get<Entities.SystemParameter>("WS_NEXT_CLS_UPDATE_TIME");
                temp = _classifiersNextUpdate.ParamDate;
                if (!temp.HasValue)
                {
                    temp = DateTime.Now;
                }
                if (_classifiersUpdateTime.TimeOfDay != temp.Value.TimeOfDay)
                {
                    _classifiersNextUpdate.ParamDate = _classifiersUpdateTime;
                }
                _continuousClassifierUpdate = false;
            }
            else
            {
                _continuousClassifierUpdate = true;
            }

            temp = Session.Get<Entities.SystemParameter>("EMAIL_SEND_TIME").ParamDate;
            if (temp.HasValue)
            {
                _emailSendTime = temp.Value;
            }
            else
            {
                _emailSendTime = DateTime.Now;
            }
            _emailNextSend = Session.Get<Entities.SystemParameter>("WS_NEXT_EMAIL_SEND_TIME");
            temp = _emailNextSend.ParamDate;
            if (!temp.HasValue)
            {
                temp = DateTime.Now;
            }
            if (_emailSendTime.TimeOfDay != temp.Value.TimeOfDay)
            {
                _emailNextSend.ParamDate = _emailSendTime;
            }


            if (Session.Get<Entities.SystemParameter>("WS_REQUEST_REPORTS_CONTINUOUS").Value == "0")
            {
                temp = Session.Get<Entities.SystemParameter>("WS_REQUEST_REPORTS_FROM").ParamDate;
                if (temp.HasValue)
                {
                    _dnsUpdateTimeFrom = temp.Value;
                }
                else
                {
                    _dnsUpdateTimeFrom = DateTime.Now;
                }
                temp = Session.Get<Entities.SystemParameter>("WS_REQUEST_REPORTS_UNTIL").ParamDate;
                if (temp.HasValue)
                {
                    _dnsUpdateTimeUntil = temp.Value;
                }
                else
                {
                    _dnsUpdateTimeUntil = DateTime.Now;
                }
                _continuousReportSend = false;
            }
            else
            {
                _continuousReportSend = true;
            }
        }
        public Scheduler()
        {
            InitializeComponent(); 
          
        }

        protected override void OnStart(string[] args)
        {
            Core.DnsGate.Service.Url = Session.Get<Entities.SystemParameter>("WS_TPAIS_URL").Value;
            Core.Bll.PermissionsChecker.Permissions = new Hashtable();
            Core.Bll.PermissionsChecker.Permissions.Add("IDDQD", null);


                
            
            timer = new System.Timers.Timer();
            timer.Elapsed +=  new ElapsedEventHandler(OnTimedEvent);
            timer.Interval = 120000;
            timer.Enabled = true;
            timer.Start();
            
            EventLog.WriteEntry("TPAIS Scheduler", "sevice started @" + DateTime.Now);
        }

        protected override void OnStop()
        {
            // TODO: Add code here to perform any tear-down necessary to stop your service.
        }

        
        private void OnTimedEvent(object sender, EventArgs e)
        {
            int step = 0;
            try
            {                
                lock ( Session )
                {   
                Session.Clear();
                RefreshConfigValues();
                try
                {
                    string str = "";
                    str= Scheduler.RegularStep(Session);
                    if (!string.IsNullOrEmpty(str))
                    {
                        EventLog.WriteEntry("TPAIS Scheduler", "error @" + DateTime.Now + ": " + str);
                    }
                }
                catch (Exception ex)
                {
                    EventLog.WriteEntry("TPAIS Scheduler", "error @" + DateTime.Now + ": " + ex.ToString() + " Inner: step - " + step);
                }
                try
                { 
                    step = 1;
                    DateTime now = DateTime.Now;                
                    if ( _continuousReportSend || 
                        ((now >= _dnsUpdateTimeFrom) && (now <= _dnsUpdateTimeUntil)))
                    {
                        //EventLog.WriteEntry("TPAIS Scheduler", "Start report request sending");
                        Scheduler.DnsSend (Session);
                    }
                }
                catch (Exception ex)
                {
                    string inner = "";
                    if (ex.InnerException != null)
                        inner = ex.InnerException.Message;

                    EventLog.WriteEntry("TPAIS Scheduler", "error @" + DateTime.Now + ": " + ex.ToString() + " Inner: step - " + step);
                }
                try
                { 
                    step = 2;
                    if ( _continuousClassifierUpdate || DateTime.Now > _classifiersNextUpdate.ParamDate.Value)
                    {
                        //EventLog.WriteEntry("TPAIS Scheduler", "Start classifier sinchronization");
                        Synchronizer s = new Synchronizer();
                        s.SynchronizeClassifiers(Session);

                        if (!_continuousClassifierUpdate)
                        {
                            temp = DateTime.Today.AddDays(1).AddHours(_classifiersUpdateTime.Hour).AddMinutes(_classifiersUpdateTime.Minute);
                            _classifiersNextUpdate.ParamDate = temp;
                        }
                    }
                }
                catch (Exception ex)
                {
                    string inner = "";
                    if (ex.InnerException != null)
                        inner = ex.InnerException.Message;

                    EventLog.WriteEntry("TPAIS Scheduler", "error @" + DateTime.Now + ": " + ex.ToString() + " Inner: step - " + step);
                }

                step = 3;
                if (DateTime.Now > _emailNextSend.ParamDate)
                {
                    //EventLog.WriteEntry("TPAIS Scheduler", "Start e-mail sending");
                    Entities<PendingEmail> lowPriorityEmails = Entities<PendingEmail>.GetAll(Session, new Core.Dal.Expressions.Eq("Priority", PriorityType.Low));
                    foreach (PendingEmail email in lowPriorityEmails)
                    {
                        email.Send();
                        Session.Delete(email);
                        EventLog.WriteEntry("TPAIS Scheduler", "E-mail sent to " + email.Email.ToString());
                    }
                    temp = DateTime.Today.AddDays(1).AddHours(_emailSendTime.Hour).AddMinutes(_emailSendTime.Minute);
                    _emailNextSend.ParamDate = temp;
                }
                step = 4;
                Session.Commit();
                //EventLog.WriteEntry ( "TPAIS Scheduler", Scheduler.SendOutgoingReports().ErrorString );
                //EventLog.WriteEntry("TPAIS Scheduler", "successfully performed scheduled tasks @" + DateTime.Now);
                }
            }
            catch (Exception ex)
            {
                string inner = "";
                if (ex.InnerException != null)
                    inner = ex.InnerException.Message;

                EventLog.WriteEntry("TPAIS Scheduler", "error @" + DateTime.Now + ": " + ex.ToString() + " Inner: step - " + step);
            }
        }




        
    }
}
