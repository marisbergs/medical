using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace Core.UI
{
    public partial class PeriodWithTimePickerSecond : FlowLayoutPanel 
    {
        public PeriodWithTimePickerSecond()
        {
            InitializeComponent();
            Controls.Add(dtpDateFromSecond);
            Controls.Add(dtpTimeFromSecond);
            Controls.Add(lblDateUntil);
            Controls.Add(dtpDateUntilSecond);
            Controls.Add(dtpTimeUntilSecond);
        }
    }
}
