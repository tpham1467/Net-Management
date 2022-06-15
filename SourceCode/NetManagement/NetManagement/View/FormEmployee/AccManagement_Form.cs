using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetManagement.BLL.BLLEmployee;
namespace NetManagement.View.FormEmployee
{
    public partial class AccManagement_Form : Form
    {
        private BLLAccoutManagement bLLAccoutManagement = new BLLAccoutManagement();
        public AccManagement_Form()
        {
            InitializeComponent();
            dataGridView1.DataSource = bLLAccoutManagement.Filter();
        }
        public void Reload()
        {
            dataGridView1.DataSource = bLLAccoutManagement.Filter();
        }
        private void buttonTopUp_Click(object sender, EventArgs e)
        {
            List<int> data = GetSelect();
            if (data.Count > 0)
            {
                TopUp topUp = new TopUp(data);
                topUp.action += Reload;
                topUp.Show();
            }
            else
            {
                MessageBox.Show("Vui Long Chon");
            }
        }

        private void buttonAllowance_Click(object sender, EventArgs e)
        {

        }

        private void buttonLock_Click(object sender, EventArgs e)
        {
            List<int> data = GetSelect();
            if (data.Count > 0)
            {
                bLLAccoutManagement.Lock(data);
            }
            else
            {
                MessageBox.Show("Vui Long Chon");
            }
        }

        private void buttonUnlock_Click(object sender, EventArgs e)
        {
            List<int> data = GetSelect();
            if (data.Count > 0)
            {
                bLLAccoutManagement.Unlock(data);
            }
            else
            {
                MessageBox.Show("Vui Long Chon");
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {

        }
        private List<int> GetSelect()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                List<int> data = new List<int>();
                foreach (DataGridViewRow i in dataGridView1.SelectedRows)
                {
                    int id = Convert.ToInt32(i.Cells["ID_Account"].Value);
                    data.Add(id);
                }
                return data;
            }
            return new List<int>();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
