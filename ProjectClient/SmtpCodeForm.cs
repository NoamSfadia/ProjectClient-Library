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
    public partial class SmtpCodeForm : Form
    {
        public SmtpCodeForm()
        {
            InitializeComponent();
        }

        private void SendCodeButton_Click(object sender, EventArgs e)
        {
            NetHandler.SendMessage("CodeForEdit:" + textBox1.Text);
        }
    }
}
