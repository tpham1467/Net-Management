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
using NetManagement.Helper;
namespace NetManagement.View.FormAdmin
{
    public partial class FormAddUpSalary : Form
    {
        public Action<List<Object>> action;
        AdminBLL_Salary _AdminBLL_Salary = new AdminBLL_Salary();
        private  int  id;
        public FormAddUpSalary(int _id)
        {
            this.AutoScaleMode = AutoScaleMode.None;
            id = _id;
            InitializeComponent();
            GUI();
        }
        void GUI()
        {
            if (id != -1)
            {
                int i = System.Convert.ToInt32(id);
                SalaryEmployee s = _AdminBLL_Salary.GetSalaryById(i);
                txtSalary.Text = s.CoSalary.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SalaryEmployee sal = _AdminBLL_Salary.CreateSal();
                sal.CoSalary = System.Convert.ToInt32(txtSalary.Text == "" ? throw new Exception("Bạn Chưa Nhập Số Tiền") : txtSalary.Text);
                try
                {
                    if (id == -1) _AdminBLL_Salary.Add(sal);
                    else
                        _AdminBLL_Salary.UpDate(sal, id);
                }
                catch
                {
                    throw;
                    //throw new Exception("Opp !!! . Xin lỗi Bạn hiện hệ thống không thể hoạt động . Vui Lòng Thử Lại");
                }
            }
            catch( Exception mess)
            {
                DialogResult result = NetMessageBox.Show(mess.Message,
                               "Important Message");
                return;
            }
            action(null);
            this.Dispose();
        }
    }
}
