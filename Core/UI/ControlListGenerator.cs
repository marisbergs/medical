using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Reflection;


namespace Core.UI
{
    class ControlListGenerator
    {
        public static List<Type> typesToOmitInNaming = new List<Type>();

        static ControlListGenerator()
        {
            typesToOmitInNaming.Add(typeof(FlowLayoutPanel));
            typesToOmitInNaming.Add(typeof(TableLayoutPanel));
            typesToOmitInNaming.Add(typeof(Panel));
            typesToOmitInNaming.Add(typeof(GroupBox));
            typesToOmitInNaming.Add(typeof(TabPage));
            typesToOmitInNaming.Add(typeof(TabControl));
            typesToOmitInNaming.Add(typeof(SplitContainer));
            typesToOmitInNaming.Add(typeof(SplitterPanel));
        }

        public static List<string> GenerateControlList ( Form f, Type [] controlType )
        {
            List<string> result = new List<string>();
            AppendControls(result, f, controlType, "");
            return result;
        }

        private static void AppendControls(IList<string> list, Control c, Type [] controlType, string pathPrefix)
        {
            FieldInfo[] fis = c.GetType().GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (FieldInfo fi in fis)
            {
                if (fi.FieldType == typeof(DevExpress.XtraGrid.Columns.GridColumn))
                {
                    DevExpress.XtraGrid.Columns.GridColumn col = fi.GetValue(c) as DevExpress.XtraGrid.Columns.GridColumn;
                    if (col == null || !col.Visible) continue;
                    list.Add(
                    string.Format(@"<Entry key=""{0}{1}.Caption"" value=""{2}""/>",
                    pathPrefix, col.Name, col.Caption));
                }
            }

            if (c.GetType() == typeof(MenuStrip))
            {
                foreach (ToolStripDropDownItem var in ((System.Windows.Forms.MenuStrip)(c)).Items)
                {
                    if (var.Name != "mnuForms")
                    {
                        list.Add(
                        string.Format(@"<Entry key=""{0}.Text"" value=""{1}""/>",
                        var.Name, var.Text));
                        if (var.DropDown.Items.Count > 0)
                        {
                            foreach (ToolStripDropDownItem obj in var.DropDown.Items)
                            {
                                list.Add(
                                string.Format(@"<Entry key=""{0}.Text"" value=""{1}""/>",
                                obj.Name, obj.Text));
                                if (obj.DropDown.Items.Count > 0)
                                {
                                    foreach (ToolStripDropDownItem contr in obj.DropDown.Items)
                                    {
                                        list.Add(
                                        string.Format(@"<Entry key=""{0}.Text"" value=""{1}""/>",
                                        contr.Name, contr.Text));
                                    }
                                }
                            }
                        }
                    }
                }

            }

            foreach (Control childControl in c.Controls)
            {
                bool contains = false;
                foreach (Type t in controlType)
                {
                    if ( childControl.GetType ()== t )
                    {
                        contains = true;
                        break;
                    }
                }
                
                if ( contains )
                {
                    list.Add(
                    string.Format ( @"<Entry key=""{0}{1}.Text"" value=""{2}""/>",
                    pathPrefix, childControl.Name, childControl.Text ));                                              
                }
                if ( typesToOmitInNaming.Contains ( childControl.GetType () ))
                {
                    AppendControls(list, childControl, controlType, pathPrefix);
                }
                else
                {
                    AppendControls(list, childControl, controlType, pathPrefix + childControl.Name+".");
                }
            }

            
        }
    }
}
