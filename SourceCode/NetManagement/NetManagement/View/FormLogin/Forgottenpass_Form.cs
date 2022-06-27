using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetManagement.BLL.BLLLogin;
using NetManagement.Model;
using NetManagement.DTO;
namespace NetManagement.View.Login
{
    public partial class Forgottenpass_Form : Form
    {
        private BLLLogin bLLLogin = new BLLLogin();
        public Forgottenpass_Form()
        {

            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text == "" || txtNewPassword.Text == "" || txtPhoneNb.Text == "")
            {
                MessageBox.Show("Chua nhap du");
            }
            else
            {
                ForgetPassword forgetPassword = new ForgetPassword();
                forgetPassword.email = txtEmail.Text; forgetPassword.phone = txtPhoneNb.Text;
                forgetPassword.NewPassword = txtNewPassword.Text;
                bool status =  bLLLogin.ForgetPassword(forgetPassword);
                if(status == true)
                {
                    MessageBox.Show("Thanh Cong");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai hoax passrowd qua ngan");
                }
            }
        }
    }
}
