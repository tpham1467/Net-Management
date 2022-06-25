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
            ReloadShift(null);
        }

        AdminBLL_Timekeeping adShift = new AdminBLL_Timekeeping();

        public void ReloadShift(StatusShift statusShift ,  List<object> data = null )
        {
            if (data == null)
                dgvShift.DataSource = adShift.Filter(
                statusShift);
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
            ReloadShift(null);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            FormAddUpShift f = new FormAddUpShift("");
            f.action = ReloadShift;
            f.Show();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (dgvShift.SelectedRows.Count == 1)
            {
                string s = dgvShift.SelectedRows[0].Cells["ID_Shift"].Value.ToString();
                FormAddUpShift f = new FormAddUpShift(s);
                f.action = ReloadShift;
                f.Show();
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            List<Object> data = new List<object>();
            StatusShift statusShift = new StatusShift();
            if(comboBoxtype.SelectedItem == null)
            {

            }
            else
            {

            }
            ReloadShift(statusShift , data);
        }
    }
}
