using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            txtMask.Text = txtRes.Properties.Mask.EditMask;
            test t = new test();
            bindingSource1.DataSource = t;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtRes.Properties.Mask.EditMask = txtMask.Text;
        }
    }
    public class test
    {
        private decimal? val;

        public decimal? Val
        {
            get
            {
                return val;
            }
            set
            {
                val = value;
            }
        }
    }
}