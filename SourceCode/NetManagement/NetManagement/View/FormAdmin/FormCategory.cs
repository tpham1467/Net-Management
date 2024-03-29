﻿using System;
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
using NetManagement.Helper;

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
            cbbSortProperty.Items.Clear();
            cbbSearch.Items.Clear();
            if (tbCategory.SelectedIndex == 0)
            {
            
                cbbSortProperty.Items.Add("Name Category");
                cbbSortProperty.Items.Add("ID_Category");
                cbbSearch.Items.Add("All");
                cbbSearch.Items.Add("Name Category");
                cbbSearch.Items.Add("ID_Category");
            }
            else
            {
                cbbSearch.Items.Clear();
                cbbSearch.Items.Add("All");
                cbbSearch.Items.Add("Name Unit");
                cbbSearch.Items.Add("ID_Unit");
            }
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
            FormUpdateAdd_CTR f = new FormUpdateAdd_CTR(-1);
            f.action = ReloadCategory;
            f.Show();
        }

        private void btnDelCTR_Click(object sender, EventArgs e)
        {
            int s;
            if (dgvShowCTR.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in dgvShowCTR.SelectedRows)
                {
                    s = System.Convert.ToInt32( i.Cells["ID_Category"].Value.ToString() );
                    adManaCategory.Del(s);
                }
                ReloadCategory();
            }
            else
            {
                DialogResult result = NetMessageBox.Show("Bạn Chưa Chọn !!!",
              "Important Message");
                return;
            }
        }

        private void btnUpCTR_Click(object sender, EventArgs e)
        {
            if (dgvShowCTR.SelectedRows.Count == 1)
            {
                int s = System.Convert.ToInt32( dgvShowCTR.SelectedRows[0].Cells["ID_Category"].Value );
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
            if (tbCategory.SelectedIndex == 0)
            {
                if (s == "All")
                {
                    list = adManaCategory.Search(txt, SearchAcoountEnum.All);
                }
                else if (s == "ID_Category")
                {
                    list = adManaCategory.Search(txt, SearchAcoountEnum.Id);
                }
                else list = adManaCategory.Search(txt, SearchAcoountEnum.Name);
                ReloadCategory(list);
            }
            else
            {
                if (s == "All")
                {
                    list = adUnit.Search(txt, SearchAcoountEnum.All);
                }
                else if (s == "ID_Unit")
                {
                    list = adUnit.Search(txt, SearchAcoountEnum.Id);
                }
                else list = adUnit.Search(txt, SearchAcoountEnum.Name);
                ReloadUnit(list);
            }

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            ReloadCategory();
        }

        private void btnUnitAdd_Click(object sender, EventArgs e)
        {
            AddUpUnit_Form addUpUnit_Form = new AddUpUnit_Form(-1);
            addUpUnit_Form.action = ReloadUnit;
            addUpUnit_Form.Show();
        }

        private void btnUnitUpdate_Click(object sender, EventArgs e)
        {
            if (dgvUnit.SelectedRows.Count == 1)
            {
                int s = System.Convert.ToInt32(dgvUnit.SelectedRows[0].Cells["ID_Unit"].Value);
                AddUpUnit_Form addUpUnit_Form = new AddUpUnit_Form(s);
                addUpUnit_Form.action = ReloadUnit;
                addUpUnit_Form.Show();
            }
        }

        private void btnDeleteUnit_Click(object sender, EventArgs e)
        {
            int s;
            if (dgvUnit.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in dgvUnit.SelectedRows)
                {
                    s = System.Convert.ToInt32(i.Cells["ID_Unit"].Value.ToString());
                    adUnit.DelUnit(s);
                }
                ReloadCategory();
            }
            else
            {
                DialogResult result = NetMessageBox.Show("Bạn Chưa Chọn !!!",
              "Important Message");
                return;
            }
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
            Create_CBB();

        }

     
    }
}
