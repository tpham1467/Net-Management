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
    public partial class FormEmployees : Form
    {
        #region

        AdminBLL_Timekeeping adTKeeping = new AdminBLL_Timekeeping();
        AdminBLL_Em adEm = new AdminBLL_Em();
        AdminBLL_HisPayroll adHisPayroll = new AdminBLL_HisPayroll();
        AdminBLL_Salary adSa = new AdminBLL_Salary();

        private enum GetSelectFor
        {
            Employee  = 0 ,
            TimeKeeping  =1,
            PayRoll = 2 ,
            Salary  = 3 ,
        }
        #endregion

        public FormEmployees()
        {
            InitializeComponent();
            ShowAll_Empl();
            Setcbb();
        }

        #region GetSelect
        private List<int> GetSelect(GetSelectFor getSelectFor)
        {
            List<int> data = new List<int>();
            if (getSelectFor == GetSelectFor.Salary)
            {
                if (dgvCosalaryEm.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow i in dgvCosalaryEm.SelectedRows)
                    {
                        string s = i.Cells["ID_SalaryEmployee"].Value.ToString();
                        data.Add(Convert.ToInt32(s));

                    }
                }
            }
            else if (getSelectFor == GetSelectFor.Employee)
            {
                if (dgvManaEmployee.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow i in dgvManaEmployee.SelectedRows)
                    {
                        string s = i.Cells["ID_User"].Value.ToString();
                        data.Add(Convert.ToInt32(s));

                    }
                }
            }
            return data;
        }

        #endregion

        #region Set Commobox For Tab
        public void Setcbb()
        {
            //if (tbMana.Selected)
            if (tbMana.SelectedIndex == 1)
            {
                cbbSearch.Items.Clear();
                cbbProperty.Items.Clear();
                cbbSearch.Items.Add("All");
                cbbSearch.Items.Add("Name Employee");
                List<DateTime> str = adTKeeping
                    .GetAll()
                    .Select(p => p.WorkedDate)
                    .Distinct()
                    .ToList();
                foreach (DateTime i in str)
                {
                    cbbSearch.Items.Add(i.ToString("M/dd/yyyy"));
                }
                cbbProperty.Items.Add("Worked Hour");
                cbbProperty.Items.Add("Worked Date");
            }
            else if (tbMana.SelectedIndex == 2)
            {
                cbbSearch.Items.Clear();
                cbbProperty.Items.Clear();
                cbbSearch.Items.Add("All");
                cbbSearch.Items.Add("Name Employee");
                cbbProperty.Items.Add("Salary");
                cbbProperty.Items.Add("WorkHour");
            }
        }

        #endregion

        #region Show List Data CorreLative Table
        public void ShowAll_Empl()
        {
            dgvManaEmployee.DataSource = adEm.Filter().ToList();
        }

        public void ShowAllTimekeeping()
        {
            dgvShowTimeKeeping.DataSource = adTKeeping.Filter(new StatusShift { ID_StatusShift = 2 });
        }
      
        public void ShowAllPayroll()
        {
            dgvShowPayroll.DataSource = adHisPayroll.Filter();
        }
        public void ShowAll_Salary()
        {
            var e = adSa.GetAll()
                        .Select(p => new
                                     { 
                                        p.ID_SalaryEmployee,
                                        p.CoSalary,
                                     });
            dgvCosalaryEm.DataSource = e.ToList();
        }

        #endregion

        #region Search For Tab

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string txt = txtSearch.Text;
            string txtcbb = cbbSearch.Text;
            List<object> list = new List<object>();
            if (tbMana.SelectedIndex == 0)
            {

                if (txtcbb == "All")
                {
                    list = adEm.Search(txt, SearchAcoountEnum.All);
                }
                else if (txtcbb == "Name Employee")
                {
                    list = adEm.Search(txt, SearchAcoountEnum.Name);
                }
                else list = adEm.Search(txt, SearchAcoountEnum.Id);
            }
        }

#endregion

        #region Sort For Tab Employeee and Tab Time Keeping
        private void btnSort_Click(object sender, EventArgs e)
        {
            if (tbMana.SelectedIndex == 0)
            {
                SortEnum sort = new SortEnum();
                if ((comboBoxSortBy.SelectedItem as string) == "Asc")
                {
                    sort = SortEnum.Asc;
                }
                else
                {
                    sort = SortEnum.Desc;
                }
                dgvManaEmployee.DataSource = adEm.Sort(sort, (cbbProperty.SelectedItem as string));
            }
        }


        #endregion

        #region Enabled Combox Search 
        private void cbbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSearch.Text != "Name Employee")
            {
                txtSearch.Text = "";
                txtSearch.Enabled = false;
            }
            else
            {
                txtSearch.Enabled = true;
            }
        }

        #endregion

        #region Move Tab
        private void tbEm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbMana.SelectedIndex == 0)
            {
                txtSearch.Text = "";
                ShowAll_Empl();
                Setcbb();
            }
            else if (tbMana.SelectedIndex == 1)
            {
                txtSearch.Text = "";
                ShowAllTimekeeping();
                Setcbb();
            }
            else if (tbMana.SelectedIndex == 2)
            {
                txtSearch.Text = "";
                ShowAllPayroll();
                Setcbb();
            }
            else if ( tbMana.SelectedIndex == 3)
            {
                txtSearch.Text = "";
                ShowAll_Salary();
                Setcbb();
            }    
        }

        #endregion

        #region PayRoll
        private void btnPayroll_Click(object sender, EventArgs e)
        {
            FormPayroll f = new FormPayroll();
            f.action = ShowAllTimekeeping;
            f.Show();
        }

        #endregion

        #region Show All Shift Payment
        private void cbPay_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPay.Checked == true)
            {
                dgvShowTimeKeeping.DataSource = adTKeeping.Filter(new StatusShift { ID_StatusShift = 2 });
            }
            else
            {
                //ShowAllTimekeeping();
            }
        }
        #endregion

        #region Employee
        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            FormAddUpEm formAddUpEm = new FormAddUpEm(-1);
            formAddUpEm.action = ShowAll_Empl;
            formAddUpEm.Show();
        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            if (dgvManaEmployee.SelectedRows.Count == 1)
            {
                int id_employee = GetSelect(GetSelectFor.Employee)[0];
                FormAddUpEm formAddUpEm = new FormAddUpEm(id_employee);
                formAddUpEm.action = ShowAll_Empl;
                formAddUpEm.Show();
            }
        }
        #endregion

        #region Salary
        private void btnAddSala_Click(object sender, EventArgs e)
        {
            FormAddUpSalary formAddUpSalary = new FormAddUpSalary(-1);
            formAddUpSalary.action = ShowAll_Salary;
            formAddUpSalary.Show();
        }

        private void btnUpdateSal_Click(object sender, EventArgs e)
        {
            if (dgvCosalaryEm.SelectedRows.Count == 1)
            {

                int id_salary = GetSelect(GetSelectFor.Salary)[0];
                FormAddUpSalary formAddUpSalary = new FormAddUpSalary(id_salary);
                formAddUpSalary.action = ShowAll_Salary;
                formAddUpSalary.Show();

            }
        }
        #endregion
    }
}
