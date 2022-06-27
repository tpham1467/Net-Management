using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetManagement.Model;
using NetManagement.BLL;
using NetManagement.Helper;
namespace NetManagement.View.FormAdmin
{
    public partial class FormCusAdd_Up : Form
    {
        public delegate void MyDel(List<object> data = null);
        public MyDel d;
        AdminBLL_Cus adBLLCus = new AdminBLL_Cus();
        AdminBLL_Em adBLLEm = new AdminBLL_Em();
        public int id;
        public int Check;
        public FormCusAdd_Up(int checkUpAdd, int m)
        {
            id = m;
            Check = checkUpAdd;
            this.AutoScaleMode = AutoScaleMode.None;
            InitializeComponent();
            GUI();
 
        }
        DateTime dt;
        void GUI()
        {

            if (id != -1)
            {
                int i = System.Convert.ToInt32(id);
                Customer s = adBLLCus.GetCusById(i);
                txtFirstN.Text = s.FirstName.ToString();
                txtLastN.Text = s.LastName.ToString();
                txtPhone.Text = s.Phone.ToString();
                txtEmail.Text = s.Email.ToString();
                dtpDOB.Text = s.DateOfBirth.ToLongDateString();
                txtMoney.Text = s.Money.ToString();
                textBoxemploy.Text = s.Employee.FirstName + s.Employee.LastName;
                if (s.Gender == true) rdMale.Checked = true;
                else rdFemale.Checked = true;
                dt = s.Day_Create;
            }
        }

        private void btnSend_Click_1(object sender, EventArgs e)
        {
            bool check;
            if (rdMale.Checked) check = true;
            else check = false;
            try
            {
                Customer cus = adBLLCus.CreateCus();
                cus.FirstName = txtFirstN.Text == "" ? throw new Exception("Bạn Chưa Nhập Họ") : txtFirstN.Text;
                cus.LastName = txtLastN.Text == "" ? throw new Exception("Bạn Chưa Nhập Tên Lót và Tên") : txtLastN.Text;
                cus.Phone = txtPhone.Text == "" ? throw new Exception("Bạn Chưa Nhập Số Điện Thoại") : txtPhone.Text;
                cus.Email = txtEmail.Text == "" ? throw new Exception("Bạn Chưa Nhập Email") : txtEmail.Text;
                cus.DateOfBirth = dtpDOB.Value;
                cus.Money = System.Convert.ToInt32(txtMoney.Text == "" ? throw new Exception("Bạn Chưa Nhập Số Tiền") : txtMoney.Text);
                cus.Gender = check;
                try
                {
                    if (id != -1)
                    {

                        adBLLCus.UpDate(cus, id, dt);
                    }
                    else
                    {

                        adBLLCus.Add(cus);
                    }
                }
                catch
                {
                    throw new Exception("Opp !!! . Xin lỗi Bạn hiện hệ thống không thể hoạt động . Vui Lòng Thử Lại");
                }
            } catch(Exception mess)
            {
                DialogResult result = NetMessageBox.Show(mess.Message,
                "Important Message");
                return;
            }
            d();
            this.Dispose();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cbbEm_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cus.ID_Employee = (cbbEm.SelectedItem as SetCBB).id;
        }
    }
}
