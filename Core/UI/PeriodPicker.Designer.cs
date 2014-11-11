namespace Core.UI
{
	partial class PeriodPicker
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
            this.dtpFrom = new DevExpress.XtraEditors.DateEdit();
            this.dtpUntil = new DevExpress.XtraEditors.DateEdit();
            this.lblDateUntil = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpUntil.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFrom
            // 
            this.dtpFrom.EditValue = null;
            this.dtpFrom.Location = new System.Drawing.Point(0, 0);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)});
            this.dtpFrom.Size = new System.Drawing.Size(80, 20);
            this.dtpFrom.TabIndex = 0;
            // 
            // dtpUntil
            // 
            this.dtpUntil.EditValue = null;
            this.dtpUntil.Location = new System.Drawing.Point(0, 0);
            this.dtpUntil.Margin = new System.Windows.Forms.Padding(3, 0, 15, 0);
            this.dtpUntil.Name = "dtpUntil";
            this.dtpUntil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)});
            this.dtpUntil.Size = new System.Drawing.Size(80, 20);
            this.dtpUntil.TabIndex = 0;
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
            // PeriodPicker
            // 
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Size = new System.Drawing.Size(311, 26);
            ((System.ComponentModel.ISupportInitialize)(this.dtpFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpUntil.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private DevExpress.XtraEditors.DateEdit dtpFrom;
        private DevExpress.XtraEditors.DateEdit dtpUntil;
        private System.Windows.Forms.Label lblDateUntil;

    }
}
