using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetManagement.BLL.BLLEmployee.BLLOrder;
namespace NetManagement.View.FormEmployee
{
    public partial class OrderDetail : Form
    {
        private int id;
        private BLlHandelOrder bLlHandelOrder = new BLlHandelOrder();
        public OrderDetail(int idorder)
        {
            id = idorder;
            InitializeComponent();
            dataGridView1.DataSource = bLlHandelOrder.FilterOrderDeTail(id);
        }
        private void LoadStatusOrderDetail()
        {

        }
        private List<bool> GetStatusOrderDetail()
        {

            List<bool> data = new List<bool>();
            foreach (DataGridViewRow i in dataGridView1.Rows)
            {
                bool id = Convert.ToBoolean(i.Cells["Ok"].Value);
                data.Add(id);
            }
            return data;
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            bLlHandelOrder.Payment(id, GetStatusOrderDetail());
            this.Dispose();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
