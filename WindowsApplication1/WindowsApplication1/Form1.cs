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
            Test t1 = new Test("Test 1", "T1");
            Test t2 = new Test("Test 2", "T2");
            Test t3 = new Test("Test 3", "T3");
            Test t4 = new Test("Test 4", "T4");
            Container c1 = new Container();
            c1.Test = t1;
            bndTest.Add(c1);
        }

        private void buttonEdit1_KeyUp(object sender, KeyEventArgs e)
        {
            if (buttonEdit1.Text.Length >= 3)
            {
                ListBox lst = new ListBox();
                this.Controls.Add(lst);
            }
        }
    }

    public class Test
    {
        private string value;
        private string code;
        public Test(string value, string code)
        {
            this.value = value;
            this.code = code;
        }

        public string Value
        {
            get { return value; }
            set { this.value = value; }
        }
        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        public override string ToString()
        {
            return Value;
        }
    }
    public class Container
    {
        private Test test;

        public Test Test
        {
            get { return test; }
            set { test = value; }
        }
    }
}