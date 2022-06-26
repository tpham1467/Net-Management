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
using NetManagement.BLL.BLLAdmin;
using NetManagement.DTO;

namespace NetManagement.View.FormAdmin
{
    public partial class FormCategory : Form
    {
        AdminBLL_Category adManaCategory = new AdminBLL_Category();
        BLL_Unit adUnit = new BLL_Unit();
        public FormCategory()
        {
            this.AutoScaleMode = AutoScaleMode.None;
            InitializeComponent();
            ReloadCategory();
            Create_CBB();
        }
        public void Create_CBB()
        {
            cbbSortProperty.Items.Add("Name Category");
            cbbSortProperty.Items.Add("ID_Category");
            cbbSearch.Items.Add("All");
            cbbSearch.Items.Add("Name Category");
            cbbSearch.Items.Add("ID_Category");
        }

        public void ReloadCategory(List<object> data = null)
        {
            if (data == null) dgvShowCTR.DataSource = adManaCategory.Filter();
            else dgvShowCTR.DataSource = data;
        }
        public void ReloadUnit(List<object> data = null)
        {
            if (data == null) dgvUnit.DataSource = adUnit.Filter();
            else dgvUnit.DataSource = data;
        }

        private void btnAddCTR_Click_1(object sender, EventArgs e)
        {
            FormUpdateAdd_CTR f = new FormUpdateAdd_CTR("");
            f.action = ReloadCategory;
            f.Show();
        }

        private void btnDelCTR_Click(object sender, EventArgs e)
        {
            string s;
            foreach (DataGridViewRow i in dgvShowCTR.SelectedRows)
            {
                s = i.Cells["ID_Category"].Value.ToString();
                adManaCategory.Del(s);
            }
            ReloadCategory();
        }

        private void btnUpCTR_Click(object sender, EventArgs e)
        {
            if (dgvShowCTR.SelectedRows.Count == 1)
            {
                string s = dgvShowCTR.SelectedRows[0].Cells["ID_Category"].Value.ToString();
                FormUpdateAdd_CTR f = new FormUpdateAdd_CTR(s);
                f.action = ReloadCategory;
                f.Show();
            }
        }

        private void btnSortCTR_Click(object sender, EventArgs e)
        {
            SortEnum sort = new SortEnum();
            if ((cbbSortby.SelectedItem as string) == "Asc")
            {
                sort = SortEnum.Asc;
            }
            else
            {
                sort = SortEnum.Desc;
            }
            dgvShowCTR.DataSource = adManaCategory.Sort(sort, (cbbSortProperty.SelectedItem as string));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string txt = txtSearch.Text;
            string s = cbbSearch.Text;
            List<object> list = new List<object>();
            if (s == "All")
            {
                list = adManaCategory.Search(txt, SearchAcoountEnum.All);
            }
            else if (s == "ID_Category")
            {
                list = adManaCategory.Search(txt, SearchAcoountEnum.Id);
            }
            else
            {
                list = adManaCategory.Search(txt, SearchAcoountEnum.Name);
            }
            ReloadCategory(list);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            ReloadCategory();
        }

        private void btnUnitAdd_Click(object sender, EventArgs e)
        {
            AddUpUnit_Form addUpUnit_Form = new AddUpUnit_Form(-1);
            addUpUnit_Form.d = new AddUpUnit_Form.MyDel(ReloadUnit);
            addUpUnit_Form.Show();
        }

        private void btnUnitUpdate_Click(object sender, EventArgs e)
        {
            if (dgvUnit.SelectedRows.Count == 1)
            {
                int s = Convert.ToInt32(dgvUnit.SelectedRows[0].Cells["ID_Unit"].Value);
                AddUpUnit_Form addUpUnit_Form = new AddUpUnit_Form(s);
                addUpUnit_Form.d = new AddUpUnit_Form.MyDel(ReloadUnit);
                addUpUnit_Form.Show();
            }
        }

        private void btnDeleteUnit_Click(object sender, EventArgs e)
        {

        }

        private void tbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tbCategory.SelectedIndex == 0)
            {
                ReloadCategory();
            }
            else
            {
                ReloadUnit();
            }

        }

     
    }
}
