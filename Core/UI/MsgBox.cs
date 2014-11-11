using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft;

namespace Core.UI
{
    public partial class MsgBox : Form
    {
        /// <summary>
        /// Create MessageBox form
        /// </summary>
        public MsgBox(MessageBoxButtons ButtonType, String messageText, Boolean topMost)
        {
            InitializeComponent();
            this.TopMost = topMost;
            switch (ButtonType)
            {
                case MessageBoxButtons.OK:
                    addButton(DialogResult.OK);
                    break;
                case MessageBoxButtons.OKCancel:
                    addButton(DialogResult.Cancel);
                    addButton(DialogResult.OK);
                    break;
                case MessageBoxButtons.YesNo:
                    addButton(DialogResult.No);
                    addButton(DialogResult.Yes);
                    break;
                case MessageBoxButtons.YesNoCancel:
                    addButton(DialogResult.Cancel);
                    addButton(DialogResult.No);
                    addButton(DialogResult.Yes);
                    break;
                default:
                    addButton(DialogResult.Cancel);
                    break;
            }
            lblMessage.Text = messageText;
        }

    #region Private sub 
        private void addButton(DialogResult Button)        
        {
            Button btn = new System.Windows.Forms.Button();
             btn.AutoSize = true;
             btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btn.Location = new System.Drawing.Point(3, 3);
            btn.MinimumSize = new System.Drawing.Size(75, 23);
            btn.Name = "btn" + Button.ToString();
            btn.Size = new System.Drawing.Size(75, 23);
            btn.TabIndex = 1;
            btn.DialogResult = Button;
            btn.Text = ErrMsg.GetText("Button", Button.ToString());
            btn.UseVisualStyleBackColor = true;
            this.panBottom.Controls.Add(btn);
        }		 
    #endregion

    #region Public
        /// <summary>
        /// Display MessageBox
        /// </summary>
        /// <param name="messageCode">Message code</param>
        /// <param name="ButtonType">Buttons which need show</param>
        /// <param name="Caption">MessageBox caption</param>
        /// <param name="topMost">Display on top</param>
        /// <returns>Dialog result</returns>
        public static DialogResult Show(Enum messageCode, MessageBoxButtons ButtonType, String Caption, Boolean topMost)
        {
            Form frm = new MsgBox(ButtonType, ErrMsg.GetText(messageCode), topMost);
            frm.Text = Caption;
            return frm.ShowDialog();
        }
        /// <summary>
        /// Display MessageBox
        /// </summary>
        /// <param name="messageCode">Message code</param>
        /// <param name="ButtonType">Buttons which need show</param>
        /// <param name="Caption">MessageBox caption</param>
        /// <returns>Dialog result</returns>
        public static DialogResult Show(Enum messageCode, MessageBoxButtons ButtonType, String Caption)
        {
            Form frm = new MsgBox(ButtonType, ErrMsg.GetText(messageCode), false);
            frm.Text = Caption;
            return frm.ShowDialog();
        }
        /// <summary>
        /// Display MessageBox
        /// </summary>
        /// <param name="messageCode">Message code</param>
        /// <param name="ButtonType">Buttons which need show</param>
        /// <returns>Dialog result</returns>
        public static DialogResult Show(Enum messageCode, MessageBoxButtons ButtonType)
        {
            Form frm = new MsgBox(ButtonType, ErrMsg.GetText(messageCode), false);
            frm.Text = ErrMsg.GetText("Caption", (String)"Default");
            return frm.ShowDialog();
        }
        /// <summary>
        /// Display MessageBox
        /// </summary>
        /// <param name="messageCode">Message code</param>
        /// <param name="Caption">MessageBox caption</param>
        /// <returns>Dialog result</returns>
        public static DialogResult Show(Enum messageCode, String Caption)
        {
            Form frm = new MsgBox(MessageBoxButtons.OK, ErrMsg.GetText(messageCode), false);
            frm.Text = Caption;
            return frm.ShowDialog();
        }
        /// <summary>
        /// Display MessageBox
        /// </summary>
        /// <param name="messageCode">Message code</param>
        /// <returns>Dialog result</returns>
        public static DialogResult Show(Enum messageCode)
        {
            Form frm = new MsgBox(MessageBoxButtons.OK, ErrMsg.GetText(messageCode), false);
            frm.Text = ErrMsg.GetText("Caption", (String)"Default");
            return frm.ShowDialog();
        }

