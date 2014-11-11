using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Core.UI
{
    // Assumptions:
    //   Checkboxes are in column 0
    //   Last row is for buttons
    //   If checkbox is disabled, that row will be never appear

    /// <summary>
    /// Helper functions for "TPAIS standard" search controls.
    /// </summary>
    /// <remarks>
    /// "TPAIS standard" search control:
    /// * Table layout with (at least) 2 columns.
    /// * Each row describes a single search criteria.
    /// * Checkbox in first column determines if this criteria has to be included in search.
    /// * The rest of the row is occupied by controls that contain criteria values.
    /// * Last row is special: while there can be usual checkbox in first column,
    ///   the rest of the row is empty or is occupied by command buttons, like btnShowAll, btnReset, btnFind.
    /// </remarks>
    public static class SearchControlHelper
    {
        /// <summary>
        /// Collapses the <paramref name="panTableLayout"/> vertically, by hiding all controls that are in "unchecked" rows.
        /// </summary>
        /// <param name="panTableLayout">"Standard" table layout of the search control.</param>
        /// <param name="ctlShowAll">Control (usually command button) that is used to "Expand" the layout.</param>
        /// <remarks>
        /// Exceptions:
        /// * Rows that have disabled checkbox will be always hidden
        /// * Last row is always kept visible
        /// </remarks>
        /// <seealso cref="SearchControlHelper.Expand"/>
        public static void Collapse(TableLayoutPanel panTableLayout, Control ctlShowAll)
        {
            int rowCount = panTableLayout.GetRowHeights().Length;
            int colCount = panTableLayout.GetColumnWidths().Length;
            for (int r = 0; r < rowCount-1; ++r)
            {
                Control chk = panTableLayout.GetControlFromPosition(0, r);
                if (chk is CheckBox)
                {
                    if (!((chk as CheckBox).Checked && chk.Enabled))
                    {
                        panTableLayout.SuspendLayout();
                        try
                        {
                            for (int c = 0; c < colCount; ++c)
                            {
                                Control ctl = panTableLayout.GetControlFromPosition(c, r);
                                if (ctl != null)
                                    ctl.Visible = false;
                            }
                        }
                        finally
                        {
                            panTableLayout.ResumeLayout();
                        }
                    }
                }
            }
            if (ctlShowAll != null)
                ctlShowAll.Enabled = true;
        }

        /// <summary>
        /// Expands the <paramref name="panTableLayout"/> vertically, by showing all rows.
        /// </summary>
        /// <param name="panTableLayout">"Standard" table layout of the search control.</param>
        /// <param name="ctlShowAll">Control (usually command button) that is used to "Expand" the layout.</param>
        /// <remarks>
        /// Exceptions:
        /// * Rows that have disabled checkbox will be always hidden
        /// * Last row is always visible
        /// </remarks>
        public static void Expand(TableLayoutPanel panTableLayout, Control ctlShowAll)
        {
            int rowCount = panTableLayout.GetRowHeights().Length;
            int colCount = panTableLayout.GetColumnWidths().Length;
            for (int r = rowCount - 1; r >= 0; --r)
            {
                panTableLayout.SuspendLayout();
                try
                {
                    bool visible = true;
                    // Hide (or keep hidden) row if there is a disabled checkbox in column 0
                    Control chk = panTableLayout.GetControlFromPosition(0, r);
                    if (chk is CheckBox)
                        visible = (r == rowCount-1) || (chk as CheckBox).Enabled;
                    for (int c = 0; c < colCount; ++c)
                    {
                        Control ctl = panTableLayout.GetControlFromPosition(c, r);
                        if (ctl != null)
                            ctl.Visible = visible;
                    }
                }
                finally
                {
                    panTableLayout.ResumeLayout();
                }
            }
            if (ctlShowAll != null)
                ctlShowAll.Enabled = false;
        }

        /// <summary>
        /// Binds the Enabled property of all controls to the Checked property of checkboxes from column 0
        /// of the same row in the tableLayoutPanel.
        /// Exception: no bindings for the last row.
        /// </summary>
        /// <param name="panTableLayout">"Standard" table layout of the search control.</param>
        /// <remarks></remarks>
        public static void SetupEnabledWhenCheckedBindings(TableLayoutPanel panTableLayout)
        {
            int rowCount = panTableLayout.GetRowHeights().Length;
            int colCount = panTableLayout.GetColumnWidths().Length;
            panTableLayout.SuspendLayout();
            try
            {
                for (int r = 0; r < rowCount - 1; ++r)
                {
                    Control chk = panTableLayout.GetControlFromPosition(0, r);
                    if ((chk != null) && (chk is CheckBox))
                    {
                        for (int c = 1; c < colCount; ++c)
                        {
                            Control ctl = panTableLayout.GetControlFromPosition(c, r);
                            if (ctl != null)
                                ctl.DataBindings.Add("Enabled", chk, "Checked");
                        }
                    }
                }
            }
            finally
            {
                panTableLayout.ResumeLayout(false);
            }
        }

        /// <summary>
        /// Binds controls in the tableLayoutPanel to datamembers of the dataSource, using simple naming conventions.
        /// </summary>
        /// <param name="panTableLayout">"Standard" table layout of the search control.</param>
        /// <param name="dataSource">Search object associated with the search control.</param>
        /// <remarks>
        /// Checkboxes "chk..." are bound to properties that are named "Use..."
        /// Textboxes "txt..." are bound to properties that are named "..."
        /// Dx.DateEdits "dtp..." are bound to properties that are named "..."
        /// Dx.TimeEdits "dtp..." are bound to properties that are named "..."
        /// Dx.ButtonEdits "txt..." are bound to properties that are named "..."
        /// Controls are bound recursive, using parent control names as prefixes.
        ///     Example: If container's name is "pnlValid", and it contains DateEdit with name dtpFrom,
        ///              then dtpFrom.EditValue will be bound to dataSource's property ValidFrom.
        /// </remarks>
        public static void BindByNamingConventions(TableLayoutPanel panTableLayout, Object dataSource)
        {
            int rowCount = panTableLayout.GetRowHeights().Length;
            int colCount = panTableLayout.GetColumnWidths().Length;
            panTableLayout.SuspendLayout();
            try
            {
                // Cycle thru all the cells except the last one (with buttons)
                for (int r = 0; r < rowCount; ++r)
                {
                    for (int c = 0; c < colCount; ++c)
                    {
                        if ((r != rowCount - 1) || (c != colCount - 1))
                        {
                            Control ctl = panTableLayout.GetControlFromPosition(c, r);
                            if (ctl != null)
                                BindRecursive(ctl, dataSource, "");
                        }
                    }
                }
            }
            finally
            {
                panTableLayout.ResumeLayout(false);
            }
        }

        /// <summary>
        /// Tries to bind a control or it's descendants, if any
        /// </summary>
        /// <param name="ctl">Control (possibly a Container)</param>
        /// <param name="dataSource">Data source to bind with</param>
        /// <param name="prefix">Prefix to use </param>
        private static void BindRecursive(Control ctl, Object dataSource, String prefix)
        {
            if ((ctl is CheckBox) && (ctl.Name.Substring(0, 3) == "chk"))
                AddBinding(ctl, "Checked", dataSource, "Use" + prefix + ctl.Name.Substring(3), null);
            else if ((ctl is DevExpress.XtraEditors.DateEdit) && (ctl.Name.Substring(0, 3) == "dtp"))
                AddBinding(ctl, "EditValue", dataSource, prefix + ctl.Name.Substring(3), null);
            else if ((ctl is DevExpress.XtraEditors.TimeEdit) && (ctl.Name.Substring(0, 3) == "dtp"))
                AddBinding(ctl, "EditValue", dataSource, prefix + ctl.Name.Substring(3), null);
            else if ((ctl is DevExpress.XtraEditors.ButtonEdit) && (ctl.Name.Substring(0, 3) == "txt"))
                AddBinding(ctl, "EditValue", dataSource, prefix + ctl.Name.Substring(3), "1"); // customFormat is bs
            else if ((ctl is TextBox) && (ctl.Name.Substring(0, 3) == "txt"))
                AddBinding(ctl, "Text", dataSource, prefix + ctl.Name.Substring(3), null);
            foreach (Control child in ctl.Controls)
                if (child.Name.Length > 3) // Ignore some internal components
                    BindRecursive(child, dataSource, prefix + ctl.Name.Substring(3));
        }

        /// <summary>
        /// Tries to bind. If dataMember does not exist, shows message in debug mode.
        /// </summary>
        /// <param name="ctl">Control to bind.</param>
        /// <param name="propertyName">Property of control to bind.</param>
        /// <param name="dataSource">Data source to bind to.</param>
        /// <param name="dataMember">Data member to bind to.</param>
        private static void AddBinding( Control ctl, string propertyName, Object dataSource, string dataMember, string customFormat )
        {
            if (ReflectionHelper.PropertyExists(dataSource, dataMember))
            {
                if (customFormat == null)
                    ctl.DataBindings.Add(propertyName, dataSource, dataMember, true, DataSourceUpdateMode.OnPropertyChanged);
                else
                    ctl.DataBindings.Add(propertyName, dataSource, dataMember, true, DataSourceUpdateMode.OnPropertyChanged, null, customFormat);
            }
            else
            {
                #if DEBUG
                MessageBox.Show(string.Format("Cannot find data member {2} for binding of {0}.{1}", ctl.Name, propertyName, dataMember));
                #endif
            }
        }
    }
}