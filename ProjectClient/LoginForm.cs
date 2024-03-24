using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace ProjectClient
{
    public partial class LoginForm : Form
    {
        SignUpForm signUpForm;

        public LoginForm()
        {
            InitializeComponent();
            NetHandler.Connect("127.0.0.1");
            NetHandler.InitializeLoginFormInstance(this);
            PassBox.MaxLength = 10;
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            NetHandler.SendMessage("In" + UsernameTextBox.Text + "#" + PassBox.Text);
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }

        private void ForgotBtn_Click(object sender, EventArgs e)
        {
            ForgotPassForm forgotPassForm = new ForgotPassForm();
            forgotPassForm.Show();
            this.Hide();

        }
        /// <summary>
        /// Creates a new Home Screen form.
        /// </summary>
        public void CreateAndShowHomeForm()
        {
            HomeScreenForm homeScreen = new HomeScreenForm();
            homeScreen.Show();
            this.Hide();
            if(signUpForm != null)
            {
                signUpForm.Hide();
            }
        }
        public void ShowMail()
        {
            SendMailButton.Visible = true;
            SmtpTextBox.Visible = true;
        }
        public void ShowCaptcha(string CaptchaTest)
        {
            CaptchaLabel.Show();
            CaptchaTextBox.Show();
            CaptchaLabel.Text = CaptchaTest;
            SendCaptchaButton.Show();
        }
        /// <summary>
        /// Disables all the controls.
        /// </summary>
        public void DisableAll()
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = false;
            }
            MessageBox.Show("You tried too many times..");
        }
        /// <summary>
        /// Enables all the controls.
        /// </summary>
        public void EnableAll()
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congarts! You Found Easter egg#1!");
        }

        private void UsernameTextBox_MouseEnter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text == "Enter username:")
            {
                textBox.Clear();
                textBox.ForeColor = Color.Black;
                textBox.ReadOnly = false;
            }
        }

        private void UsernameTextBox_MouseLeave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Enter username:";
                textBox.ForeColor = Color.Gray;
                textBox.ReadOnly = true;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            UsernameTextBox.ReadOnly = true;
            
        }

        private void UsernameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            UsernameTextBox.ReadOnly = false;
        }

        private void SendMailButton_Click(object sender, EventArgs e)
        {
            NetHandler.SendMessage("CodeIn" + SmtpTextBox.Text);
        }

        private void SmtpTextBox_MouseEnter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text == "Enter mail:")
            {
                textBox.Clear();
                textBox.ForeColor = Color.Black;
                textBox.ReadOnly = false;
            }
        }

        private void SmtpTextBox_MouseLeave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Enter mail:";
                textBox.ForeColor = Color.Gray;
                textBox.ReadOnly = true;    
            }
        }

        private void SendCaptchaButton_Click(object sender, EventArgs e)
        {
            NetHandler.SendMessage("CaptchaIn:" + CaptchaTextBox.Text);
        }
    }
}
