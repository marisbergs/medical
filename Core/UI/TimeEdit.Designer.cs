namespace Core.UI
{
    partial class TimeEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTime = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTime.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(0, 0);
            this.txtTime.Margin = new System.Windows.Forms.Padding(0);
            this.txtTime.Name = "txtTime";
            this.txtTime.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTime.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.txtTime.Properties.DisplayFormat.FormatString = "t";
            this.txtTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTime.Properties.EditFormat.FormatString = "t";
            this.txtTime.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTime.Properties.Mask.EditMask = "(0?\\d|1\\d|2[0-3])\\R:([0-5]\\d)";
            this.txtTime.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtTime.Properties.Mask.SaveLiteral = false;
            this.txtTime.Properties.Mask.ShowPlaceHolders = false;
            this.txtTime.Size = new System.Drawing.Size(55, 20);
            this.txtTime.TabIndex = 0;
            // 
            // TimeEdit
            // 
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Margin = new System.Windows.Forms.Padding(0);
            ((System.ComponentModel.ISupportInitialize)(this.txtTime.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtTime;
    }
}
