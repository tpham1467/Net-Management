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
            this.AutoScaleMode = AutoScaleMode.None;
            ReloadEm();
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
            cbbSearch.Enabled = true;
            cbbProperty.Enabled = true;
            btnSearch.Enabled = true;
            btnSort.Enabled = true;
            comboBoxSortBy.Enabled = true;
            cbbSearch.Items.Clear();
            cbbProperty.Items.Clear();
            if (tbMana.SelectedIndex == 0)
            {
                cbbSearch.Items.Clear();
                cbbProperty.Items.Clear();
                cbbSearch.Items.Add("All");
                cbbSearch.Items.Add("Name Employee");
                cbbSearch.Items.Add("ID_User");
                cbbProperty.Items.Add("Name Employee");
                cbbProperty.Items.Add("Day Create");
            }
            else if (tbMana.SelectedIndex == 1)
            {
                cbbSearch.Items.Add("All");
                cbbSearch.Items.Add("Name Employee");
                cbbProperty.Items.Add("Name Employee");
                cbbProperty.Items.Add("Salary");
                cbbProperty.Items.Add("WorkHour");
            }
            else
            {
                cbbSearch.Enabled = false;
                cbbProperty.Enabled = false;
                btnSearch.Enabled = false;
                btnSort.Enabled = false;
                comboBoxSortBy.Enabled = false;
            }
        }

        #endregion

        #region Show List Data CorreLative Table
        public void ReloadEm(List<object> data = null)
        {
            if (data == null)
                dgvManaEmployee.DataSource = adEm.Filter();
            else dgvManaEmployee.DataSource = data;
        }
        public void ReloadTimeKeeping(List<object> data = null)
        {
            if (data == null)
                dgvShowTimeKeeping.DataSource = adTKeeping.Filter(new StatusShift {ID_StatusShift = 2 });
            else dgvShowTimeKeeping.DataSource = data;
        }
        public void ReloadHispayroll(List<object> data = null)
        {
            if (data == null)
                dgvShowPayroll.DataSource = adHisPayroll.Filter();
            else dgvShowPayroll.DataSource = data;
        }

        public void ReloadSalaryEmployee(List<object> data = null)
        {
            if (data == null)
                dgvCosalaryEm.DataSource = adSa.Filter();
            else dgvCosalaryEm.DataSource = data;
        }
        #endregion

        #region Search For Tab

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string txt = txtSearch.Text;
            string txtcbb = cbbSearch.Text;
            List<object> list = null;
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
                ReloadEm(list);
            }
            else
            {
                if (txtcbb == "ALL")
                {
                    list = adTKeeping.Search(txt, SearchAcoountEnum.All).ToList();
                }
                else if (txtcbb == "Name Employee")
                {
                    list = adTKeeping.Search(txt, SearchAcoountEnum.Name).ToList();
                }
                ReloadTimeKeeping(list);
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
            else
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
                dgvManaEmployee.DataSource = adTKeeping.Sort(sort, (cbbProperty.SelectedItem as string));
            }
        }


        #endregion

        #region Enabled Combox Search 
        private void cbbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSearch.Text == "All")
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
                ReloadEm();
                Setcbb();
            }
            else if (tbMana.SelectedIndex == 1)
            {
                txtSearch.Text = "";
                ReloadTimeKeeping();
                Setcbb();
            }
            else if (tbMana.SelectedIndex == 2)
            {
                txtSearch.Text = "";
                ReloadHispayroll();
                Setcbb();
            }
            else if ( tbMana.SelectedIndex == 3)
            {
                txtSearch.Text = "";
                ReloadSalaryEmployee();
                Setcbb();
            }    
        }

        #endregion

        #region PayRoll
        private void btnPayroll_Click(object sender, EventArgs e)
        {
            FormPayroll f = new FormPayroll();
            f.action = ReloadTimeKeeping;
            f.Show();
        }

        #endregion

        #region Show All Shift Payment
        private void cbPay_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPay.Checked == true)
            {
                dgvShowTimeKeeping.DataSource = adTKeeping.Filter(new StatusShift { ID_StatusShift = 4 });
            }
            else
            {
                ReloadTimeKeeping();
            }
        }
        #endregion

        #region Employee
        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            FormAddUpEm formAddUpEm = new FormAddUpEm(-1);
            formAddUpEm.action = ReloadEm;
            formAddUpEm.Show();
        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            if (dgvManaEmployee.SelectedRows.Count == 1)
            {
                int id_employee = GetSelect(GetSelectFor.Employee)[0];
                FormAddUpEm formAddUpEm = new FormAddUpEm(id_employee);
                formAddUpEm.action = ReloadEm;
                formAddUpEm.Show();
            }
        }
        #endregion

        #region Salary
        private void btnAddSala_Click(object sender, EventArgs e)
        {
            FormAddUpSalary formAddUpSalary = new FormAddUpSalary(-1);
            formAddUpSalary.action = ReloadSalaryEmployee;
            formAddUpSalary.Show();
        }

        private void btnUpdateSal_Click(object sender, EventArgs e)
        {
            if (dgvCosalaryEm.SelectedRows.Count == 1)
            {

                int id_salary = GetSelect(GetSelectFor.Salary)[0];
                FormAddUpSalary formAddUpSalary = new FormAddUpSalary(id_salary);
                formAddUpSalary.action = ReloadSalaryEmployee;
                formAddUpSalary.Show();

            }
        }
        #endregion
    }
}
