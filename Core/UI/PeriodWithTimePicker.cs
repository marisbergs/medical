using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Core.UI
{
    public partial class PeriodWithTimePicker : FlowLayoutPanel 
    {
        public PeriodWithTimePicker()
        {
            InitializeComponent();
            Controls.Add(dtpDateFrom);
            Controls.Add(dtpTimeFrom);
            Controls.Add(lblDateUntil);
            Controls.Add(dtpDateUntil);
            Controls.Add(dtpTimeUntil);
        }

 
      

    }
}

