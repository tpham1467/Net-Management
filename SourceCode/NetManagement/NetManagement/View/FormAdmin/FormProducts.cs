using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetManagement.BLL;
using NetManagement.BLL.BLLAdmin;
using NetManagement.DTO;

namespace NetManagement.View.FormAdmin
{
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
            ReloadProduct();
            SetCBB();
            tbControllMana.SelectedIndex = 0;
        }

        AdminBLL_Inventory adminBLL_Mana = new AdminBLL_Inventory();
        BLL_Product adminBLL_Product = new BLL_Product();
        public void SetCBB()
        {
            
            cbbSortProperty.Items.Clear();
            cbbSortProperty.Items.Add("ImportDay");
            cbbSortProperty.Items.Add("ExpiryDate");
            cbbSearch.Items.Clear();
            cbbSearch.Items.Add("All");
            cbbSearch.Items.Add("Name Product");
        }
        public void ReloadProduct(List<object> data = null)
        {
            if (tbControllMana.SelectedIndex == 0)
            {
                if (data == null) dgvMerMana.DataSource = adminBLL_Mana.Filter(0).ToList();
                else dgvMerMana.DataSource = data;
            }
            else if (tbControllMana.SelectedIndex == 1)
            {
                if (data == null) dgvPrMana.DataSource = adminBLL_Mana.Filter(1).ToList();
                else dgvPrMana.DataSource = data;
            }
            else
            {
                if (data == null) dgvProduct.DataSource = adminBLL_Product.Filter().ToList();
                else dgvProduct.DataSource = data;
            }
        }
        int k;

        private void btnSort_Click(object sender, EventArgs e)
        {
            SortEnum sort = new SortEnum();
            if (tbControllMana.SelectedIndex == 0)
            {

                if ((cbbSortBy.SelectedItem as string) == "Asc")
                {
                    sort = SortEnum.Asc;
                }
                else
                {
                    sort = SortEnum.Desc;
                }
                dgvMerMana.DataSource = adminBLL_Mana.Sort(sort, (cbbSortProperty.SelectedItem as string));
            }
            else
            {
                if ((cbbSortBy.SelectedItem as string) == "Asc")
                {
                    sort = SortEnum.Asc;
                }
                else
                {
                    sort = SortEnum.Desc;
                }
                dgvPrMana.DataSource = adminBLL_Mana.Sort(sort, (cbbSortProperty.SelectedItem as string));
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string txt = txtSearch.Text;
            string s = cbbSearch.Text;
            List<object> list = new List<object>();

            if (tbControllMana.SelectedIndex == 0)
            {
                if (s == "All")
                {
                    list = adminBLL_Mana.Search(0,txt, SearchAcoountEnum.All);
                }
                else
                {
                    list = adminBLL_Mana.Search(0,txt, SearchAcoountEnum.Name);
                }
                ReloadProduct(list);
            }
            else if (tbControllMana.SelectedIndex == 1)
            {
                if (s == "All")
                {
                    list = adminBLL_Mana.Search(1, txt, SearchAcoountEnum.All);
                }
                else if(s== "SalePrice")
                {
                    list = adminBLL_Mana.Search(1, txt, SearchAcoountEnum.SalePriceOfProduct);
                }
                else {
                    list = adminBLL_Mana.Search(1, txt, SearchAcoountEnum.Name);
                }
                ReloadProduct(list);
            }
        }

        private void cbbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSearch.Text == "All")
            {
                txtSearch.Text = "";
                txtSearch.Enabled = false;
            }
            else
            {
                txtSearch.Text = "";
                txtSearch.Enabled = true;
            }
        }

        private void tbControllMana_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tbControllMana.SelectedIndex == 0)
            {
                SetCBB();
                ReloadProduct();
            }
            else if (tbControllMana.SelectedIndex == 1)
            {
                cbbSortProperty.Items.Clear();
                cbbSortProperty.Items.Add("ImportPrices");
                cbbSortProperty.Items.Add("SalePrice");
                cbbSearch.Items.Clear();
                cbbSearch.Items.Add("All");
                cbbSearch.Items.Add("Name Product");
                cbbSearch.Items.Add("SalePrice");
                ReloadProduct();
            }
            else
            {
                ReloadProduct();
            }
        }

        

        private void btnDel_Click_1(object sender, EventArgs e)
        {
            string s;
            if (tbControllMana.SelectedIndex == 0)
            {
                foreach (DataGridViewRow i in dgvMerMana.SelectedRows)
                {
                    s = i.Cells["ID_Inventory"].Value.ToString();
                    adminBLL_Mana.DelProduct(s);
                }
            }
            else if (tbControllMana.SelectedIndex == 1)
            {
                foreach (DataGridViewRow i in dgvPrMana.SelectedRows)
                {
                    s = i.Cells["ID_Inventory"].Value.ToString();
                    adminBLL_Mana.DelProduct(s);
                }
            }
            ReloadProduct();
        }
        int check;
        private void btnUp_Click_1(object sender, EventArgs e)
        {
            check = 1;
            if (tbControllMana.SelectedIndex == 0)
            {
                k = 0;
            }
            else if (tbControllMana.SelectedIndex == 1)
            {
                k = 1;
            }
            if (dgvMerMana.SelectedRows.Count == 1)
            {
                string s = dgvMerMana.SelectedRows[0].Cells["ID_Inventory"].Value.ToString();
                FormAddProductExport f = new FormAddProductExport(s, k);
                f.d = new FormAddProductExport.MyDel(ReloadProduct);
                f.Show();
            }
            if (dgvMerMana.SelectedRows.Count == 1)
            {
                int s = Convert.ToInt32(dgvProduct.SelectedRows[0].Cells["ID_Product"].Value);
                AddUpProduct f = new AddUpProduct(s,check);
                f.d = new AddUpProduct.MyDel(ReloadProduct);
                f.Show();
            }
        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            check = 0;
            if (tbControllMana.SelectedIndex == 2)
            {
                AddUpProduct f = new AddUpProduct(-1, -1);
                f.d = new AddUpProduct.MyDel(ReloadProduct);
                f.Show();
            }
            else
            {
                FormAddProductExport f = new FormAddProductExport("", 0);
                f.d = new FormAddProductExport.MyDel(ReloadProduct);
                f.Show();
            }
        }
    }
}
