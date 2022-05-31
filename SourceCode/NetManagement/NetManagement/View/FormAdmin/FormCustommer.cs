using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernUI_FontAw
{
    public partial class FormCustommer : Form
    {
        DataTable dt;
        public FormCustommer()
        {
            InitializeComponent();
            for (int i = 0; i < 100; i++)
            {
                dataGridView1.Rows.Add(new object[]
                {
                    imageList1.Images[0],
                });
            }
        }
        public void Create()
        {
            for (int i = 0; i < 100; i++)
            {
                dt.Rows.Add(new object[]
                {
                    imageList1.Images[0],
                });
            }
        }

        private void btnInf_Click(object sender, EventArgs e)
        {
            btnSer.BackColor = Color.FromArgb(64, 45, 64);
            btnInf.BackColor = Color.RosyBrown;
            dataGridView1.Columns.Clear();
            dt = new DataTable();
            dt.Columns.AddRange(new[]
                {
                    new DataColumn(" ", typeof(Image)),
                    new DataColumn("STT", typeof(int)),
                    new DataColumn("Name", typeof(string)),
                    new DataColumn("NameAccount", typeof(string)),
                    new DataColumn("IdPC", typeof(int)),
                    new DataColumn("State", typeof(bool)),
                    new DataColumn("CurrentBalance", typeof(double)),
                });
            Create();
            dataGridView1.DataSource = dt;
        }

        private void btnSer_Click(object sender, EventArgs e)
        {

            btnInf.BackColor = Color.FromArgb(64, 45, 64);
            btnSer.BackColor = Color.RosyBrown;
            dataGridView1.Columns.Clear();
            dt = new DataTable();
            dt.Columns.AddRange(new[]
                {
                    new DataColumn(" ", typeof(Image)),
                    new DataColumn("STT", typeof(int)),
                    new DataColumn("Name", typeof(string)),
                    new DataColumn("NameAccount", typeof(string)),
                    new DataColumn("IdPC", typeof(int)),
                    new DataColumn("TotalCosts", typeof(double)),
                });
            Create();
            dataGridView1.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
