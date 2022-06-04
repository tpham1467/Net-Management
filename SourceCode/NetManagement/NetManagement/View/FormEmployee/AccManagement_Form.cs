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

        private void buttonTopUp_Click(object sender, EventArgs e)
        {
            TopUp topUp = new TopUp();
            topUp.Show();
        }

        private void buttonAllowance_Click(object sender, EventArgs e)
        {

        }

        private void buttonLock_Click(object sender, EventArgs e)
        {

        }

        private void buttonUnlock_Click(object sender, EventArgs e)
        {

        }

        private void buttonSort_Click(object sender, EventArgs e)
        {

        }
    }
}
