using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Collections;
namespace Core.UI
{
    public partial class CoreTreeView : TreeView 
    {
        public SortedList<string, CoreTreeNode> parentNodeList = new SortedList<string,CoreTreeNode> ();
        public SortedList<string, CoreTreeNode> nodeList = new SortedList<string, CoreTreeNode>();
 
        public CoreTreeView()
        {
            InitializeComponent();
        }

        public CoreTreeView(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }


        private void InitTree()
        {
            if (ValueMember == null || DisplayMember == null || ParentMember == null)
                return;
            _nodesByValueMember.Clear();
            parentNodeList.Clear();
            nodeList.Clear();
            this.Nodes.Clear();
            foreach (object item in _list)
            {
                CreateNode(item);
            }

            foreach (CoreTreeNode n in parentNodeList.Values)
            {
                n.Nodes.Clear();
                WireUpNode(n); 
            }
            foreach (CoreTreeNode n in  nodeList.Values )
            {
                //n.Nodes.Clear();
                WireUpNode(n);
             
        }
        }

        private void WireUpNode(CoreTreeNode node)
        {
            if ((Nodes.Contains(node))) {return;}
            if (node.ParentValue == null)
            {
                Nodes.Add(node); 
            }
            else
            {
                CoreTreeNode parent = (CoreTreeNode)_nodesByValueMember[node.ParentValue];
                if (parent == null) return;
                if (parent == node)
                {
                    Nodes.Add(node);
                }
                else
                {
                    if (parent.Nodes.Contains(node)) { return; }
                    parent.Nodes.Add(node);
                }
            }        
        }

        private CoreTreeNode CreateNode(object item)
        {
            CoreTreeNode node = new CoreTreeNode(ReflectionHelper.GetPropertyValue(item, _displayMember).ToString());
            node.Value = ReflectionHelper.GetPropertyValue(item, _valueMember);
            object asFirst = ReflectionHelper.GetPropertyValue(item, _useAsParent);
            if (asFirst != null && asFirst.GetType().Name == "Boolean")
            {
                if ((bool)asFirst)
                {
                    node.ParentValue = null;
                }
                else
                {
                    node.ParentValue = ReflectionHelper.GetPropertyValue(item, _parentMember);
                }
            }
            else
            {
                node.ParentValue = ReflectionHelper.GetPropertyValue(item, _parentMember);
            }
            node.Data = (INotifyPropertyChanged )item;
            if (SelectedMember != "")
            {
                node.Checked = (bool)ReflectionHelper.GetPropertyValue(item, SelectedMember);
            }
            _nodesByValueMember.Add(node.Value, node);
            Nullable<DateTime> ValidUntil = (Nullable<DateTime>)ReflectionHelper.GetPropertyValue(item, "ValidUntil");
            if (ValidUntil.HasValue)
            {
                if (ValidUntil.Value < DateTime.Today)
                {
                    node.ForeColor = System.Drawing.Color.Gray;
                }
            }
            if (!(bool)ReflectionHelper.GetPropertyValue(item, "IsActive"))
            {
                node.ForeColor = System.Drawing.Color.Red;
            }
            //mani papildinājumi
            if (node.ParentValue == null | (!(node.ParentValue==null) && node.ParentValue.Equals(node.Value)))
            {
                if (!(parentNodeList.ContainsKey(node.Text + " " + node.Value ))) { parentNodeList.Add(node.Text + " " + node.Value, node); }
            }
            else
            {
                if (!(nodeList.ContainsKey(node.Text + " " + node.Value))) { nodeList.Add(node.Text + " " + node.Value, node); }
            }
            return node;
        }

        
        
        private string _valueMember;

        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design", "System.Drawing.Design.UITypeEditor, System.Drawing")]
        public string ValueMember
        {
            get { return _valueMember; }
            set { _valueMember = value; }
        }
        private string _displayMember;

        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design", "System.Drawing.Design.UITypeEditor, System.Drawing")]
        public string DisplayMember
        {
            get { return _displayMember; }
            set { _displayMember = value; }
        }
        private string _parentMember;

        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design", "System.Drawing.Design.UITypeEditor, System.Drawing")]
        public string ParentMember
        {
            get { return _parentMember; }
            set { _parentMember = value; }
        }

        private string _useAsParent;
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design", "System.Drawing.Design.UITypeEditor, System.Drawing")]
        public string UseAsParent
        {
            get { return _useAsParent; }
            set { _useAsParent = value; }
        }

        
        private string _selectedMember;

        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design", "System.Drawing.Design.UITypeEditor, System.Drawing")]
        public string SelectedMember
        {
            get { return _selectedMember; }
            set { _selectedMember = value; }
        }


        private Hashtable _nodesByValueMember  = new Hashtable ();
        private IBindingList _list;
        [TypeConverter("System.Windows.Forms.Design.DataSourceConverter, System.Design")]
        public IBindingList DataSource
        {
            get
            {
                return _list;
            }
            set
            {
                if (_list != null)
                {
                    _list.ListChanged -= new ListChangedEventHandler(_list_ListChanged); 
                }
                if (value == null)
                {
                    _list = null;
                    this.Nodes.Clear();
                }

                if (value != null)
                {
                    _list = value;
                    _list.ListChanged += new ListChangedEventHandler(_list_ListChanged);
                    
                    InitTree();
                }

            }
        }	    
    	

        void _list_ListChanged(object sender, ListChangedEventArgs e)
        {
            switch (e.ListChangedType)
            {
                case ListChangedType.Reset:
                    InitTree();
                    break;
                case ListChangedType.ItemDeleted :
                    object obj_id = ReflectionHelper.GetPropertyValue(_list[e.NewIndex], _valueMember);
                    CoreTreeNode node = _nodesByValueMember[obj_id] as CoreTreeNode;
                    if (node == null) break;
                    if (node.TreeView != null)
                    {
                        node.Remove();
                    }
                    
                    break;
                case ListChangedType.ItemAdded :
                    WireUpNode(CreateNode(_list[e.NewIndex]));
                    break;
                case ListChangedType.ItemChanged:
                    object id = ReflectionHelper.GetPropertyValue(_list[e.NewIndex], this.ValueMember);
                    object parent_id = ReflectionHelper.GetPropertyValue(_list[e.NewIndex], this.ParentMember);
                    CoreTreeNode changednode = _nodesByValueMember[id] as CoreTreeNode;
                    if (changednode == null) break;
                    if (changednode.Checked != (bool)ReflectionHelper.GetPropertyValue(changednode.Data, this.SelectedMember))
                    {
                        changednode.Checked = !changednode.Checked;
                    }

                    string p1 = (parent_id == null) ? "" : parent_id.ToString();
                    string p2 = (changednode.ParentValue == null) ? "" : changednode.ParentValue.ToString();
                    if (p1 != p2)
                    {
                        CoreTreeNode parentnode = _nodesByValueMember[id] as CoreTreeNode;
                        parentnode.Nodes.Add(changednode);
                    }
                    break;
            }
        }

        private void CoreTreeView_AfterCheck(object sender, TreeViewEventArgs e)
        {
            CoreTreeNode node = e.Node as CoreTreeNode;
            if (SelectedMember != "")
            {
                ReflectionHelper.SetPropertyValue(node.Data, SelectedMember, e.Node.Checked);
            }
        }


    }
}
