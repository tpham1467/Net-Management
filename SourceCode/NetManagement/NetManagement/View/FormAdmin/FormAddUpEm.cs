using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetManagement.BLL;
using NetManagement.Model;
using NetManagement.DTO;
using NetManagement.Helper;
namespace NetManagement.View.FormAdmin
{
    public partial class FormAddUpEm : Form
    {
        public Action<List<object>> action;
        AdminBLL_Em adBLLEm = new AdminBLL_Em();
        AdminBLL_Salary adBLLsa = new AdminBLL_Salary();
        private int id;
        private int id_salary;
        public FormAddUpEm(int _id)
        {
            id = _id;
            if(id != -1)
            {
                Employee s = adBLLEm.GetEmById(id);
                id_salary = s.ID_SalaryEmployee;
            }
            this.AutoScaleMode = AutoScaleMode.None;
            InitializeComponent();
            GUI();
            CreateCBB();
        }
        List<ConvertSalarytoVND> ConvertMoneys = new List<ConvertSalarytoVND>();
        public void CreateCBB()
        {
            foreach (SalaryEmployee i in adBLLsa.GetAll())
            {
                cbbSalary.Items.Add(new ConvertSalarytoVND { id = i.ID_SalaryEmployee, Money = i.CoSalary });
                ConvertMoneys.Add(new ConvertSalarytoVND { id = i.ID_SalaryEmployee, Money = i.CoSalary });
            }
        }
        void GUI()
        {

            if (id != -1)
            {
                Employee s = adBLLEm.GetEmById(id);
                txtFirstN.Text = s.FirstName.ToString();
                txtLastN.Text = s.LastName.ToString();
                txtPhone.Text = s.Phone.ToString();
                txtEmail.Text = s.Email.ToString();
                txtIndentify.Text = s.Identify.ToString();

                var se = new ConvertSalarytoVND
                {
                    id = s.SalaryEmployee.ID_SalaryEmployee,
                    Money = s.SalaryEmployee.CoSalary
                };
                cbbSalary.Text = se.ToString();
                dtpDOB.Text = s.DateOfBirth.ToLongDateString();
                if (s.Gender == true) rdMale.Checked = true;
                else rdFemale.Checked = true;
                Account account = s.Accounts.ElementAt(0);
                textBoxUserName.Text = account.UserName_Acc;
                textBoxPassword.Text = account.Password_Acc;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool checkgd;
            if (rdMale.Checked) checkgd = true;
            else checkgd = false;
            Employee emp = adBLLEm.CreateEm();
            try
            {
                ConvertSalarytoVND convertSalarytoVND = cbbSalary.SelectedItem as ConvertSalarytoVND;
                if (convertSalarytoVND == null)
                {
                    if (id == -1)
                    {
                        throw new Exception("Bạn Chưa Chọn Lương Cho Nhân Viên");
                    }
                    emp.ID_SalaryEmployee = id_salary;

                }
                else
                    emp.ID_SalaryEmployee = convertSalarytoVND.id;
                emp.FirstName = txtFirstN.Text == "" ? throw new Exception("Bạn Chưa Nhập Họ") : txtFirstN.Text;
                emp.LastName = txtLastN.Text == "" ? throw new Exception("Bạn Chưa Nhập Tên lót và Tên") : txtLastN.Text;
                emp.Phone = txtPhone.Text == "" ? throw new Exception("Bạn Chưa Nhập Số Điện Thoại") : txtPhone.Text;
                emp.Email = txtEmail.Text == "" ? throw new Exception("Bạn Chưa Nhập Email") : txtEmail.Text;
                emp.DateOfBirth = dtpDOB.Value;
                emp.Identify = txtIndentify.Text == "" ? throw new Exception("Bạn Chưa Nhập Số Chứng Minh") : txtIndentify.Text;
                emp.Gender = checkgd;
                Account account = adBLLEm.CreateAcoount();
                account.UserName_Acc = textBoxUserName.Text == "" ? throw new Exception("Bạn Chưa Nhập Tên Đăng Nhập") : textBoxUserName.Text;
                account.Password_Acc = textBoxPassword.Text == "" ? throw new Exception("Bạn Chưa Nhập Mật Khẩu") : textBoxPassword.Text;
                try
                {
                    if (id == -1)
                    {


                        adBLLEm.Add(account, emp);
                    }
                    else
                        adBLLEm.UpDate(emp, id, account);
                }
                catch
                {
                    //throw new Exception("Opp !!! . Xin lỗi Bạn hiện hệ thống không thể hoạt động . Vui Lòng Thử Lại");
                    throw;
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
