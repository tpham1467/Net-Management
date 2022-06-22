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
        AdminBLL_Timekeeping adTKeeping = new AdminBLL_Timekeeping();
        AdminBLL_Em adEm = new AdminBLL_Em();
        AdminBLL_HisPayroll adHisPayroll = new AdminBLL_HisPayroll();
        AdminBLL_Salary adSa = new AdminBLL_Salary();
        public FormEmployees()
        {
            InitializeComponent();
            ShowAll_Empl();
            Setcbb();
        }

        public void SetSalary()
        {
            List<Shift> list = adTKeeping
                .GetAll()
                .Where(p => p.StatusShift.Description == "Đã chấm công")
                .ToList();

            foreach (HistoryPayroll i in adHisPayroll.GetAll())
            {
                foreach (Shift s in list)
                {
                    if (i.ID_User == s.Employee.ID_User)
                    {
                        i.Salary = s.WorkedHour * i.Employee.SalaryEmployee.CoSalary;
                    }
                }
            }
            adEm.SaveChange();
            adHisPayroll.SaveChange();
        }

        public void Setcbb()
        {
            //if (tbMana.Selected)
            if (tbMana.SelectedIndex == 1)
            {
                cbbSearch.Items.Clear();
                cbbSort.Items.Clear();
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
                cbbSort.Items.Add("Worked Hour");
                cbbSort.Items.Add("Worked Date");
            }
            else if (tbMana.SelectedIndex == 2)
            {
                cbbSearch.Items.Clear();
                cbbSort.Items.Clear();
                cbbSearch.Items.Add("All");
                cbbSearch.Items.Add("Name Employee");
                cbbSort.Items.Add("Salary");
                cbbSort.Items.Add("WorkHour");
            }
        }
        public void ShowAll_Empl()
        {
            var e = adEm.GetAll().Select(p => new
                        {
                            p.ID_User,
                         //   p.FullNameEm,
                            p.DateOfBirth,
                            p.Phone,
                            p.Email,
                            p.Day_Create,
                            p.Gender,
                            p.SalaryEmployee.CoSalary,
                            p.Identify
                        });
            dgvManaEmployee.DataSource = e.ToList();
        }

        public void ShowAllTimekeeping()
        {
            var l = adTKeeping
                .GetAll()
                .Where(p => p.StatusShift.Description == "Đã làm")
                .Select(
                    p =>
                        new
                        {
                            p.ID_Shift,
                         //   p.Employee.FullNameEm,
                            p.WorkedDate,
                            p.ShiftStartTime,
                            p.ShiftEndTime,
                            p.WorkedHour,
                            p.StatusShift.Description
                        }
                );
            dgvShowTimeKeeping.DataSource = l.ToList();
        }
      
        public void ShowAllPayroll()
        {
            List<int> list = adTKeeping
                .GetAll()
                .Where(p => p.StatusShift.Description == "Đã chấm công")
                .Select(p => p.ID_Employee)
                .ToList();
            var lHis = adHisPayroll.GetHisPayrollById(list)
                .Select(
                    p =>
                        new
                        {
                            p.PayrollDate,
                            p.Employee.ID_User,
                          //  p.Employee.FullNameEm,
                            p.Employee.Identify,
                            p.Salary,
                            p.Employee.SalaryEmployee.CoSalary,
                           // p.Shift.WorkedHour
                        }
                ) ;
            
            dgvShowPayroll.DataSource = lHis.ToList();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string txt = txtSearch.Text;
            string txtcbb = cbbSearch.Text;
            if (tbMana.SelectedIndex == 1)
            {
                var l = adTKeeping
                    .Search(txt, txtcbb)
                    .Where(p => p.StatusShift.Description == "Đã làm")
                    .Select(
                        p =>
                            new
                            {
                                p.ID_Shift,
                        //        p.Employee.FullNameEm,
                                p.WorkedDate,
                                p.ShiftStartTime,
                                p.ShiftEndTime,
                                p.WorkedHour,
                                p.StatusShift.Description
                            }
                    );
                dgvShowTimeKeeping.DataSource = l.ToList();
            }
            else if (tbMana.SelectedIndex == 2)
            {
                List<int> list = adTKeeping
                    .GetAll()
                    .Where(p => p.StatusShift.Description == "Đã chấm công")
                    .Select(p => p.ID_Employee)
                    .Distinct()
                    .ToList();
                //var l = adEm.Search(txt, txtcbb, list)
                //    .Select(
                //        p =>
                //            new
                //            {
                //                p.HistoryPayroll.PayrollDate,
                //                p.ID_User,
                //                p.FullNameEm,
                //                p.Identify,
                //                p.HistoryPayroll.Salary,
                //                p.SalaryEmployee.CoSalary,
                //                p.totalTime
                //            }
                //    );
                adEm = new AdminBLL_Em();
                //var data = l.ToList();
                //dgvShowPayroll.DataSource = data;
                foreach (DataGridViewRow i in dgvShowPayroll.Rows)
                {
                    i.Cells["Salary"].Value = i.Cells["Salary"].Value + " VND";
                }
            }
        }

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

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (tbMana.SelectedIndex == 1)
            {
                var l = adTKeeping
                    .Sort(cbbSort.Text)
                    .Where(p => p.StatusShift.Description == "Đã làm")
                    .Select(
                        p =>
                            new
                            {
                                p.ID_Shift,
                            //    p.Employee.FullNameEm,
                                p.WorkedDate,
                                p.ShiftStartTime,
                                p.ShiftEndTime,
                                p.WorkedHour,
                                p.StatusShift.Description
                            }
                    );
                dgvShowTimeKeeping.DataSource = l.ToList();
            }
            else if (tbMana.SelectedIndex == 2)
            {
                string txtcbb = cbbSort.Text;
                List<int> list = adTKeeping
                .GetAll()
                .Where(p => p.StatusShift.Description == "Đã chấm công")
                .Select(p => p.ID_Employee)
                .ToList();
                //List<Employee> l = adEm.GetAllById(list).ToList();
                var lHis = adHisPayroll.Sort(list,txtcbb)
                    .Select(
                        p =>
                            new
                            {
                                p.PayrollDate,
                                p.Employee.ID_User,
                           //     p.Employee.FullNameEm,
                                p.Employee.Identify,
                                p.Salary,
                                p.Employee.SalaryEmployee.CoSalary,
                             //   p.Shift.WorkedHour
                            }
                    );
                dgvShowPayroll.DataSource = lHis.ToList();
            }
        }

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

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            FormPayroll f = new FormPayroll();
            f.d = new FormPayroll.MyDel(ShowAllTimekeeping);
            f.Show();
            SetSalary();
        }

        private void cbPay_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbPay.Checked == true)
            {
                var l = adTKeeping
                    .GetAll()
                    .Where(p => p.StatusShift.Description == "Đã chấm công")
                    .Select(
                        p =>
                            new
                            {
                                p.ID_Shift,
                            //    p.Employee.FullNameEm,
                                p.WorkedDate,
                                p.ShiftStartTime,
                                p.ShiftEndTime,
                                p.WorkedHour,
                                p.StatusShift.Description
                            }
                    );
                dgvShowTimeKeeping.DataSource = l.ToList();
            }
            else
            {
                ShowAllTimekeeping();
            }
        }

        private void cbPay_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPay.Checked == true)
            {
                var l = adTKeeping
                    .GetAll()
                    .Where(p => p.StatusShift.Description == "Đã chấm công")
                    .Select(
                        p =>
                            new
                            {
                                p.ID_Shift,
                             //  p.Employee.FullNameEm,
                                p.WorkedDate,
                                p.ShiftStartTime,
                                p.ShiftEndTime,
                                p.WorkedHour,
                                p.StatusShift.Description
                            }
                    );
                dgvShowTimeKeeping.DataSource = l.ToList();
            }
            else
            {
                ShowAllTimekeeping();
            }
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            FormAddUpEm f = new FormAddUpEm("");
            f.d = new FormAddUpEm.MyDel(ShowAll_Empl);
            f.Show();
        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            if (dgvManaEmployee.SelectedRows.Count == 1)
            {
                string s = dgvManaEmployee.SelectedRows[0].Cells["ID_User"].Value.ToString();
                FormAddUpEm f = new FormAddUpEm(s);
                f.d = new FormAddUpEm.MyDel(ShowAll_Empl);
                f.Show();
            }
            ShowAll_Empl();
        }

        private void btnAddSala_Click(object sender, EventArgs e)
        {
            FormAddUpSalary f = new FormAddUpSalary("");
            f.d = new FormAddUpSalary.MyDel(ShowAll_Salary);
            f.Show();
        }

        private void btnUpdateSal_Click(object sender, EventArgs e)
        {
            if (dgvCosalaryEm.SelectedRows.Count == 1)
            {
                string s = dgvCosalaryEm.SelectedRows[0].Cells["ID_SalaryEmployee"].Value.ToString();
                FormAddUpSalary f = new FormAddUpSalary(s);
                f.d = new FormAddUpSalary.MyDel(ShowAll_Salary);
                f.Show();
            }
            ShowAll_Salary();
        }
    }
}
