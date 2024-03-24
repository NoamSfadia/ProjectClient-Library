﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Net.Mime.MediaTypeNames;

namespace ProjectClient
{
    public partial class SettingsForm : Form
    {
        private string username;
        public bool isUsernameValid = false;
        private string ImageToSend;
        private List<string> Genres;
        public SettingsForm(string Username)
        {
            InitializeComponent();
            NetHandler.InitializeSettingsFormInstance(this);
            username = Username;
        }
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            NetHandler.SendMessage("What Type"); 
            
        }
        public void ManagerPanelVisible()
        {
            UploadBookPhotoPictureBox.Visible = true;
            BookNameTextBox.Visible = true;
            BookAuthorTextBox.Visible = true;
            GenreComboBox.Visible = true;
            UploadBookButton.Visible = true;
            BookSummaryTextBox.Visible = true;
        }

        public void UnlockSettings()
        {
            foreach(Control control in AccountSettingsPanel.Controls)
            {
                control.Enabled = true;
            }
            AccessSettingsLabel.Visible = false;
            SendSmtpCodeSettings.Visible = false;
            SmtpTextBox.Visible = false;
            InsertSmtpCode.Visible = false;
            Task.Run(() => { MessageBox.Show("Settings Unlocked!"); });
        }


        private void SendNewUserButton_Click(object sender, EventArgs e)
        {
            NetHandler.SendMessage("CheckUser:" + ChangeUserTxtBox.Text);
            if (isUsernameValid)
            {
                NetHandler.SendMessage("NewUsername:" + ChangeUserTxtBox.Text);
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
            try
            {
                NetHandler.SendMessage("BookInsert:" + BookNameTextBox.Text + "@" + BookAuthorTextBox.Text + "@" + GenreComboBox.Text + "@" + BookSummaryTextBox.Text + "@" + ImageToSend);
                BookNameTextBox.Text = BookAuthorTextBox.Text = BookSummaryTextBox.Text = "";
                GenreComboBox.Text = "";
                string UploadPhotoPath = @"C:\Users\User\source\repos\ProjectClient-Library\ProjectClient\Resources\Screenshot 2024-02-29 000018.png";
                UploadBookPhotoPictureBox.Image = System.Drawing.Image.FromFile(UploadPhotoPath);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        public void insertGenres(string GenresUnspilted)
        {
            string[] strings = GenresUnspilted.Split(',');
            Genres = new List<string>(strings);
            foreach (string str in Genres)
            {
                GenreComboBox.Items.Add(str);
            }
        }

        private void UploadBookPhotoPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog BookPhotoDialog = new OpenFileDialog();
            BookPhotoDialog.Filter = "Image Files|*.jpeg";

            if(BookPhotoDialog.ShowDialog() == DialogResult.OK)
            {
               string ImagePath = BookPhotoDialog.FileName;
               UploadBookPhotoPictureBox.LoadAsync(ImagePath);

                try
                {
                    // Read the image file as an array of bytes
                    byte[] ImageData = File.ReadAllBytes(ImagePath);

                    // Convert the byte array to a Base64 string
                    ImageToSend = Convert.ToBase64String(ImageData);

                }
                catch (FileNotFoundException)
                {
                    Task.Run(() => { MessageBox.Show("File not found: " + ImagePath); });
                }
                catch (Exception ex)
                {
                    Task.Run(() => { MessageBox.Show("An error occurred: " + ex.Message); });
                }

            }
        }

        private void BookNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AccessSettingsLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NetHandler.SendMessage("SendCodeSettings" + username);
            SmtpTextBox.Visible = true;
            SendSmtpCodeSettings.Visible = true;
            InsertSmtpCode.Visible = true;
        }

        private void SendSmtpCodeSettings_Click(object sender, EventArgs e)
        {
            NetHandler.SendMessage("CodeForSettings" + SmtpTextBox.Text);
        }
    }
}
