using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetManagement.BLL.BLLEmployee.BLLAccoutManagement;
using NetManagement.DTO;
using NetMessageBox = NetManagement.Helper.NetMessageBox;
namespace NetManagement.View.FormEmployee
{
    public partial class AccManagement_Form : Form
    {
        private BLLAccoutManagement bLLAccoutManagement = new BLLAccoutManagement();
        private int IdEmloyee;
        public AccManagement_Form(int id)
        {
            IdEmloyee = id;
            InitializeComponent();
            dataGridView1.DataSource = bLLAccoutManagement.Filter();
        }
        public void Reload(List<object> data = null)
        {
            if (data == null)
                dataGridView1.DataSource = bLLAccoutManagement.Filter();
            else dataGridView1.DataSource = data;
        }
        private void buttonTopUp_Click(object sender, EventArgs e)
        {
            List<int> data = GetSelect();
            if (data.Count > 0)
            {
                TopUp topUp = new TopUp(data , IdEmloyee );
                topUp.action += Reload;
                topUp.Show();
            }
            else
            {
                DialogResult result = NetMessageBox.Show("Bạn Chưa Chọn Tài Khoản Nào",
          "Important Message");
                return;
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
                dataGridView1.DataSource = bLLAccoutManagement.Filter();
            }
            else
            {

                DialogResult result = NetMessageBox.Show("Bạn Chưa Chọn Tài Khoản Nào",
          "Important Message");
                return;
            }
        }

        private void buttonUnlock_Click(object sender, EventArgs e)
        {
            List<int> data = GetSelect();
            if (data.Count > 0)
            {
                bLLAccoutManagement.Unlock(data);
                dataGridView1.DataSource = bLLAccoutManagement.Filter();
            }
            else
            {

                DialogResult result = NetMessageBox.Show("Bạn Chưa Chọn Tài Khoản Nào",
          "Important Message");
                return;
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            SortEnum sort = new SortEnum();
            if((comboBoxSort.SelectedItem as string ) ==  "Asc")
            {
                sort = SortEnum.Asc;
            }
            else
            {
                sort = SortEnum.Desc;
            }
           dataGridView1.DataSource =  bLLAccoutManagement.Sort(sort, (comboBoxProperty.SelectedItem as string));
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
            string search = textBoxsearch.Text;
            string by = comboBoxbysearch.SelectedItem.ToString();
            List<object> list = new List<object>();
            if(by =="ALL")
            {
                list = bLLAccoutManagement.Search(search, SearchAcoountEnum.All);
            }
            else if(by == "ID")
            {
                list = bLLAccoutManagement.Search(search, SearchAcoountEnum.Id);
            }
            else if (by == "Name")
            {
                list =bLLAccoutManagement.Search(search, SearchAcoountEnum.Name);
            }
            else
            {
                list =bLLAccoutManagement.Search(search, SearchAcoountEnum.UserName);
            }
            Reload(list);
            comboBoxbysearch.SelectedIndex = 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<int> data = GetSelect();
            if (data.Count == 0) MessageBox.Show("Vui Long Chon");
            else
            {
                FormAddUpdateAcc formAddUpdateAcc = new FormAddUpdateAcc(IdEmloyee , data[0]);
                formAddUpdateAcc.action = Reload;
                formAddUpdateAcc.Show();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<int> data = GetSelect();
            if (data.Count > 0)
            {
                bLLAccoutManagement.Delete(data);
                dataGridView1.DataSource = bLLAccoutManagement.Filter();
            }
            else
            {

                DialogResult result = NetMessageBox.Show("Bạn Chưa Chọn Tài Khoản Nào",
          "Important Message");
                return;
            }
        }
     
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddUpdateAcc formAddUpdateAcc = new FormAddUpdateAcc(IdEmloyee, -1);
            formAddUpdateAcc.action = Reload;
            formAddUpdateAcc.Show();
            
        }
    }
}
