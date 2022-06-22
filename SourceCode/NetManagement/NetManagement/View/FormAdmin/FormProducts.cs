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

namespace NetManagement.View.FormAdmin
{

    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
            ShowAllMer();
            cbbSort.Items.Clear();
            cbbSort.Items.Add("ImportDay");
            cbbSort.Items.Add("ExpiryDate");
            cbbSearch.Items.Clear();
            cbbSearch.Items.Add("All");
            cbbSearch.Items.Add("Name Product");
        }
        
        AdminBLL_MerMana adMer = new AdminBLL_MerMana();
        public void ShowAllMer()
        {
            
            cbbInDe.Items.Clear();
            cbbInDe.Items.Add("Increase");
            cbbInDe.Items.Add("Decrease");
            adMer = new AdminBLL_MerMana();
            if (tbControllMana.SelectedIndex == 0)
            {
                var l = adMer.GetAll().Select(p => new { p.ID_Inventory, p.Product.NameProduct, p.Amount,p.Product.Unit.NameUnit, p.ImportDay, p.ExpiryDate});
                dgvMerMana.DataSource = l.ToList();
            }
            else if (tbControllMana.SelectedIndex == 1){
                var l = adMer.GetAll().Select(p => new { p.ID_Inventory, p.Product.NameProduct, p.Amount, p.Product.Unit.NameUnit, p.ImportPrices, p.SalePrice });
                dgvPrMana.DataSource = l.ToList();
            }
        }

        private void btnMerMana_Click(object sender, EventArgs e)
        {
            tbControllMana.SelectedIndex = 0;
            cbbSort.Items.Clear();
            cbbSort.Items.Add("ImportDay");
            cbbSort.Items.Add("ExpiryDate");
            cbbSearch.Items.Clear();
            cbbSearch.Items.Add("All");
            cbbSearch.Items.Add("Name Product");
            ShowAllMer();
        }

        private void btnPrMana_Click(object sender, EventArgs e)
        {
            tbControllMana.SelectedIndex = 1;
            cbbSort.Items.Clear();
            cbbSort.Items.Add("ImportPrices");
            cbbSort.Items.Add("SalePrice");
            cbbSearch.Items.Clear();
            cbbSearch.Items.Add("All");
            cbbSearch.Items.Add("Name Product");
            cbbSearch.Items.Add("SalePrice");
            ShowAllMer();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
                string s;
                if(tbControllMana.SelectedIndex == 0)
            {
                foreach (DataGridViewRow i in dgvMerMana.SelectedRows)
                {
                    s = i.Cells["ID_Inventory"].Value.ToString();
                    adMer.DelMer(s);
                }
            }
            else if (tbControllMana.SelectedIndex == 1)
            {
                foreach (DataGridViewRow i in dgvPrMana.SelectedRows)
                {
                    s = i.Cells["ID_Inventory"].Value.ToString();
                    adMer.DelMer(s);
                }
            }
            ShowAllMer();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddProduct f = new FormAddProduct("",0);
            f.d = new FormAddProduct.MyDel(ShowAllMer);
            f.Show();
        }
        int k;
        private void btnUp_Click(object sender, EventArgs e)
        {
            if(tbControllMana.SelectedIndex == 0)
            {
                k = 0;
            }
            if (tbControllMana.SelectedIndex == 1)
            {
                k = 1;
            }
            if (dgvMerMana.SelectedRows.Count == 1)
            {
                string s = dgvMerMana.SelectedRows[0].Cells["ID_Inventory"].Value.ToString();
                FormAddProduct f = new FormAddProduct(s,k);
                f.d = new FormAddProduct.MyDel(ShowAllMer);
                f.Show();
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if(tbControllMana.SelectedIndex == 0)
            {
                var l = adMer.Sort(cbbInDe.Text,cbbSort.Text).Select(p => new { p.ID_Inventory, p.Product.NameProduct, p.Amount, p.Product.Unit.NameUnit, p.ImportDay, p.ExpiryDate });

                dgvMerMana.DataSource = l.ToList();
            }
            else if (tbControllMana.SelectedIndex == 1){
                var l = adMer.Sort(cbbInDe.Text, cbbSort.Text).Select(p => new { p.ID_Inventory, p.Product.NameProduct, p.Amount, p.Product.Unit.NameUnit, p.ImportPrices, p.SalePrice });

                dgvPrMana.DataSource = l.ToList();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string txt = txtSearch.Text;
            string s = cbbSearch.Text;
            

            if (tbControllMana.SelectedIndex == 0)
            {
                var l = adMer.Search(txt, s).Select(p => new { p.ID_Inventory, p.Product.NameProduct, p.Amount, p.Product.Unit.NameUnit, p.ImportDay, p.ExpiryDate });

                dgvMerMana.DataSource = l.ToList();
            }
            else if (tbControllMana.SelectedIndex == 1)
            {
                var l = adMer.Search(txt, s).Select(p => new { p.ID_Inventory, p.Product.NameProduct, p.Amount, p.Product.Unit.NameUnit, p.ImportPrices, p.SalePrice });

                dgvPrMana.DataSource = l.ToList();
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
    }
}
