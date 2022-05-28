using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetManagement.View.FormEmployee
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgottenpass_Form f = new Forgottenpass_Form();
            f.ShowDialog();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Mainform_Employee f = new Mainform_Employee();
            f.ShowDialog();
        }
    }
}
