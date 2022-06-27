using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetManagement.BLL.BLLEmployee.BLLAccoutManagement;
using NetManagement.Helper;
using NetManagement.Model;
namespace NetManagement.View.FormEmployee
{
    public partial class FormAddUpdateAcc : Form
    {
        private BLLAccoutManagement _BLLAccoutManagement = new BLLAccoutManagement();
        private int id_employee;
        private int id_User;
        public Action<List<object>> action;
        public FormAddUpdateAcc(int Id_Emloyeee , int id_Acc)
        {
            id_employee = Id_Emloyeee;
            id_User = id_Acc;

            InitializeComponent();
            LoadInfo();
        }
        private void LoadInfo()
        {
            if (id_User == -1)
            {
                textBoxPassWord.Visible = false;
                label6.Visible = false;
            }
            else
            {
                Account account = _BLLAccoutManagement.GetById(id_User);
                txtEmail.Text = account.User.Email ;
                txtFirstN.Text = account.User.FirstName;
                txtLastN.Text = account.User.LastName;
                txtPhone.Text = account.User.Phone;
                txtUserName.Text = account.UserName_Acc;
                textBoxPassWord.Text = account.Password_Acc;
                dtpDateofBirth.Value = account.User.DateOfBirth;
                rdMale.Checked = account.User.Gender == true?true:false;

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                Customer customer = new Customer
                {
                    FirstName = txtFirstN.Text == "" ? throw new Exception("Bạn Chưa Nhập Họ") : txtFirstN.Text,
                    LastName = txtLastN.Text == "" ? throw new Exception("Bạn Chưa Nhập Tên") : txtLastN.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    DateOfBirth = dtpDateofBirth.Value,
                    Gender = rdFemale.Checked == true ? false : true,
                };
                if (id_User == -1)
                {
                    _BLLAccoutManagement.AddAccount(customer, txtUserName.Text, id_employee);
                }
                else
                {
                    _BLLAccoutManagement.UpdateAccount(customer, txtUserName.Text, textBoxPassWord.Text, id_User);
                }
            }
            catch (Exception mess)
            {
                DialogResult result = NetMessageBox.Show(mess.Message,
               "Important Message");
                return;
            }
            action(null);
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
