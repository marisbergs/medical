namespace Core.UI
{
	partial class PeriodWithTimePicker
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
            this.dtpDateFrom = new DevExpress.XtraEditors.DateEdit();
            this.dtpDateUntil = new DevExpress.XtraEditors.DateEdit();
            this.lblDateUntil = new System.Windows.Forms.Label();
            this.dtpTimeFrom = new Core.UI.TimeEdit();
            this.dtpTimeUntil = new Core.UI.TimeEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateUntil.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.AllowDrop = true;
            this.dtpDateFrom.EditValue = null;
            this.dtpDateFrom.Location = new System.Drawing.Point(0, 0);
            this.dtpDateFrom.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)});
            this.dtpDateFrom.Size = new System.Drawing.Size(100, 20);
            this.dtpDateFrom.TabIndex = 0;
            // 
            // dtpDateUntil
            // 
            this.dtpDateUntil.EditValue = null;
            this.dtpDateUntil.Location = new System.Drawing.Point(0, 0);
            this.dtpDateUntil.Margin = new System.Windows.Forms.Padding(3, 0, 15, 0);
            this.dtpDateUntil.Name = "dtpDateUntil";
            this.dtpDateUntil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)});
            this.dtpDateUntil.Size = new System.Drawing.Size(100, 20);
            this.dtpDateUntil.TabIndex = 0;
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
            // dtpTimeFrom
            // 
            this.dtpTimeFrom.AutoSize = true;
            this.dtpTimeFrom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dtpTimeFrom.EditValue = null;
            this.dtpTimeFrom.Location = new System.Drawing.Point(0, 0);
            this.dtpTimeFrom.Margin = new System.Windows.Forms.Padding(0);
            this.dtpTimeFrom.Name = "dtpTimeFrom";
            this.dtpTimeFrom.Size = new System.Drawing.Size(200, 100);
            this.dtpTimeFrom.TabIndex = 0;
            // 
            // dtpTimeUntil
            // 
            this.dtpTimeUntil.AutoSize = true;
            this.dtpTimeUntil.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dtpTimeUntil.EditValue = null;
            this.dtpTimeUntil.Location = new System.Drawing.Point(0, 0);
            this.dtpTimeUntil.Margin = new System.Windows.Forms.Padding(0);
            this.dtpTimeUntil.Name = "dtpTimeUntil";
            this.dtpTimeUntil.Size = new System.Drawing.Size(200, 100);
            this.dtpTimeUntil.TabIndex = 0;
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateUntil.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private DevExpress.XtraEditors.DateEdit dtpDateFrom;
        private DevExpress.XtraEditors.DateEdit dtpDateUntil;
        private System.Windows.Forms.Label lblDateUntil;
        private TimeEdit dtpTimeFrom;
        private TimeEdit dtpTimeUntil;

    }
}
