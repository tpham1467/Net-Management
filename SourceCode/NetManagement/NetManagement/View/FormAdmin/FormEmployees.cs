using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetManagement.View.FormAdmin
{
    public partial class FormEmployees : Form
    {
        private string filter;

        public FormEmployees()
        {
            InitializeComponent();
            for (int i=0; i< 100; i++)
            {
                dataGridView1.Rows.Add(new object[]
                {
                    imageList1.Images[0],
                });
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            this.filter = "";
        }

        private void btnFull_Click(object sender, EventArgs e)
        {

        }
    }
}
