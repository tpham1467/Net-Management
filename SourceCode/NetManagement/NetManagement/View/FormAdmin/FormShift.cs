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
    public partial class FormShift : Form
    {
        public FormShift()
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
