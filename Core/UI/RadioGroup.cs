using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace Core.UI
{
    [DefaultBindingProperty("EditValue")]
    public partial class RadioGroup : FlowLayoutPanel
    {
        public RadioGroup()
        {
            InitializeDefaults();
            InitializeComponent();
            AttachToEvents();
        }

        void InitializeDefaults()
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.MinimumSize = new System.Drawing.Size(30, 10);
            this.BorderStyle = BorderStyle.None;
            this.BackColor = System.Drawing.Color.Transparent;
        }

        private void AttachToEvents()
        {
            this.DataBindings.CollectionChanged += new CollectionChangeEventHandler(DataBindings_CollectionChanged);
            //this.DoubleClick += new EventHandler(RadioGroup_DoubleClick);
        }

        

        private String _listSourceMethod = "ListSource";

        [Description("Method that will be called on list source entity to get the list")]
        [DefaultValue("ListSource")]
        public String ListSourceMethod
        {
            get { return _listSourceMethod; }
            set {
                _listSourceMethod = value;
                FillItems();
            }
        }
	
        void DataBindings_CollectionChanged(object sender, CollectionChangeEventArgs e)
        {
            if (e.Action == CollectionChangeAction.Add || e.Action == CollectionChangeAction.Refresh)
            {
                Binding b = (e.Element as Binding);
                if (b != null && b.PropertyName == "EditValue")
                {
                    BindingSource bs = (b.DataSource as BindingSource);
                    if (bs != null)
                    {
                        bs.DataSourceChanged += new EventHandler(bs_DataSourceChanged);
                        FillItems();
                    }
                }
            }
        }

        void bs_DataSourceChanged(object sender, EventArgs e)
        {
            FillItems();
        }

        private object _editValue;

        [Browsable(true)]
        public object EditValue
        {
            get { return _editValue; }
            set
            {
                if (_editValue != value)
                {
                    _editValue = value;
                    foreach (Control c in this.Controls)
                    {
                        if (c is RadioButton)
                        {
                            (c as RadioButton).Checked = (_editValue == null ? false : _editValue.Equals(c.Tag));
                        }
                    }
                    OnEditValueChanged();
                }
                //else
                //{
                //    foreach (Control c in this.Controls)
                //    {
                //        if (c is RadioButton)
                //        {
                //            (c as RadioButton).CheckedChanged -= new EventHandler(rb_CheckedChanged);
                //            (c as RadioButton).Checked = (_editValue == null ? false : _editValue.Equals(c.Tag));
                //            (c as RadioButton).CheckedChanged += new EventHandler(rb_CheckedChanged);
                //        }
                //    }
                //}
            }
        }

        public event EventHandler EditValueChanged;

        protected void OnEditValueChanged()
        {
            if (EditValueChanged != null)
            {
                EditValueChanged(this, new EventArgs());
            }
        }

        ///<summary>
        ///Define delegate for changing property
        ///</summary>
        public delegate void ChangeEventDelegate(object sender, ChangeEventArgs args);

        /// <summary>
        /// Property change arguments
        /// </summary>
        public class ChangeEventArgs : EventArgs
        {
            /// <summary>
            /// Old value
            /// </summary>
            public object OldValue;

            /// <summary>
            /// New value
            /// </summary>
            public object NewValue;

            /// <summary>
            /// Cancel changing
            /// </summary>
            public bool Cancel = false;

        }

        public event ChangeEventDelegate EditValueChanging;

        protected void OnEditValueChanging( ChangeEventArgs arg)
        {
            if (EditValueChanging != null)
            {
                EditValueChanging(this, arg);
            }
        }

        void FillItems()
        {
            //if (!this.Created) return;

            bool unusedParameter;

            Binding b = this.DataBindings["EditValue"];
            if (b == null) return;

            BindingSource bs = (b.DataSource as BindingSource);
            if (bs == null || bs.DataSource == null) return;

            this.SuspendLayout();

            this.Controls.Clear();

            Type baseType = BindingHelper.BoundTypeFinder(this, "EditValue", out unusedParameter);

            System.Collections.IList items = ReflectionHelper.FindStaticPropertyValue(baseType, _listSourceMethod) as System.Collections.IList;
            if (items != null)
            {
                int tabIndex = 0;
                foreach (object o in items)
                {
                    RadioButton rb = new RadioButton();
                    rb.AutoSize = true;
                    rb.TabIndex = tabIndex++;
                    rb.TabStop = true;
                    rb.Tag = o;
                    rb.Text = o.ToString();
                    rb.UseVisualStyleBackColor = true;
                    if (_editValue != null && _editValue.Equals(rb.Tag))
                        rb.Checked = true;
                    rb.CheckedChanged += new EventHandler(rb_CheckedChanged);
                    rb.KeyDown += new KeyEventHandler(RadioGroup_DoubleClick);
                    this.Controls.Add(rb);
                    this.components.Add(rb);
                }
            }

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        void RadioGroup_DoubleClick(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Core.frmBase.DeleteKey)
            {
                this.EditValue = null;
                this.EditValue = null;
            }
        }

        void rb_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null && rb.Tag != _editValue)
            {
                ChangeEventArgs arg = new ChangeEventArgs();
                arg.OldValue = _editValue;
                arg.NewValue = rb.Tag;

                OnEditValueChanging(arg);
                //_editValue = rb.Tag;
                if (!arg.Cancel)
                {
                    _editValue = rb.Tag;
                    OnEditValueChanged();
                }
                else
                {
                    FillItems();
                    foreach (Control c in this.Controls)
                    {
                        if (c is RadioButton)
                        {
                            (c as RadioButton).Checked = (_editValue == null ? false : _editValue.Equals(c.Tag));
                        }
                    }
                }
            }
        }
    }
}
public class DoubleClickRadioButton : RadioButton
{
    public DoubleClickRadioButton()
    {
        this.SetStyle(ControlStyles.StandardDoubleClick, true);
    }
}
