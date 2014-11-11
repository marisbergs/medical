using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using System.Reflection;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;
using Core.Dal;

namespace Core.UI
{
    public partial class CoreGrid : DevExpress.XtraGrid.GridControl
    {
        private StyleFormatCondition isActiveStyle;
        public Color activeRow = System.Drawing.SystemColors.HighlightText;
        public Color deletedRow = Color.Red;
        public Color activeCell = System.Drawing.SystemColors.WindowText;
        public Color deletedCell = Color.Red;
        private DevExpress.XtraEditors.Repository.PersistentRepository rep = new DevExpress.XtraEditors.Repository.PersistentRepository();
        //public CoreMoneySpinEditRepositoryItem SpinEdit = new CoreMoneySpinEditRepositoryItem();
            
        public CoreGrid()
            : base()
        {
            InitializeComponent();
            DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepItem = SpinEdit();
            //foreach (DevExpress.XtraEditors.Repository.RepositoryItem var in RepositoryItems)
            //{
            //    if (var.Name = "CoreMoneySpinEditRepositoryItem_default")
            //    {
            //        break;
            //    }
            //}

            //if (!rep.Items.Contains(RepItem))
            //{
            //    rep.Items.Add(RepItem);
            //    this.RepositoryItems.Add(RepItem);
            //}   
            //ExternalRepository = rep;
            if (DesignerDetector.IsComponentInDesignMode(this)) return;    
            isActiveStyle = new StyleFormatCondition();
            isActiveStyle.Condition = FormatConditionEnum.Equal;
            isActiveStyle.Value1 = false;
            isActiveStyle.ApplyToRow = true;
            isActiveStyle.Appearance.ForeColor = Color.Red;
            isActiveStyle.Appearance.Options.UseForeColor = true;

            //Font f = isActiveStyle.Appearance.ParentAppearance.Font;

            //isActiveStyle.Appearance.Font = new Font(f, FontStyle.Italic);
            //isActiveStyle.Appearance.Options.UseFont = true;

        }
        protected override void OnLoaded()
        {
            if (DesignerDetector.IsComponentInDesignMode(this))
            {
                base.OnLoaded();
                return;
            }
            GridView gv = this.DefaultView as GridView;
            if (gv == null) return;
            GridColumn isActiveColumn = gv.Columns["IsActive"];
            if (isActiveColumn != null)
            {
                isActiveStyle.Column = isActiveColumn;
                gv.FormatConditions.Add(isActiveStyle);
            }
            gv.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(gv_CustomUnboundColumnData);
            //gv.RowCountChanged += new EventHandler(gv_RowCountChanged);
            base.OnLoaded();
        }

        //void gv_RowCountChanged(object sender, EventArgs e)
        //{
        //    return;
        //    BindingSource source = (BindingSource)this.DataSource;
        //    if (!(source == null))
        //    {
        //        GridView gv = this.DefaultView as GridView;
        //        if (gv.FocusedRowHandle >= 0 && gv.FocusedRowHandle <= gv.RowCount - 1)
        //        {
        //            source.Position = source.IndexOf(gv.GetRow(gv.FocusedRowHandle));
        //           }
        //    }
        //}

        public void SetListMode()
        {
            _enforceCanEdit = false;
            GridView gv = this.DefaultView as GridView;
            if (gv == null) return;
            gv.OptionsBehavior.Editable = true;
            gv.OptionsView.ShowGroupPanel = false;
            gv.OptionsView.ShowFilterPanel = false;
            gv.OptionsDetail.EnableMasterViewMode = false;
            gv.OptionsMenu.EnableColumnMenu = false;
            gv.OptionsMenu.EnableFooterMenu= false;
            gv.OptionsMenu.EnableGroupPanelMenu = false;
            gv.OptionsCustomization.AllowFilter = false;
            foreach (GridColumn column in gv.Columns)
            {
                if (column.FieldName == "Selected")
                {
                    column.OptionsColumn.AllowFocus = true;
                    column.OptionsColumn.AllowEdit = true;
                    continue; 
                }

                column.OptionsColumn.ReadOnly = true;
                column.OptionsColumn.AllowFocus = false;
            }
        }
        // HACK: temporarily changed to private
        private void SetCheckedListMode()
        {
            _enforceCanEdit = true;
            GridView gv = this.DefaultView as GridView;
            if (gv == null) return;
            gv.OptionsBehavior.Editable = true;
            gv.OptionsView.ShowGroupPanel = false;
            gv.OptionsView.ShowFilterPanel = false;
            gv.OptionsDetail.EnableMasterViewMode = false;
            gv.OptionsMenu.EnableColumnMenu = false;
            gv.OptionsMenu.EnableFooterMenu = false;
            gv.OptionsMenu.EnableGroupPanelMenu = false;
            gv.OptionsCustomization.AllowFilter = false;
            foreach (GridColumn column in gv.Columns)
            {
                column.OptionsColumn.AllowFocus = false;
                column.OptionsColumn.AllowEdit = (column.VisibleIndex == 0);
            }
            EnforceCanEdit = false;
        }


