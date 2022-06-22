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

namespace NetManagement.View.FormAdmin
{
    public partial class FormAddUpEm : Form
    {
        public delegate void MyDel();
        public MyDel d;
        AdminBLL_Em adBLLEm = new AdminBLL_Em();
        AdminBLL_Salary adBLLsa = new AdminBLL_Salary();
        string id;
        public FormAddUpEm(string m)
        {
            id = m;
            InitializeComponent();
            GUI();
            CreateCBB();
        }
        string str;
        DateTime dt;
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

            if (id != "")
            {
                int i = Convert.ToInt32(id);
                Employee s = adBLLEm.GetEmById(i);
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
                str = s.ID_User.ToString();
                dt = s.Day_Create;
            }
            //foreach (var i in adBLLsa.GetAll())
            //{
            //    var se = new ConvertSalarytoVND
            //    {
            //        id = i.ID_SalaryEmployee,
            //        Money = i.Salary
            //    };
            //    cbbSalary.Items.Add(se);
            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool checkgd;
            if (rdMale.Checked) checkgd = true;
            else checkgd = false;
            Employee emp = adBLLEm.CreateEm();
            //emp.ID_SalaryEmployee = (cbbSalary.SelectedItem as ConvertSalarytoVND).id;

            int ktra = 0;
            foreach (ConvertSalarytoVND cnv in ConvertMoneys)
            {
                if (cnv.ToString() == cbbSalary.Text)
                {
                    ktra++;
                    //cus.ID_Employee = scbb.id;
                    emp.ID_SalaryEmployee = cnv.id;
                    break;
                }

            }
            if (ktra == 0)
            {
                emp.ID_SalaryEmployee = (cbbSalary.SelectedItem as ConvertSalarytoVND).id;
            }

            emp.FirstName = txtFirstN.Text;
            emp.LastName = txtLastN.Text;
            emp.Phone = txtPhone.Text;
            emp.Email = txtEmail.Text;
            emp.DateOfBirth = dtpDOB.Value;
            emp.Identify = txtIndentify.Text;
            emp.Gender = checkgd;
            adBLLEm.UpdateAdd(str, emp, dt);
            d();
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
