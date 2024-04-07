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
    public partial class SmtpCode : UserControl
    {
        public event EventHandler OnMailButtonClick;
        public event EventHandler OnSendButtonClick;
        public SmtpCode()
        {
            InitializeComponent();
        }

        //those functions allows usage of the buttons in the form.cs, by linking the events of the UserControl and the the form itself.
        private void SendCodeButton_Click(object sender, EventArgs e)
        {
            OnSendButtonClick?.Invoke(this, EventArgs.Empty);
        }
        public string GetCodeTextBoxText()
        {
            return CodeTextBox.Text;
        }
    }
}
