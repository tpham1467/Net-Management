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
        public Action action;
        AdminBLL_Salary _AdminBLL_Salary = new AdminBLL_Salary();
        private  int  id;
        public FormAddUpSalary(int _id)
        {
            id = _id;
            InitializeComponent();
            GUI();
        }
        void GUI()
        {
            if (id != -1)
            {
                int i = Convert.ToInt32(id);
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
            SalaryEmployee sal = _AdminBLL_Salary.CreateSal();
            sal.CoSalary = Convert.ToInt32(txtSalary.Text);
            if (id == -1) _AdminBLL_Salary.Add(sal);
            else
            _AdminBLL_Salary.UpDate( sal , id);
            action();
            this.Dispose();
        }
    }
}