        public void SetEditMode()
        {
            GridView gv = this.DefaultView as GridView;
            if (gv == null) return;
            EnforceCanEdit = true;
            gv.OptionsView.ShowGroupPanel = false;
            gv.OptionsView.ShowFilterPanel = false;
            gv.OptionsDetail.EnableMasterViewMode = false;
            gv.OptionsMenu.EnableColumnMenu = false;
            gv.OptionsMenu.EnableFooterMenu = false;
            gv.OptionsMenu.EnableGroupPanelMenu = false;
            gv.OptionsCustomization.AllowFilter = false;
            foreach (GridColumn column in gv.Columns)
            {
                column.OptionsColumn.AllowFocus = true;
                column.OptionsColumn.AllowEdit = true;
            }
            CoreGrid_BindingContextChanged(this, EventArgs.Empty);
        }

        public DevExpress.XtraEditors.Repository.RepositoryItemTextEdit SpinEdit() 
        {
            DevExpress.XtraEditors.Repository.RepositoryItemTextEdit itm = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            itm.Mask.EditMask = @"\d{0,10}(\R.\d{0,2})?";
            itm.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            itm.Mask.ShowPlaceHolders = false;
            itm.Mask.UseMaskAsDisplayFormat = false;
            itm.Mask.SaveLiteral = false;
             return itm;
        }

        public DevExpress.XtraEditors.Repository.RepositoryItemTextEdit MoneyEdit()
        {
            DevExpress.XtraEditors.Repository.RepositoryItemTextEdit itm = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            itm.Mask.EditMask = @"\d{0,10}(\R.\d{0,2})?";
            itm.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            itm.Mask.ShowPlaceHolders = false;
            itm.Mask.UseMaskAsDisplayFormat = false;
            itm.Mask.SaveLiteral = false;
            return itm;
        }

        public void Export()
        {
            GridView gv = DefaultView as GridView;
            if (gv == null) return;
            string tempPath = System.IO.Path.GetTempPath() + Guid.NewGuid() + ".xls";
            gv.ExportToExcel(tempPath);
            Core.Helper.RunShell(tempPath);
        }

        void gv_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            // HACK : for performance considerations
            //if (DesignerDetector.IsComponentInDesignMode(this)) return;
            // poor naming, sloppy algorithm 
            GridView view = sender as GridView;
            if (e.RowHandle == -1) return;
            object o = view.GetRow(e.RowHandle);
            object prev = o;
            
            Type t = o.GetType();
            string s = e.Column.FieldName as string;
            PropertyInfo pi = null;
            foreach (string elementName in s.Split('.'))
            {
                pi = ReflectionHelper.LocateProperty(t, elementName, BindingFlags.Instance|BindingFlags.Public);
                prev = o;
                o = pi.GetValue(o, null);
                if (o == null) break;
                t = o.GetType();
            }

            if (e.IsGetData)
            {               
                e.Value = o;
            }
            if (e.IsSetData)
            {
                pi.SetValue(prev, e.Value, null);
            }
        }

        //private GridView gridView1;

        bool showOnlyActive;
        public bool ShowOnlyActive
        {
            set
            {
                if (showOnlyActive != value)
                {
                    showOnlyActive = value;
                    GridView gv = this.DefaultView as GridView;
                    if (gv.Columns.Count < 1) return;
                    if (showOnlyActive)
                    {
                        gv.Columns[0].FilterInfo = new DevExpress.XtraGrid.Columns.ColumnFilterInfo("IsActive = true", "");
                    }
                    else
                    {
                        gv.Columns[0].ClearFilter();
                    }

                }
                UpdateReadonlyRowStatus();
            }
            get
            {
                return showOnlyActive;
            }

        }

        private void InitializeComponent()
        {
            this.BindingContextChanged += new System.EventHandler(this.CoreGrid_BindingContextChanged);
    
        }

        private CurrencyManager cm;

        bool _enforceCanEdit = false;
        public bool EnforceCanEdit
        {
            get { return _enforceCanEdit; }
            set { _enforceCanEdit = value; }
        }
        private void CoreGrid_BindingContextChanged(object sender, EventArgs e)
        {
            if (DesignerDetector.IsComponentInDesignMode(this)) return; 
            //if (!_enforceCanEdit) return;
            if (cm != null)
            {
                cm.PositionChanged -= new EventHandler(cm_PositionChanged);
            }
            if (DataSource == null) return;
            cm = this.BindingContext[DataSource, DataMember] as CurrencyManager;

            if (cm == null) return; 
            cm.PositionChanged += new EventHandler(cm_PositionChanged);
            UpdateReadonlyRowStatus();

            
        }

        void cm_PositionChanged(object sender, EventArgs e)
        {
            UpdateReadonlyRowStatus();
        }

        public void UpdateReadonlyRowStatus()
        {
            if (cm == null) return;
            if (cm.Position == -1) return;
            //int pos = cm.Position;
            IConstrained current = cm.Current as IConstrained;
            if (current == null) return;

            GridView gv = this.DefaultView as GridView;
            if (gv == null) return;
            if (gv.FocusedRowHandle >= 0)
            {
                if (!current.IsActive)
                {
                    gv.Appearance.FocusedRow.ForeColor = deletedRow;
                    gv.Appearance.FocusedCell.ForeColor = deletedCell;
                    gv.Appearance.HideSelectionRow.ForeColor = deletedRow;
                }
                else
                {
                    gv.Appearance.FocusedRow.ForeColor = activeRow;
                    gv.Appearance.FocusedCell.ForeColor = activeCell;
                    gv.Appearance.HideSelectionRow.ForeColor = activeRow;
                }
            }
            if (!_enforceCanEdit) return;
            
            //gv.RefreshData();
            //cm.Position = pos;
            gv.OptionsBehavior.Editable = current.CanEdit;
        }

    }
}


