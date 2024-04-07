using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectClient
{
    public partial class SignUpForm : Form
    {
        public string UserDetails;
        public bool isUsernameValid;
        public SignUpForm()
        {
            InitializeComponent();
            NetHandler.InitializeSignUpFormInstance(this);
            
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            if (PassTxtBox.Text.Equals(ConfirmPassword.Text))
            {
                UserDetails = UserTxtBox.Text + "#" + PassTxtBox.Text + "#" + MailTxtBox.Text;
                NetHandler.SendMessage("CheckUserSignUp:" + UserTxtBox.Text);
            }
            else
            {
                Task.Run(() => MessageBox.Show("Password and Confirm Password must be the same."));
            }
        }

        private void SendCodeBtn_Click(object sender, EventArgs e)
        {
            if(CodeTxtBox.Text != null)
            {
                NetHandler.SendMessage("CodeUp"+CodeTxtBox.Text);
            }
                
            
        }
        public void ShowCode()
        {
            label4.Show();
            SendCodeBtn.Show();
            CodeTxtBox.Show();
        }
        public void ShowCaptcha(string CaptchaTest)
        {
            CaptchaTxtBox.Show();
            CapthcaQstLbl.Show();
            CapthcaQstLbl.Text = CaptchaTest;
            CaptchaLbl.Show();
            SendCaptchaBtn.Show();
        }
        /// <summary>
        /// returns all the user details.
        /// </summary>
        /// <returns></returns>
        public string getUserDetails()
        {
            return UserDetails;
        }


        private void SendCaptchaBtn_Click(object sender, EventArgs e)
        {
            if(CaptchaTxtBox.Text != null)
            {
                NetHandler.SendMessage("CaptchaUp:" + CaptchaTxtBox.Text);
            }
        }

        private void CheckBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            PassTxtBox.PasswordChar = CheckBoxShowPassword.Checked ? '\0' : '•';
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }
    }
}
