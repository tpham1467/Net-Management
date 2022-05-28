using NetManagement.View.FormEmployee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetManagement.View.FormCustomer
{
    public partial class MainForm_User : Form
    {
        public MainForm_User()
        {
            InitializeComponent();
        }
        private Form currentFormBody;
        private void OpenFormBody(Form bodyForm)
        {
            if (currentFormBody != null)
            {
                currentFormBody.Close();
            }
            currentFormBody = bodyForm;
            bodyForm.TopLevel = false;
            bodyForm.FormBorderStyle = FormBorderStyle.None;
            bodyForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(bodyForm);
            panel_body.Tag = bodyForm;
            bodyForm.BringToFront();
            bodyForm.Show();
        }

        private void btnPersonalInfor_Click(object sender, EventArgs e)
        {
            OpenFormBody(new PersonalInfor_Form());
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            OpenFormBody(new Chat_Form());
        }

        private void btnLoutout_Click(object sender, EventArgs e)
        {
            Login_Form f = new Login_Form();
            f.Show();
        }
    }
}
