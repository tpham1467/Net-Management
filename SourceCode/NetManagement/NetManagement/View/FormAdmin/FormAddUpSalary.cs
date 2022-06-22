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

namespace NetManagement.View.FormAdmin
{
    public partial class FormAddUpSalary : Form
    {
        public delegate void MyDel();
        public MyDel d;
        AdminBLL_Salary _AdminBLL_Salary = new AdminBLL_Salary();
        string id;
        public FormAddUpSalary(string m)
        {
            id = m;
            InitializeComponent();
            GUI();
        }
        string str;
        void GUI()
        {
            if (id != "")
            {
                int i = Convert.ToInt32(id);
                SalaryEmployee s = _AdminBLL_Salary.GetSalaryById(i);
                txtSalary.Text = s.CoSalary.ToString();
                str = s.ID_SalaryEmployee.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SalaryEmployee sal = _AdminBLL_Salary.CreateSal();
            sal.CoSalary = Convert.ToInt32(txtSalary.Text);
            _AdminBLL_Salary.UpdateAdd(str, sal);
            d();
            this.Dispose();
        }
    }
}
