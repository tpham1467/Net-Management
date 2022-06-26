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
using NetManagement.View.FormChoosePC;
using NetManagement.BLL.BLLEmployee.BLLCheckInCheckOut;
using NetManagement.View.FormAdmin;
namespace NetManagement.View.FormEmployee
{
    public partial class Login_Form : Form
    {
        private BLLLogin _BLLLogin = new BLLLogin();
        private BllCheckIncheckOut bllCheckIncheckOut = new BllCheckIncheckOut();

        public Login_Form()
        {
            
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgottenpass_Form f = new Forgottenpass_Form();
            f.Show();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == ""||txtUser.Text == "")
            {
                MessageBox.Show("Chua nhap du");
                
            }
            else
            {
                Account account = _BLLLogin.SingUp(txtUser.Text, txtPass.Text);
                if(account != null )
                {
                    if (account.IsErase == 1 || account.status == 1)
                    {
                        MessageBox.Show("Tai Khoan Khong Con Kha Dung");
                    }
                    else
                    {
                        if(account.ID_Role == 1)
                        {
                            FormAdmin();
                        }
                        else if (account.ID_Role == 2)
                        {
                            Mainform_Employee mainform_Employee = new Mainform_Employee(account.Id_User);
                            mainform_Employee.action = UnHide;
                            mainform_Employee.Show();
                            this.Hide();
                        }
                        else
                        {

                            FormChoosePc choosepc = new FormChoosePc(account.Id_User);
                            choosepc.action = UnHide;
                            choosepc.Show();
                            this.Hide();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Sai Mat khau or pasword");
                }
            }
        }
        public  void FormAdmin()
        {
            Main_Form main_Form = new Main_Form();
            main_Form.action = UnHide;
            main_Form.AutoScaleMode = AutoScaleMode.None;
            main_Form.Show();
            this.Hide();
        }
        public void UnHide()
        {
            this.Visible = true;
        }
    }
}
