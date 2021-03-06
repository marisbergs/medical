using System.Windows.Forms;
using System;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace Core.UI
{
    /// <summary>
    /// control for adding and deleting records
    /// </summary>
    public partial class GridButtonHelper : FlowLayoutPanel
    {
        ///<summary>
        ///Initialize GridButtonHelper
        ///</summary>
        public GridButtonHelper()
        {
            InitializeComponent();
            this.Controls.Add(btnAddNew);
            this.Controls.Add(btnDelete);
            this.Controls.Add(chkShowActive);
        }

        CoreGrid grid;

        ///<summary>
        ///Return grid witw which will work helper
        ///</summary>
        public CoreGrid Grid
        {
            get
            {
                return grid;
            }
            set
            {
                grid = value;
                if (grid == null) return;                             
            }
        }

        BindingSource gridDataSource;
        ///<summary>
        ///Return grid bindingsource for btnDelete enabled change
        ///</summary>
        public BindingSource GridDataSource
        {
            get
            {
                return gridDataSource;
            }
            set
            {
                gridDataSource = value;
                if (gridDataSource == null) return;
                gridDataSource.CurrentItemChanged += new EventHandler(gridDataSource_CurrentItemChanged);
                GridDataSource.DataSourceChanged += new EventHandler(gridDataSource_CurrentItemChanged);
                //this.btnDelete.DataBindings.Add("Enabled", gridDataSource, "IsActive");
            }
        }       

        Boolean deleteReason;
        ///<summary>
        ///Is necessary delete reason form
        /// </summary>
        public Boolean DeleteReason
        {
            get
            {
                return deleteReason;
            }
            set
            {
                deleteReason = value;
            }
        }

        Boolean showAdd = true;
        ///<summary>
        ///Display Add button
        /// </summary>
        public Boolean ShowAdd
        {
            get
            {
                return showAdd;
            }
            set
            {
                showAdd = value;
                btnAddNew.Visible = showAdd;
            }
        }

        Boolean showDelete = true;
        ///<summary>
        ///Display Delete button
        /// </summary>
        public Boolean ShowDelete
        {
            get
            {
                return showDelete;
            }
            set
            {
                showDelete = value;
                btnDelete.Visible = showDelete;
            }
        }

        Boolean useCanDelete = true;
        ///<summary>
        ///Display Delete button
        /// </summary>
        public Boolean UseCanDelete
        {
            get
            {
                return useCanDelete;
            }
            set
            {
                useCanDelete = value;
            }
        }


        Boolean showChk = true;
        ///<summary>
        ///Display checkbox
        /// </summary>
        public Boolean ShowChk
        {
            get
            {
                return showChk;
            }
            set
            {
                showChk = value;
                chkShowActive.Visible = showChk;
            }
        }

        GridColumn  deleteReasonColumn;

        ///<summary>
        ///Delete reason column name in grid
        ///</summary>
        public GridColumn DeleteReasonColumn
        {
            get
            {
                return deleteReasonColumn;
            }
            set
            {
                deleteReasonColumn = value;
                if (deleteReasonColumn == null) return;
            }
        }

        ///<summary>
        ///Define delegate for new record
        ///</summary>
        public delegate void AddNewEventDelegate(object sender, AddNewEventArgs args );

        ///<summary>
        ///Define new record adding event
        ///</summary>
        public event AddNewEventDelegate OnAddNew;

        ///<summary>
        ///Define delegate for delete record
        ///</summary>
        public delegate void DeleteEventDelegate(object sender, DeleteEventArgs args);

        ///<summary>
        ///Define record delete event
        ///</summary>
        public event DeleteEventDelegate OnDelete;
        
        private void InitializeComponent()
        {
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.chkShowActive = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(0, 0);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Pievienot";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(0, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Dzēst";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // chkShowActive
            // 
            this.chkShowActive.AutoSize = true;
            this.chkShowActive.Location = new System.Drawing.Point(0, 0);
            this.chkShowActive.Name = "chkShowActive";
            this.chkShowActive.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.chkShowActive.Size = new System.Drawing.Size(104, 24);
            this.chkShowActive.TabIndex = 3;
            this.chkShowActive.Text = "Tikai aktuālie";
            this.chkShowActive.UseVisualStyleBackColor = true;
            this.chkShowActive.CheckedChanged += new System.EventHandler(this.chkShowActive_CheckedChanged);
            this.ResumeLayout(false);

        }

        private Button btnAddNew;

        public Button AddNewButton
        {
            get { return btnAddNew; }
            set { btnAddNew = value; }
        }
        private Button btnDelete;

        public Button DeleteButton
        {
            get { return btnDelete; }
            set { btnDelete = value; }
        }

        private CheckBox chkShowActive;

        private void chkShowActive_CheckedChanged(object sender, System.EventArgs e)
        {
            if (grid == null) return;
            grid.ShowOnlyActive = chkShowActive.Checked;
            if (DeleteReasonColumn == null) return;
            DeleteReasonColumn.Visible = !chkShowActive.Checked && deleteReason;            
        }

        /// <summary>
        /// Set checkbox status for filtr active records
        /// </summary>
        public bool ShowActive
        {
            get
            {
                return chkShowActive.Checked;
            }
            set
            {
                chkShowActive.Checked = value;
            }
        }        
        /// <summary>
        /// Record delete
        /// </summary>
        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            if (grid == null) return;
            CurrencyManager cm = (CurrencyManager)grid.BindingContext[grid.DataSource, grid.DataMember];            
            
                if (cm.Position == -1) return;
                Core.Bll.IBusinessObjectBase bo = cm.Current as Core.Bll.IBusinessObjectBase;

                if (OnDelete != null)
                {
                    DeleteEventArgs args = new DeleteEventArgs();
                    OnDelete(this, args);

                    //if delete confirm
                    if (args.CancelDelete == false)
                    {
                        //Check if record not saved in DB then delete phisicaly
                        if (bo.GetPropertyValue<System.Guid>("Id") == Guid.Empty)
                        {
                            bo.IsActive = false;
                            cm.RemoveAt(cm.Position);
                            return;
                        }
                        //if necessary delete reason
                        if (deleteReason)
                        {
                            if (args.Object.GetType().Name == "String")
                            {
                                bo.DeleteNotes = args.Object.ToString();
                            }
                            else
                            {
                                TextBox obj = (TextBox)args.Object;
                                bo.DeleteNotes = obj.Text;
                            }
                        }
                        //set record not active
                        bo.IsActive = false;
                    }
                }
                else
                {
                    if (MsgBox.DeleteMessage() == DialogResult.Yes)
                    {
                        //Check if record not saved in DB then delete phisicaly
                        if (bo.GetPropertyValue<System.Guid>("Id") == Guid.Empty)
                        {
                            bo.IsActive = false;
                            cm.RemoveAt(cm.Position);
                            //return;
                        }
                        else
                        {
                            //set record not active
                            bo.IsActive = false;
                        }
                    }
                }

                BindingSource source = (BindingSource)grid.DataSource;
                if (!(source == null))
                {
                    GridView gv = grid.DefaultView as GridView;
                    gv.RefreshData();
                    if (gv.FocusedRowHandle >= 0 && gv.FocusedRowHandle < gv.RowCount)
                    {
                        source.Position = source.IndexOf(gv.GetRow(gv.FocusedRowHandle));
                    }
                }
                if (grid != null)
                {
                    if (grid.EnforceCanEdit)
                    {
                        grid.UpdateReadonlyRowStatus();
                    }
                    else
                    {
                        grid.EnforceCanEdit = true;
                        grid.UpdateReadonlyRowStatus();
                        grid.EnforceCanEdit = false;
                    }                   
                }
                //if (grid.ShowOnlyActive)
                //{
                //    grid.ShowOnlyActive = false;
                //    grid.ShowOnlyActive = true;
                //}
                
        }

        private void btnAddNew_Click(object sender, System.EventArgs e)
        {
            if (grid == null) return;
            
            CurrencyManager cm = (CurrencyManager)grid.BindingContext[grid.DataSource, grid.DataMember];
            
            if (OnAddNew != null)
            {
                AddNewEventArgs args = new AddNewEventArgs();
                OnAddNew(this, args);                
                if (args.CancelAdd == false)
                {
                    if (!cm.List.Contains(args.AddedObject))
                        cm.List.Add(args.AddedObject);
                }
                if (args.AddedObject != null)
                {
                    cm.Position = cm.List.IndexOf(args.AddedObject);
                }
            }
            else
            {
                cm.AddNew();
            }            
            grid.UpdateReadonlyRowStatus();
            //if (ShowActive)
            //    {
            //        ShowActive = false;
            //        ShowActive = true;
            //    }

        }

        private void gridDataSource_CurrentItemChanged(object sender, System.EventArgs e)
        {
            if (!useCanDelete) return;

            BindingSource source = (BindingSource)sender;
            if (source.Current == null)
            {
                btnDelete.Enabled = false;
                return;
            }
            if (btnDelete.DataBindings.Count > 0)
            {
                btnDelete.DataBindings.Clear();
                //source.Current == null ? false : true;
            }
            btnDelete.DataBindings.Add ("Enabled", gridDataSource, "CanDelete", false, DataSourceUpdateMode.OnPropertyChanged );
        }

        /// <summary>
        /// New record adding arguments
        /// </summary>
        public class AddNewEventArgs : EventArgs
        {
            /// <summary>
            /// New record
            /// </summary>
            public object AddedObject;

            /// <summary>
            /// Cancel adding new record
            /// </summary>
            public bool CancelAdd = true;
        }

        /// <summary>
        /// Record delete reason arguments
        /// </summary>
        public class DeleteEventArgs : EventArgs
        {
            /// <summary>
            /// Delete reason
            /// </summary>
            public object Object;

            /// <summary>
            /// Cancel deleting record
            /// </summary>
            public bool CancelDelete = true;

        }  
        
    }
}
