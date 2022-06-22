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

namespace NetManagement.View.FormAdmin
{
    public partial class FormShift : Form
    {
        
        public FormShift()
        {
            InitializeComponent();
            ShowAllShift();
        }
        AdminBLL_Timekeeping adShift = new AdminBLL_Timekeeping();
        public void ShowAllShift()
        {
             adShift = new AdminBLL_Timekeeping();
            var l = adShift.GetAll().Where(p=>p.StatusShift.Description == "Đã làm" || p.StatusShift.Description == "Xin nghỉ" || p.StatusShift.Description == "Chưa làm").Select(p => new { p.ID_Shift, p.Employee.FullNameEm,p.WorkedDate,p.ShiftStartTime,p.ShiftEndTime,p.StatusShift.Description });
            dgvShift.DataSource = l.ToList();
        }

        private void icBtnAddShift_Click(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            adShift = new AdminBLL_Timekeeping();
            string s;
                foreach (DataGridViewRow i in dgvShift.SelectedRows)
                {
                    s = i.Cells["ID_Shift"].Value.ToString();
                    adShift.DelShift(s);
                }
            ShowAllShift();
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            FormAddUpShift f = new FormAddUpShift("");
            f.d = new FormAddUpShift.MyDel(ShowAllShift);
            f.Show();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (dgvShift.SelectedRows.Count == 1)
            {
                string s = dgvShift.SelectedRows[0].Cells["ID_Shift"].Value.ToString();
                FormAddUpShift f = new FormAddUpShift(s);
                f.d = new FormAddUpShift.MyDel(ShowAllShift);
                f.Show();
            }
        }
        public void ViewTypeDetail(string str)
        {
            List<DateTime> l = adShift.GetAll().Select(p => p.WorkedDate).Distinct().ToList();
            List<string> list = new List<string>();
            foreach (DateTime dt in l)
            {
                list.Add(dt.ToString(str));
            }
            list = list.Select(p => p).Distinct().ToList();
            foreach (string s in list)
            {
                cbTypeDt.Items.Add(s);
            }
        }
        private void cbbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTypeView.Text == "Xem theo ngày")
            {
                cbTypeDt.Items.Clear();
                ViewTypeDetail("MM/dd/yyyy");
            }
            if (cbbTypeView.Text == "Xem theo tháng")
            {
                cbTypeDt.Items.Clear();
                ViewTypeDetail("MM/yyyy");
            }
            if (cbbTypeView.Text == "Xem theo năm")
            {
                cbTypeDt.Items.Clear();
                ViewTypeDetail("yyyy");
            }
        }
        public void ViewofTypeDetail(string s)
        {
            string txt = cbTypeDt.Text;
            adShift = new AdminBLL_Timekeeping();
            List<Shift> list = adShift.GetAll().ToList();
            List<Shift> lShi = new List<Shift>();
            foreach (Shift sh in list)
            {
                if (sh.WorkedDate.ToString(s) == cbTypeDt.Text)
                {
                    lShi.Add(sh);
                }
            }
            var l = lShi.Where(p => p.StatusShift.Description == "Đã làm" || p.StatusShift.Description == "Xin nghỉ" || p.StatusShift.Description == "Chưa làm").Select(p => new { p.ID_Shift, p.Employee.FullNameEm, p.WorkedDate, p.ShiftStartTime, p.ShiftEndTime, p.StatusShift.Description });
            dgvShift.DataSource = l.ToList();
        }

        private void cbTypeDt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTypeView.Text == "Xem theo ngày")
            {
                string txt = cbTypeDt.Text;
                adShift = new AdminBLL_Timekeeping();
                var l = adShift.GetAll().Where(p=>p.WorkedDate== Convert.ToDateTime(txt)|| p.StatusShift.Description == "Đã làm" || p.StatusShift.Description == "Xin nghỉ" || p.StatusShift.Description == "Chưa làm").Select(p => new { p.ID_Shift, p.Employee.FullNameEm, p.WorkedDate, p.ShiftStartTime, p.ShiftEndTime, p.StatusShift.Description });
                dgvShift.DataSource = l.ToList();
            }
            else if (cbbTypeView.Text == "Xem theo tháng")
            {
                ViewofTypeDetail("MM/yyyy");
            }
            else if(cbbTypeView.Text == "Xem theo năm")
            {
                ViewofTypeDetail("yyyy");
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            ShowAllShift();
            cbbTypeView.Text = "";
            cbTypeDt.Text = "";
        }

    }
}
