using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Core.Dal;
using Core.Bll;
using System.Reflection;

using System.Diagnostics;
using System.IO;



namespace Core
{
    public partial class frmBase : Form, Core.UI.IFrmBase
    {
        protected Core.Dal.ISession _session;
        private bool _mySession = false;
        public bool _stop = false ;
        public static Keys DeleteKey = Keys.Delete;

        [Browsable(false)]
        public ISession Session
        {
            get
            {
                if (DesignerDetector.IsComponentInDesignMode(this)) return null;
                if (_session == null || !_session.IsOpen)
                {
                    _session = Dal.Manager.Instance.OpenSession();
                    _mySession = true;
                }
                if (!_session.IsConnected) _session.Reconnect();
                return _session;
            }
            set
            {
                if (_mySession && _session != null && !_session.IsOpen)
                    _session.Close();
                _session = value;
                _mySession = false;
            }
        }

        private Core.Dal.ISession _partnerSession;

        [Browsable(false)]
        public ISession PartnerSession
        {
            get
            {
                if (DesignerDetector.IsComponentInDesignMode(this)) return null;
                if (_partnerSession != null && _partnerSession.IsOpen && !_partnerSession.IsConnected)
                    _partnerSession.Reconnect();
                return _partnerSession;
            }
            set { _partnerSession = value; }
        }
        
        public frmBase()
        {
            InitializeComponent();
        }

        public void AcceptChanges()
        {
            if (_session != null)
            {
                Session.Commit(_partnerSession);
            }
        }

        public void RejectChanges()
        {
            if (_session != null)
            {
                Session.Rollback();
            }
        }

        public void MakeReadOnly()
        {            
            //MakeControlReadOnly(this);
        }

        private void MakeControlReadOnly(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                MakeControlReadOnly(c);
            }
            PropertyInfo pi = parent.GetType().GetProperty("Properties");
            if (pi == null) return;
            object properties = pi.GetValue(parent, null);
            pi = properties.GetType().GetProperty("ReadOnly");
            if (pi == null) return;
            pi.SetValue(properties, true, null);
        }
        
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (DesignMode) return;
            if (DesignerDetector.IsComponentInDesignMode(this)) return;
            
            //Core.Localization.Instance.Localize(this);
            if (this.Owner  != null)
            {
                this.Text = Owner.Text + " - " + this.Text;
            }
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (_mySession)
            {
                _session.Clear();
                _session.Close();
            }
            if (this is Core.UI.ISelectionForm)
            {

            }
            GC.Collect();
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            if (this.IsMdiContainer)
            {
                // Don't play with session disconnects in main form
                return;
            }
            if (_session != null && _session.IsOpen && !_session.IsConnected)
            {
                _session.Reconnect();
//#if DEBUG
//                Debug.WriteLine(this.GetType().Name + " reconnected its session. _mySession is " + _mySession.ToString(), "TPAIS");
//#endif
            }
        }

        protected override void OnDeactivate(EventArgs e)
        {
            base.OnDeactivate(e);
            if (this.IsMdiContainer)
            {
                // Don't play with session disconnects in main form
                return;
            }
            if (_session != null && _session.IsOpen && _session.IsConnected)
            {
                _session.Disconnect();
//#if DEBUG
//            Debug.WriteLine(this.GetType().Name + " disconnected its session. _mySession is " + _mySession.ToString(), "TPAIS");
//#endif
            }
        }

        protected override void OnInputLanguageChanged(InputLanguageChangedEventArgs e)
        {
#if DEBUG
            base.OnInputLanguageChanged(e);
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                TextWriter tw = new StreamWriter(fbd.SelectedPath + @"\" + this.GetType().Name + ".xml");
                tw.WriteLine(string.Format(@"<?xml version=""1.0"" encoding=""utf-8""?><form name=""{0}"" xmlns=""urn:TpaisFormLocalization"">", this.GetType().Name));
                tw.WriteLine(string.Format(@"<Entry key=""Text"" value=""{0}""/>", this.Text));
                List<string> res = Core.UI.ControlListGenerator.GenerateControlList(this, 
                    new Type[] 
                { 
                    typeof(Button), 
                    typeof(Label), 
                    typeof (DevExpress.XtraGrid.Columns.GridColumn), 
                    typeof (TabPage),
                    typeof (GroupBox),
                    typeof (CheckBox),
                    typeof (ToolStripMenuItem)
                }
                );
                foreach (string s in res)
                {
                    tw.WriteLine(s);
                }
                tw.WriteLine(@"</form>");
                tw.Close();

            }
#endif
        }

        /// <summary>
        /// 1. parametrs -- jaunais statuss [string], pēc tam -- visi statusi,
        /// pie kuriem jāpārjautā, vai tiešām mainīt
        /// </summary>
        protected DialogResult StatusChangePrompt(params object[] parameters)
        {
            string newStatus = (string)parameters[0];
            int i = 0;
            foreach (object e in parameters)
            {
                if (i > 0 & newStatus == System.Convert.ToString(e))
                {
                    return Core.UI.MsgBox.Show(Core.ErrMsg.GetText(Msg.PromptStatusChange)
                        + newStatus + Core.ErrMsg.GetText(Msg.QuestionMark), 
                        MessageBoxButtons.YesNo);
                }
                i += 1;
            }
            return DialogResult.Cancel;
        }

        public void ActivateErrorControls(ErrorProvider _errProvider, Control _control)
        {
            if (_control == this) _stop = false; 
            if (_stop) return;
            foreach (Control var in _control.Controls)            
            {
                if (_control is Core.UI.CoreGrid)
                {
                    for (int i = 0; i < ((Core.UI.CoreGrid)(_control)).DefaultView.RowCount; i++)
                    {
                        DevExpress.XtraGrid.Views.Grid.GridView _view = ((DevExpress.XtraGrid.Views.Grid.GridView)((Core.UI.CoreGrid)(_control)).DefaultView);
                        _view.FocusedRowHandle=i;
                        for (int j = 0; j < _view.Columns.Count; j++)
                        {
                            if (!string.IsNullOrEmpty(_view.GetColumnError(_view.Columns[j])))
                            {
                                _view.FocusedColumn = _view.Columns[j];
                                _stop = true;
                                ActivateTab(var.Parent);
                                return;
                            }
                        }                        
                    }
                }
                if (!string.IsNullOrEmpty(_errProvider.GetError(var)))
                {
                    ActivateTab(var.Parent);
                    var.Select();
                    var.Focus();
                    _stop = true;
                    return;
                }
                if (var.Controls.Count > 0)
                {
                    ActivateErrorControls(_errProvider, var);
                    if (_stop) return;
                }
            }
        }
        public void ActivateTab(Control _control)
        {            
            if (_control is TabPage)
            {
                ((TabControl)(_control.Parent)).SelectedTab = ((TabPage)_control);
            }
            if (_control.Parent == null) return;
            ActivateTab(_control.Parent);
        }
    }
}
