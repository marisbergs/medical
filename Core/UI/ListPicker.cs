using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using System.Text;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace Core.UI
{
    public partial class ListPicker : PopupContainerEdit
    {
        private bool _isCollection;
        private Type _baseType;
        private BaseListBoxControl _listBox;

        private String _listSourceMethod = "ListSource";

        [Description("Method that will be called on list source entity to get the list")]
        [DefaultValue("ListSource")]
        public String ListSourceMethod
        {
            get { return _listSourceMethod; }
            set { _listSourceMethod = value; }
        }

        private void ExtractBinding()
        {
            if (!DesignMode)
            {
                Binding b = this.DataBindings["EditValue"];
                if (b == null) return;
                object dataSource = b.DataSource;
                if (dataSource is BindingSource)
                {
                    BindingSource bs = (dataSource as BindingSource);
                    if (bs.DataSource == null) return;
                }
                _baseType = BindingHelper.BoundTypeFinder(this, "EditValue", out _isCollection);
                if (_baseType != null)
                {
                    if (_listBox != null)
                        base.Properties.PopupControl.Controls.Remove(_listBox);

                    if (_isCollection)
                    {
                        _listBox = new CheckedListBoxControl();
                        (_listBox as CheckedListBoxControl).CheckOnClick = true;
                        base.EditValue = new ArrayList();
                    }
                    else
                    {
                        _listBox = new ListBoxControl();
                        _listBox.Click += new EventHandler(_listBox_Click);
                    }
                    _listBox.Dock = DockStyle.Fill;

                    // Populate listbox
                    IList listSource = null;
                    // Check if the base type contains property for generation of data source list
                    System.Reflection.PropertyInfo pi = ReflectionHelper.LocateProperty(_baseType, _listSourceMethod, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
                    if (pi != null)
                    {
                        listSource = (pi.GetValue(null, null) as IList);
                    }
                    else
                    {
                        // Check if the base type contains a method for generation of data source list
                        System.Reflection.MethodInfo mi = ReflectionHelper.LocateMethod(_baseType, _listSourceMethod, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
                        if (mi != null)
                        {
                            listSource = (mi.Invoke( null, new object[] { (this.FindForm() as IFrmBase).Session } ) as IList);
                        }
                    }
                    if (listSource != null)
                    {
                        _listBox.DataSource = listSource;
                    }
                    base.Properties.PopupControl.Controls.Add(_listBox);
                }
            }
        }

        void _listBox_Click(object sender, EventArgs e)
        {
            base.ClosePopup();
        }

        public ListPicker() : base()
        {
            this.Properties.PopupControl = new PopupContainerControl();
            this.Properties.PopupSizeable = false;
            this.Properties.ShowPopupCloseButton = false;
            this.Properties.CloseOnOuterMouseClick = true;
            base.QueryResultValue += new DevExpress.XtraEditors.Controls.QueryResultValueEventHandler(ListPicker_QueryResultValue);
            base.QueryDisplayText += new DevExpress.XtraEditors.Controls.QueryDisplayTextEventHandler(ListPicker_QueryDisplayText);
            base.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(ListPicker_CloseUp);
            DataBindings.CollectionChanged += new CollectionChangeEventHandler(DataBindings_CollectionChanged);
        }

        void DataBindings_CollectionChanged(object sender, CollectionChangeEventArgs e)
        {
            if (!this.Created) return;
            if (e.Action == CollectionChangeAction.Add || e.Action == CollectionChangeAction.Refresh)
            {
                Binding b = (e.Element as Binding);
                if (b != null && b.PropertyName == "EditValue")
                {
                    BindingSource bs = (b.DataSource as BindingSource);
                    if (bs != null)
                    {
                        bs.DataSourceChanged += new EventHandler(bs_DataSourceChanged);
                        ExtractBinding();
                    }
                }
            }
        }

        void bs_DataSourceChanged(object sender, EventArgs e)
        {
            ExtractBinding();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Properties.PopupFormWidth = this.Width;
        }

        void ListPicker_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            // Restore selected items if the user's choice should be discarded
            if (!e.AcceptValue)
            {
                if (_isCollection)
                {
                    CheckedListBoxControl lbxList = _listBox as CheckedListBoxControl;
                    //Clear existing selection
                    for (int i = 0; i < lbxList.CheckedIndices.Count; ++i)
                        lbxList.SetItemChecked(lbxList.CheckedIndices[i], false);
                    // Restore selection from the editor's edit value
                    foreach (object o in base.EditValue as IList)
                        lbxList.SetItemChecked(lbxList.Items.IndexOf(o), true);
                }
                else if (_listBox != null)
                {
                    _listBox.SelectedIndex = _listBox.FindItem(base.EditValue);
                }
            }
        }

        void ListPicker_QueryDisplayText(object sender, DevExpress.XtraEditors.Controls.QueryDisplayTextEventArgs e)
        {
            if (_baseType == null)
                ExtractBinding();

            if (e.EditValue == null)
            {
                e.DisplayText = "";
            }    
            else if (_isCollection)
            {
                try
                {
                    IList tmp = (IList)e.EditValue;
                }
                catch (InvalidCastException ex)
                {
                    e.DisplayText = "";
                    return;
                }
                StringBuilder result = new StringBuilder();
                String separator = "";
                foreach (object o in (e.EditValue as IList))
                {
                    result.Append(separator);
                    result.Append(o.ToString());
                    separator = " | ";
                }
                e.DisplayText = result.ToString();
            }
            else
            {
                e.DisplayText = e.EditValue.ToString();
            }
        }

        void ListPicker_QueryResultValue(object sender, DevExpress.XtraEditors.Controls.QueryResultValueEventArgs e)
        {
            if (_baseType == null)
                ExtractBinding();

            if (_isCollection)
            {
                IList ar = (e.Value as IList);
                if (ar != null) 
                { ar.Clear(); } 
                else 
                {ar = new ArrayList();}

                for (int i = 0; i < _listBox.ItemCount; ++i)
                {
                    if ((_listBox as CheckedListBoxControl).GetItemChecked(i))
                        ar.Add(_listBox.GetItem(i));
                }
            }
            else if (_listBox != null)
            {
                e.Value = (_listBox as ListBoxControl).SelectedItem;
            }
        }
    }


}
