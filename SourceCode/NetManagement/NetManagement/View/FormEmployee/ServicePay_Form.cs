using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetManagement.DTO;
using NetManagement.Helper;
using NetManagement.Model;
using NetManagement.BLL.BLLEmployee.BLLOrder;
namespace NetManagement.View.FormEmployee
{
    public partial class ServicePay_Form : Form
    {
        private int id;
        private BLlHandelOrder _BLlHandelOrder = new BLlHandelOrder();
        public ServicePay_Form(int Id)
        {
            id = Id;
            InitializeComponent();
            dataGridView1.DataSource = _BLlHandelOrder.FilterOrder();
        }
        private List<int> GetSelect()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                List<int> data = new List<int>();
                foreach (DataGridViewRow i in dataGridView1.SelectedRows)
                {
                    int id = System.Convert.ToInt32(i.Cells["ID_Order"].Value);
                    data.Add(id);
                }
                return data;
            }
            return new List<int>();
        }
        private void btnPayment_Click(object sender, EventArgs e)
        {
            List<int> data = GetSelect();
            if (data.Count  ==  1)
            {
                OrderDetail orderDetail = new OrderDetail(data[0]);
                orderDetail.Show();
            }
            
        }
        private void Reload()
        {
            dataGridView1.DataSource = _BLlHandelOrder.FilterOrder();
        }
        private void buttonReload_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void btnfill_Click(object sender, EventArgs e)
        {
            List<int> data = GetSelect();
            if (data.Count > 0)
            {
                _BLlHandelOrder.Fill(data);
            }
        }
    }
}
