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
using NetManagement.DTO;
using NetManagement.Model;

namespace NetManagement.View.FormAdmin
{
    public partial class FormPayroll : Form
    {
        public delegate void MyDel();
        public MyDel d;
        AdminBLL_Em adEm = new AdminBLL_Em();
        AdminBLL_Timekeeping adTKeeping = new AdminBLL_Timekeeping();
        AdminBLL_HisPayroll adHisPayroll = new AdminBLL_HisPayroll();
        public bool check = false;
        public FormPayroll()
        {
            InitializeComponent();
            SetSalary();
            ShowAll(check);
            SetChangeCBB();
        }
        public void SetSalary()
        {
            List<Shift> list = adTKeeping.GetAll().Where(p => p.StatusShift.Description == "Đã làm").ToList();

            foreach (HistoryPayroll i in adHisPayroll.GetAll())
            {
                foreach (Shift s in list)
                {
                    if (i.ID_User == s.Employee.ID_User)
                    {
                        i.Salary = i.Shift.WorkedHour * i.Employee.SalaryEmployee.CoSalary;
                    }
                }
                
            }
        }

        public void ShowAll(bool ckeck)
        {
            DataTable db = new DataTable();
            db.Columns.AddRange(new DataColumn[] {
                new DataColumn("Name",typeof(string)),
                new DataColumn("Salary",typeof(string)),
                new DataColumn("WorkHour",typeof(int)),
                new DataColumn("Select",typeof(bool))
            });
            List<HistoryPayroll> listEm = new List<HistoryPayroll>();
            List<HistoryPayroll> listHis = adHisPayroll.GetAll().Where(p => p.Shift.StatusShift.Description == "Đã làm").ToList();
            List<Shift> list = adTKeeping.GetAll().Where(p => p.StatusShift.Description == "Đã làm").ToList();
            foreach (HistoryPayroll his in listHis)
            {
                    foreach (Shift sh in list)
                    { 
                        if(his.ID_User == sh.Employee.ID_User)
                        {
                            listEm.Add(his);
                        }
                    }
            }
            foreach(HistoryPayroll his in listEm)
            {
                    db.Rows.Add(his.Employee.FullNameEm, his.Salary,his.Shift.WorkedHour, check);
            }
            dgvShow.DataSource = db;
        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                adTKeeping.updateIDStatus("");
            }
            d();
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void SetChangeCBB()
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Checked = false;
                check = false;
                ShowAll(check);

            }
            else
            {
                checkBox1.Checked = true;
                check = true;
                ShowAll(check);

            }
        }

        private void btnPayrollAll_Click(object sender, EventArgs e)
        {
            SetChangeCBB();
        }
    }
}
