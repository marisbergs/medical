using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;


namespace Core.UI
{
    class FormFactory
    {
        private static Form _MDIParentForm;

        public static Form MDIParentForm
        {
            get { return _MDIParentForm; }
            set { _MDIParentForm = value; }
        }

        public static void AddChildForm(Type formType, params object [] startParameters)
        {
            if (_MDIParentForm == null)
            {
                // TODO: localize
                throw new CriticalException("mdi parent form not set!");
            }
            try
            {
                Form newForm = Activator.CreateInstance(formType, startParameters) as Form;
                if (newForm == null)
                {
                    // TODO: localize
                    throw new CriticalException("type passed to formfactory is not a form");
                }
                newForm.MdiParent = _MDIParentForm;
                newForm.Show();
            }
            catch ( Exception ex )
            {
                // TODO: localize
                MessageBox.Show("Whoops! " + ex.Message );
                throw;
            }
        }
        
    }
}
