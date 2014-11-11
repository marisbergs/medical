using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace WindowsApplication1
{
    public partial class SearchButtonPicker : System.Windows.Forms.Panel
    {
        public SearchButtonPicker()
        {
            InitializeComponent();
        }

        public SearchButtonPicker(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void SearchButtonPicker_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            
        }

        private void SearchButtonPicker_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (this.Text.Length >= 3)
                listBox1.Visible = true;
        }
    }
}
