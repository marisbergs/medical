namespace WindowsApplication1
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtRes = new DevExpress.XtraEditors.TextEdit();
            this.txtMask = new DevExpress.XtraEditors.TextEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtRes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMask.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRes
            // 
            this.txtRes.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "Val", true));
            this.txtRes.Location = new System.Drawing.Point(87, 56);
            this.txtRes.Name = "txtRes";
            this.txtRes.Properties.Mask.EditMask = "#,##0.00;";
            this.txtRes.Properties.Mask.IgnoreMaskBlank = false;
            this.txtRes.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtRes.Properties.Mask.ShowPlaceHolders = false;
            this.txtRes.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtRes.Size = new System.Drawing.Size(178, 20);
            this.txtRes.TabIndex = 0;
            // 
            // txtMask
            // 
            this.txtMask.Location = new System.Drawing.Point(87, 94);
            this.txtMask.Name = "txtMask";
            this.txtMask.Size = new System.Drawing.Size(178, 20);
            this.txtMask.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(WindowsApplication1.test);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 334);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMask);
            this.Controls.Add(this.txtRes);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.txtRes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMask.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtRes;
        private DevExpress.XtraEditors.TextEdit txtMask;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
    }
}

