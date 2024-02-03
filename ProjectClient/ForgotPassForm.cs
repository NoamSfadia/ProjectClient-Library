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
    public partial class ForgotPassForm : Form
    {
        public ForgotPassForm()
        {
            InitializeComponent();
            NetHandler.InitializeForgotFormInstance(this);
        }

        private void SendMailBtn_Click(object sender, EventArgs e)
        {
            NetHandler.SendMessage("Send Code" + MailTxtBox.Text);
            SendCodeBtn.Show();
            CodeTxtBox.Show();
        }

        private void SendCodeBtn_Click(object sender, EventArgs e)
        {
            NetHandler.SendMessage("CodeForNewPass" + CodeTxtBox.Text);
            
        }
        public void ShowNewPass()
        {
            SendPassBtn.Show();
            label2.Show();
            NewPassTxtBox.Show();
        }

        private void SendPassBtn_Click(object sender, EventArgs e)
        {
            NetHandler.SendMessage("ChangePassMail" + NewPassTxtBox.Text);
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void CodeTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
