namespace Core.UI
{
    partial class PeriodWithTimePickerSecond
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
            this.dtpDateFromSecond = new DevExpress.XtraEditors.DateEdit();
            this.lblDateUntil = new System.Windows.Forms.Label();
            this.dtpDateUntilSecond = new DevExpress.XtraEditors.DateEdit();
            this.dtpTimeFromSecond = new Core.UI.TimeEdit();
            this.dtpTimeUntilSecond = new Core.UI.TimeEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateFromSecond.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateUntilSecond.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDateFromSecond
            // 
            this.dtpDateFromSecond.AllowDrop = true;
            this.dtpDateFromSecond.EditValue = null;
            this.dtpDateFromSecond.Location = new System.Drawing.Point(0, 0);
            this.dtpDateFromSecond.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.dtpDateFromSecond.Name = "dtpDateFromSecond";
            this.dtpDateFromSecond.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)});
            this.dtpDateFromSecond.Size = new System.Drawing.Size(100, 20);
            this.dtpDateFromSecond.TabIndex = 0;
            // 
            // lblDateUntil
            // 
            this.lblDateUntil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDateUntil.AutoSize = true;
            this.lblDateUntil.Location = new System.Drawing.Point(0, 0);
            this.lblDateUntil.Name = "lblDateUntil";
            this.lblDateUntil.Size = new System.Drawing.Size(100, 20);
            this.lblDateUntil.TabIndex = 0;
            this.lblDateUntil.Text = "līdz:";
            this.lblDateUntil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpDateUntilSecond
            // 
            this.dtpDateUntilSecond.EditValue = null;
            this.dtpDateUntilSecond.Location = new System.Drawing.Point(0, 0);
            this.dtpDateUntilSecond.Margin = new System.Windows.Forms.Padding(3, 0, 15, 0);
            this.dtpDateUntilSecond.Name = "dtpDateUntilSecond";
            this.dtpDateUntilSecond.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)});
            this.dtpDateUntilSecond.Size = new System.Drawing.Size(100, 20);
            this.dtpDateUntilSecond.TabIndex = 0;
            // 
            // dtpTimeFromSecond
            // 
            this.dtpTimeFromSecond.AutoSize = true;
            this.dtpTimeFromSecond.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dtpTimeFromSecond.EditValue = null;
            this.dtpTimeFromSecond.Location = new System.Drawing.Point(0, 0);
            this.dtpTimeFromSecond.Margin = new System.Windows.Forms.Padding(0);
            this.dtpTimeFromSecond.Name = "dtpTimeFromSecond";
            this.dtpTimeFromSecond.Size = new System.Drawing.Size(200, 100);
            this.dtpTimeFromSecond.TabIndex = 0;
            // 
            // dtpTimeUntilSecond
            // 
            this.dtpTimeUntilSecond.AutoSize = true;
            this.dtpTimeUntilSecond.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dtpTimeUntilSecond.EditValue = null;
            this.dtpTimeUntilSecond.Location = new System.Drawing.Point(0, 0);
            this.dtpTimeUntilSecond.Margin = new System.Windows.Forms.Padding(0);
            this.dtpTimeUntilSecond.Name = "dtpTimeUntilSecond";
            this.dtpTimeUntilSecond.Size = new System.Drawing.Size(200, 100);
            this.dtpTimeUntilSecond.TabIndex = 0;
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateFromSecond.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateUntilSecond.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TimeEdit dtpTimeFromSecond;
        private DevExpress.XtraEditors.DateEdit dtpDateFromSecond;
        private System.Windows.Forms.Label lblDateUntil;
        private TimeEdit dtpTimeUntilSecond;
        private DevExpress.XtraEditors.DateEdit dtpDateUntilSecond;
    }
}
