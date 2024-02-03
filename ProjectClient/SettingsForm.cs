using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectClient
{
    public partial class SettingsForm : Form
    {
        private string username;
        public bool isUsernameValid = false;
        public SettingsForm(string Username)
        {
            InitializeComponent();
            NetHandler.InitializeSettingsFormInstance(this);
            username = Username;
            
            smtpCodeSettings.OnMailButtonClick += SendMailButtonClick;
            smtpCodeSettings.OnSendButtonClick += SendCodeButtonClick;
        }
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            NetHandler.SendMessage("What Type"); 
        }



        private void SendMailButtonClick(object sender, EventArgs e)
        {
            NetHandler.SendMessage("Send Code" + smtpCodeSettings.GetMailTextBoxText());
        }
        private void SendCodeButtonClick(object sender, EventArgs e)
        {
            NetHandler.SendMessage("CodeForSettings" + smtpCodeSettings.GetCodeTextBoxText());
        }



        public void UnlockSettings()
        {
            foreach(Control control in AccountSettingsPanel.Controls)
            {
                control.Enabled = true;
            }
        }


        private void SendNewUserButton_Click(object sender, EventArgs e)
        {
            NetHandler.SendMessage("CheckUser:" + ChangeUserTxtBox.Text);
            if (isUsernameValid)
            {
                NetHandler.SendMessage("NewUsername:" + ChangeUserTxtBox.Text + "+" + username);
                ChangeUserTxtBox.Text = "";
            }
        }
        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            NetHandler.SendMessage("ChangePassUser" + ChangePasswordTextBox.Text);
            ChangePasswordTextBox.Text = "";
        }

        private void ChangeMailButton_Click(object sender, EventArgs e)
        {
            NetHandler.SendMessage("ChangeMail" + ChangeMailTextBox.Text);
            ChangeMailTextBox.Text = "";
        }

        private void UploadBookButton_Click(object sender, EventArgs e)
        {
           NetHandler.SendMessage("BookInsert:" + BookNameTextBox.Text + "," + BookAuthorTextBox.Text + "," + BookGenreTextBox.Text + "," + BookRatingTextBox.Text);
           BookNameTextBox.Text = BookAuthorTextBox.Text = BookGenreTextBox.Text = BookRatingTextBox.Text = "";
        }

        private void UploadBookPhotoPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog BookPhotoDialog = new OpenFileDialog();
            BookPhotoDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if(BookPhotoDialog.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void BookNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
