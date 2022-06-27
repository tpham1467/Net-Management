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
        public Action<List<object>> action;
        AdminBLL_Em adEm = new AdminBLL_Em();
        AdminBLL_Timekeeping adTKeeping = new AdminBLL_Timekeeping();
        AdminBLL_HisPayroll adHisPayroll = new AdminBLL_HisPayroll();
        private bool IsAll  = false;
        public FormPayroll()
        {
            this.AutoScaleMode = AutoScaleMode.None;
            InitializeComponent();
            LoadPayRoll();
        }
   
        private void LoadPayRoll()
        {
            dgvShow.DataSource = adHisPayroll.PayRoll(null, false);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                IsAll = true;
            }
            else IsAll = false;
        }
        private List<int> GetSelect()
        {
            if (dgvShow.SelectedRows.Count > 0)
            {
                List<int> data = new List<int>();
                foreach (DataGridViewRow i in dgvShow.SelectedRows)
                {
                    int id = Convert.ToInt32(i.Cells["ID_User"].Value);
                    data.Add(id);
                }
                return data;
            }
            return new List<int>();
        }      
        private void btnPayroll_Click(object sender, EventArgs e)
        {
            if (IsAll)
            {
                adHisPayroll.PayRoll(null, true);
            }
            else
            {
                adHisPayroll.PayRoll(GetSelect(), true);
            }
            action(null);
            this.Dispose();
        }
    }
}
