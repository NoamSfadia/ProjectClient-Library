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
            NetHandler.SendMessage("In" + NickBox.Text + "#" + PassBox.Text);
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

        }
    }
}
