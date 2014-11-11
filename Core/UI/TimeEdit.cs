using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace Core.UI
{
    [DefaultBindingProperty("EditValue")]
    public partial class TimeEdit : FlowLayoutPanel
    {
        public TimeEdit()
        {
            InitializeComponent();
            Controls.Add(this.txtTime);
            this.txtTime.Validating += new CancelEventHandler(txtTime_Validating);
        }

        void txtTime_Validating(object sender, CancelEventArgs e)
        {
            if (((txtTime.Text == "") && (!txtTime.IsModified)) || (!txtTime.IsModified)) { return; }
            char[] charSeparators = new char[] {':'};
            string edit = ((DevExpress.XtraEditors.TextEdit)(sender)).EditValue.ToString();
            if (txtTime.Text != edit) { return; }
            string[] arr = edit.Split(charSeparators, System.StringSplitOptions.None);
            if (arr.Length == 1) 
            {
                if (this.EditValue != null)
                {
                    this.EditValue = this.EditValue.Value.Date;
                }
                else
                {
                    this.EditValue = null;
                }
            }
            else if (arr.Length == 2) 
            {
                String temp = arr[1].ToString();
                if (arr[0].ToString().Length == 0)
                {
                    arr[0] = "00";
                    ((DevExpress.XtraEditors.TextEdit)(sender)).EditValue = arr[0].ToString() + ":" + arr[1].ToString();
                }
                if (arr[0].ToString().Length == 1)
                {
                    arr[0] = "0" + arr[0];
                    ((DevExpress.XtraEditors.TextEdit)(sender)).EditValue = arr[0].ToString() + ":" + arr[1].ToString();
                }
                if (String.IsNullOrEmpty(temp))
                {
                    arr[1] = "00";
                    ((DevExpress.XtraEditors.TextEdit)(sender)).EditValue = arr[0].ToString() + ":" + arr[1].ToString();
                    e.Cancel = false;
                }
                if (temp.Length == 1)
                {
                    arr[1] = temp + "0";
                    ((DevExpress.XtraEditors.TextEdit)(sender)).EditValue = arr[0].ToString() + ":" + arr[1].ToString();
                    e.Cancel = false;
                }
                if (!EditValue.HasValue)
                {
                    EditValue = DateTime.Now;
                }
                else
                {

                }
                double hour;
                double minute;
                double.TryParse(arr[0], out hour);
                double.TryParse(arr[1], out minute);
                EditValue = EditValue.Value.Date.AddHours(hour).AddMinutes(minute);
                ((DevExpress.XtraEditors.TextEdit)(sender)).EditValue = arr[0].ToString() + ":" + arr[1].ToString();
            }
        }

        Nullable<DateTime> _editValue;
        [Browsable(true)]
        public Nullable<DateTime> EditValue
        {
            get { return _editValue; }
            set
            {
                _editValue = value;
                if (_editValue.HasValue)
                {
                    this.txtTime.EditValue = _editValue.Value;
                }
                else
                {
                    this.txtTime.Text = "";
                }
            }
        }
    }
}
