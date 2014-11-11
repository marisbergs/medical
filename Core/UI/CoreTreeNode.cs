using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace Core.UI
{
    public class CoreTreeNode : TreeNode
    {

        private object _value;
        public object Value
        {
            get
            {
                return _value;                
            }
            set
            {
                _value = value;
            }
        }

        private object _parentValue;
        public object ParentValue
        {
            get
            {
                return _parentValue;
            }
            set
            {
                _parentValue = value;
            }
        }

        public CoreTreeNode(string name)
            : base(name)
        {            

        }

        private INotifyPropertyChanged _data;

        public INotifyPropertyChanged Data
        {
            get { return _data; }
            set
            {
                if (_data != null)
                {
                    _data.PropertyChanged -= new PropertyChangedEventHandler(_data_PropertyChanged);
                }
                _data = value;
                if (_data != null)
                {
                    _data.PropertyChanged += new PropertyChangedEventHandler(_data_PropertyChanged);
                    SetIsActive();
                }

            }
        }

        void _data_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "IsActive")
            {
                SetIsActive();
            }
           
        }

        private void SetIsActive()
        {
            bool isActive = (bool)ReflectionHelper.GetPropertyValue(_data, "IsActive");
            this.ForeColor = isActive ? Color.Black : Color.Red;            
        }

    }
}
