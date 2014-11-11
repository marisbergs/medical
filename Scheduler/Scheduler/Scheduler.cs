using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;
using System.Text;
using System.Media;
using System.Timers;
using Core.Bll;
using Core.Dal;
using Entities;
using System.Collections;

namespace Scheduler
{
    public partial class Scheduler : ServiceBase
    {
        private System.Timers.Timer timer;
        private ISession _session;

        public Scheduler()
        {
            InitializeComponent();
        }
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

        private void GetMessages()
        {

        }

        protected override void OnStart(string[] args)
        {
            timer = new System.Timers.Timer();
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
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

        }
    }
}
