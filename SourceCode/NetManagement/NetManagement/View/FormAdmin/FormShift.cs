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
            ReloadShift();
        }

        AdminBLL_Timekeeping adShift = new AdminBLL_Timekeeping();

        public void ReloadShift(List<object> data = null)
        {
            if (data == null)
                dgvShift.DataSource = adShift.Filter(
                    adShift
                        .GetAll()
                        .Where(
                            p =>
                                p.StatusShift.Description == "Đã làm"
                                || p.StatusShift.Description == "Xin nghỉ"
                                || p.StatusShift.Description == "Chưa làm"
                        )
                );
            else
                dgvShift.DataSource = data;
        }

        private void icBtnAddShift_Click(object sender, EventArgs e) { }

        private void btnDel_Click(object sender, EventArgs e)
        {
            adShift = new AdminBLL_Timekeeping();
            string s;
            foreach (DataGridViewRow i in dgvShift.SelectedRows)
            {
                s = i.Cells["ID_Shift"].Value.ToString();
                adShift.DelShift(s);
            }
            ReloadShift();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            FormAddUpShift f = new FormAddUpShift("");
            f.d = new FormAddUpShift.MyDel(ReloadShift);
            f.Show();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (dgvShift.SelectedRows.Count == 1)
            {
                string s = dgvShift.SelectedRows[0].Cells["ID_Shift"].Value.ToString();
                FormAddUpShift f = new FormAddUpShift(s);
                f.d = new FormAddUpShift.MyDel(ReloadShift);
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
            list = list.Select(p => p).Distinct().OrderBy(p => p).ToList();
            foreach (string s in list)
            {
                cbbTypeDt.Items.Add(s);
            }
        }

        private void cbbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTypeView.Text == "Xem theo ngày")
            {
                cbbTypeDt.Items.Clear();
                ViewTypeDetail("M/dd/yyyy");
            }
            if (cbbTypeView.Text == "Xem theo tháng")
            {
                cbbTypeDt.Items.Clear();
                ViewTypeDetail("M/yyyy");
            }
            if (cbbTypeView.Text == "Xem theo năm")
            {
                cbbTypeDt.Items.Clear();
                ViewTypeDetail("yyyy");
            }
        }

        public void ViewofTypeDetail(string s)
        {
            string txt = cbbTypeDt.Text;
            adShift = new AdminBLL_Timekeeping();
            var l = adShift.Filter(
                adShift
                    .GetAll()
                    .Where(p => p.WorkedDate.ToString(s) == cbbTypeDt.Text)
                    .Where(
                        p =>
                            p.StatusShift.Description == "Đã làm"
                            || p.StatusShift.Description == "Xin nghỉ"
                            || p.StatusShift.Description == "Chưa làm"
                    )
            );
            dgvShift.DataSource = l.ToList();
        }

        private void cbTypeDt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTypeView.Text == "Xem theo ngày")
            {
                ViewofTypeDetail("M/dd/yyyy");
            }
            else if (cbbTypeView.Text == "Xem theo tháng")
            {
                ViewofTypeDetail("M/yyyy");
            }
            else if (cbbTypeView.Text == "Xem theo năm")
            {
                ViewofTypeDetail("yyyy");
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            ReloadShift();
            cbbTypeView.Text = "";
            cbbTypeDt.Text = "";
        }
    }
}
