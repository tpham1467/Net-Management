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

    public partial class FormProducts : Form
    {
        DataTable dt;
        public FormProducts()
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

        private void btnPrMana_Click(object sender, EventArgs e)
        {
            btnHistory.BackColor = Color.FromArgb(64, 45, 64);
            btnMerMana.BackColor = Color.FromArgb(64, 45, 64);
            btnPrMana.BackColor = Color.RosyBrown;
            dataGridView1.Columns.Clear();
            dt = new DataTable();
            dt.Columns.AddRange(new[]
                {
                    new DataColumn(" ", typeof(Image)),
                    new DataColumn("STT", typeof(int)),
                    new DataColumn("IdProduct", typeof(string)),
                    new DataColumn("NameProduct", typeof(string)),
                    new DataColumn("ImportPrice", typeof(DateTime)),
                    new DataColumn("SellingPrice", typeof(string)),
                });
            Create();
            dataGridView1.DataSource = dt;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            btnHistory.BackColor = Color.RosyBrown;
            btnPrMana.BackColor = Color.FromArgb(64, 45, 64);
            btnMerMana.BackColor = Color.FromArgb(64, 45, 64);
            dataGridView1.Columns.Clear();
            dt = new DataTable();
            dt.Columns.AddRange(new[]
                {
                    new DataColumn(" ", typeof(Image)),
                    new DataColumn("STT", typeof(int)),
                    new DataColumn("IdProduct", typeof(string)),
                    new DataColumn("Customer", typeof(string)),
                    new DataColumn("DayUsed", typeof(DateTime)),
                    new DataColumn("NameProduct", typeof(string)),
                    new DataColumn("Amount", typeof(int)),
                    new DataColumn("Cost/1", typeof(double)),
                });
            Create();
            dataGridView1.DataSource = dt;
        }

        private void btnMerMana_Click(object sender, EventArgs e)
        {
            btnHistory.BackColor = Color.FromArgb(64, 45, 64);
            btnPrMana.BackColor = Color.FromArgb(64, 45, 64);
            btnMerMana.BackColor = Color.RosyBrown;
            dataGridView1.Columns.Clear();
            dt = new DataTable();
            dt.Columns.AddRange(new[]
                {
                    new DataColumn(" ", typeof(Image)),
                    new DataColumn("STT", typeof(int)),
                    new DataColumn("IdProduct", typeof(string)),
                    new DataColumn("NameProduct", typeof(string)),
                    new DataColumn("ImportDate", typeof(int)),
                    new DataColumn("ExpiryDate", typeof(double)),
                });
            Create();
            dataGridView1.DataSource = dt;
        }
    }
}
