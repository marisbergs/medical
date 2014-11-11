using System;
using System.Reflection;
using Core.Dal;
using DevExpress.Utils;
using DevExpress;

namespace Core.UI
{
    public partial class CoreMoneySpinEdit : DevExpress.XtraEditors.SpinEdit
    {

        public CoreMoneySpinEdit()
            : base()
        {
            this.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Control;
            this.Properties.AppearanceDisabled.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.Utils.HorzAlignment.Center, null)});
            this.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.None;
            this.Properties.DisplayFormat.FormatString = null;
            this.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.None;
            this.Properties.EditFormat.FormatString = null;
            this.Properties.Mask.EditMask = "###########,##0.00;";
            this.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Properties.Mask.ShowPlaceHolders=false;
            this.Properties.Mask.UseMaskAsDisplayFormat=true;
        }    
    }

    public partial class CoreIntegerSpinEdit : DevExpress.XtraEditors.SpinEdit
    {

        public CoreIntegerSpinEdit()
            : base()
        {
            this.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Control;
            this.Properties.AppearanceDisabled.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.Utils.HorzAlignment.Center, null)});
            this.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.None;
            this.Properties.DisplayFormat.FormatString = null;
            this.Properties.EditFormat.FormatString = null;
            this.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.None;
            this.Properties.Mask.EditMask = "######,###;";
            this.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Properties.Mask.ShowPlaceHolders = false;
            this.Properties.Mask.UseMaskAsDisplayFormat = true;
        }
    }

    public partial class CoreMoneySpinEditRepositoryItem : DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    {

        public CoreMoneySpinEditRepositoryItem()
            : base()
        {
            this.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DisplayFormat.FormatString = "n2";
            this.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.EditFormat.FormatString = "n2";
            this.Name = "CoreMoneySpinEditRepositoryItem_default";
            this.MaxValue = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            131072});
        }
    }
}


