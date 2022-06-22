using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetManagement.Model;
using NetManagement.BLL;

namespace NetManagement.View.FormAdmin
{
    public partial class FormCategory : Form
    {
        AdminBLL_Category adMana = new AdminBLL_Category();
        public FormCategory()
        {
            InitializeComponent();
            ShowAll_CTR();
            Create_CBB();
        }
        public void Create_CBB()
        {
            cbb_SortCTR.Items.Add("Name");
            cbb_SortCTR.Items.Add("ID_Category");
            cbbInc_dec.Items.Add("Increase");
            cbbInc_dec.Items.Add("Decrease");
            cbbSearch.Items.Add("Name");
            cbbSearch.Items.Add("ID_Category");
        }
        public void ShowAll_CTR()
        {
            var l = adMana.GetAll().Select(p => new { p.ID_Category, p.CategoryName, p.Description });
            adMana = new AdminBLL_Category();
            var data = l.ToList();
            dgvShowCTR.DataSource = data;
        }
        
        private void btnAddCTR_Click_1(object sender, EventArgs e)
        {
            FormUpdateAdd_CTR f = new FormUpdateAdd_CTR("");
            f.d = new FormUpdateAdd_CTR.MyDel(ShowAll_CTR);
            f.Show();
        }

        private void btnDelCTR_Click(object sender, EventArgs e)
        {
            string s;
            foreach (DataGridViewRow i in dgvShowCTR.SelectedRows)
            {
                s = i.Cells["ID_Category"].Value.ToString();
                adMana.Del(s);
            }
            ShowAll_CTR();
        }

        private void btnUpCTR_Click(object sender, EventArgs e)
        {
            if (dgvShowCTR.SelectedRows.Count == 1)
            {
                string s = dgvShowCTR.SelectedRows[0].Cells["ID_Category"].Value.ToString();
                FormUpdateAdd_CTR f = new FormUpdateAdd_CTR(s);
                f.d = new FormUpdateAdd_CTR.MyDel(ShowAll_CTR);
                f.Show();
            }
        }

        private void btnSortCTR_Click(object sender, EventArgs e)
        {
            if (cbb_SortCTR.Text == "Name")
            {
                dgvShowCTR.DataSource = adMana.Sort(cbb_SortCTR.Text, cbbInc_dec.Text);
            }
            else if (cbb_SortCTR.Text == "ID_Category")
            {
                dgvShowCTR.DataSource = adMana.Sort(cbb_SortCTR.Text, cbbInc_dec.Text);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string txt = txtSearch.Text;
            string s = cbbSearch.Text;
            dgvShowCTR.DataSource = adMana.Search(s, txt);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            ShowAll_CTR();
        }
    }
}
