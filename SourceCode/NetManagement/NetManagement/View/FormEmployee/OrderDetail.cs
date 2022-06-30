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
        private int id_employee;
        private BLlHandelOrder bLlHandelOrder = new BLlHandelOrder();
        public OrderDetail(int idorder , int idployee)
        {
            id = idorder;
            id_employee = idployee;
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
        private List<string> GetDesOrderDetail()
        {

            List<string> data = new List<string>();
            foreach (DataGridViewRow i in dataGridView1.Rows)
            {
                string id = i.Cells["Status"].Value.ToString();
                data.Add(id);
            }
            return data;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if ((comboBoxmethod.SelectedItem as string) == "Tài Khoản")
            {
                int status = bLlHandelOrder.PaymentAccount(bLlHandelOrder.GetIdCustormerByIdOrder(id), bLlHandelOrder.GetOrder(id).Total , id_employee);
                if (status == -1)
                {
                    MessageBox.Show(" Khong Du Tien");
                }
                else
                {
                    bLlHandelOrder.Payment(id, GetStatusOrderDetail(), "Tra Tai Khoan");
                }
            }
            else
            {
                bLlHandelOrder.Payment(id, GetStatusOrderDetail(), "Tra Truc tiep");
            }
            this.Dispose();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void comboBoxmethod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