        /// <summary>
        /// Display MessageBox
        /// </summary>
        /// <param name="messageText">Message text</param>
        /// <param name="ButtonType">Buttons which need show</param>
        /// <param name="Caption">MessageBox caption</param>
        /// <param name="topMost">Display on top</param>
        /// <returns>Dialog result</returns>
        public static DialogResult Show(String messageText, MessageBoxButtons ButtonType, String Caption, Boolean topMost)
        {
            Form frm = new MsgBox(ButtonType, messageText, topMost);
            frm.Text = Caption;
            return frm.ShowDialog();
        }
        /// <summary>
        /// Display MessageBox
        /// </summary>
        /// <param name="messageText">Message text</param>
        /// <param name="ButtonType">Buttons which need show</param>
        /// <param name="Caption">MessageBox caption</param>
        /// <returns>Dialog result</returns>
        public static DialogResult Show(String messageText, MessageBoxButtons ButtonType, String Caption)
        {
            Form frm = new MsgBox(ButtonType, messageText, false);
            frm.Text = Caption;
            return frm.ShowDialog();
        }
        /// <summary>
        /// Display MessageBox
        /// </summary>
        /// <param name="messageText">Message text</param>
        /// <param name="ButtonType">Buttons which need show</param>
        /// <returns>Dialog result</returns>
        public static DialogResult Show(String messageText, MessageBoxButtons ButtonType)
        {
            Form frm = new MsgBox(ButtonType, messageText, false);
            frm.Text = ErrMsg.GetText("Caption", (String)"Default");
            return frm.ShowDialog();
        }
        /// <summary>
        /// Display MessageBox
        /// </summary>
        /// <param name="messageText">Message text</param>
        /// <param name="Caption">MessageBox caption</param>
        /// <returns>Dialog result</returns>
        public static DialogResult Show(String messageText, String Caption)
        {
            Form frm = new MsgBox(MessageBoxButtons.OK, messageText, false);
            frm.Text = Caption;
            return frm.ShowDialog();
        }
        /// <summary>
        /// Display MessageBox
        /// </summary>
        /// <param name="messageText">Message text</param>
        /// <returns>Dialog result</returns>
        public static DialogResult Show(String messageText)
        {
            Form frm = new MsgBox(MessageBoxButtons.OK, messageText, false);
            frm.Text = ErrMsg.GetText("Caption", (String)"Default");
            return frm.ShowDialog();

        }



        /// <summary>
        /// Default message for delete
        /// </summary>
        /// <returns>Dialog result</returns>
        public static DialogResult DeleteMessage()
        {
            Form frm = new MsgBox(MessageBoxButtons.YesNo, ErrMsg.GetText(Msg.DeleteConfirmation), false);
            frm.Text = ErrMsg.GetText("Caption", (String)"Default");
            return frm.ShowDialog();
        }
        /// <summary>
        /// Default message for save
        /// </summary>
        /// <returns>Dialog result</returns>
        public static DialogResult SaveMessage()
        {
            Form frm = new MsgBox(MessageBoxButtons.YesNoCancel, ErrMsg.GetText(Msg.Save), false);
            frm.Text = ErrMsg.GetText("Caption", (String)"Default");
            return frm.ShowDialog();
        }
        /// <summary>
        /// Default message for eror on save
        /// </summary>
        /// <returns>Dialog result</returns>
        public static DialogResult HasErrorMessage()
        {
            Form frm = new MsgBox(MessageBoxButtons.OK, ErrMsg.GetText(Err.HasErrors), false);
            frm.Text = ErrMsg.GetText("Caption", (String)"Default");
            return frm.ShowDialog();
        }
    #endregion
    }

}
