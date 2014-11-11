namespace Core.UI
{
    partial class MsgBox
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panBottom = new System.Windows.Forms.FlowLayoutPanel();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMessage.Location = new System.Drawing.Point(0, 0);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(0);
            this.lblMessage.MaximumSize = new System.Drawing.Size(700, 500);
            this.lblMessage.MinimumSize = new System.Drawing.Size(290, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Padding = new System.Windows.Forms.Padding(20, 20, 20, 15);
            this.lblMessage.Size = new System.Drawing.Size(290, 48);
            this.lblMessage.TabIndex = 7;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.AutoSize = true;
            this.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TableLayoutPanel1.ColumnCount = 1;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel1.Controls.Add(this.panBottom, 0, 0);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 16);
            this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel1.Size = new System.Drawing.Size(292, 0);
            this.TableLayoutPanel1.TabIndex = 8;
            // 
            // panBottom
            // 
            this.panBottom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panBottom.AutoSize = true;
            this.panBottom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panBottom.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panBottom.Location = new System.Drawing.Point(146, 0);
            this.panBottom.Margin = new System.Windows.Forms.Padding(0);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(0, 0);
            this.panBottom.TabIndex = 0;
            // 
            // MsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(292, 16);
            this.ControlBox = false;
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.TableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(750, 560);
            this.MinimumSize = new System.Drawing.Size(300, 34);
            this.Name = "MsgBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paziņojums";
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblMessage;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.FlowLayoutPanel panBottom;

    }
}