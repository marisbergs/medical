using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Core.UI
{
    public partial class PeriodPicker : FlowLayoutPanel 
    {
        public PeriodPicker()
        {
            InitializeComponent();
            Controls.Add(dtpFrom);
            Controls.Add(lblDateUntil);
            Controls.Add(dtpUntil);
        }      
      

    }
}

