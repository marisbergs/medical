using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Core
{
    public partial class frmDictionaryBase : Form
    {
        DictionaryDesigner dd = new DictionaryDesigner();

        public frmDictionaryBase()
        {
            InitializeComponent();
            dd.FormGrid.SelectedObject = this;
            dd.dataGridView1.DataSource = grdData.Columns;
        }


        private void Design()
        {            
            dd.Show ();
        }
        private void frmDictionaryBase_Load(object sender, EventArgs e)
        {           
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Design();
        }
    }
}