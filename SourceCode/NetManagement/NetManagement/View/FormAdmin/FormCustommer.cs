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
using NetManagement.DTO;

namespace NetManagement.View.FormAdmin
{
    public partial class FormCustommer : Form
    {
        AdminBLL_Cus adMana = new AdminBLL_Cus();
        AdminBLL_UseCPHis adUCPH = new AdminBLL_UseCPHis();
        AdminBLL_OrderHis adOrHis = new AdminBLL_OrderHis();
        public FormCustommer()
        {
            this.AutoScaleMode = AutoScaleMode.None;
            InitializeComponent();
            ReloadCus();
            CreateCBB();
        }

        public void ReloadCus(List<object> data = null)
        {
            if (data == null) dgvShowCus.DataSource = adMana.Filter();
            else dgvShowCus.DataSource = data;
        }
        public void ReloadHisUsed(List<object> data = null)
        {
            if (data == null) dgvHUse.DataSource = adUCPH.Filter();
            else dgvHUse.DataSource = data.ToList();
        }
        public void ReloadOrderHis(List<object> data = null)
        {
            if (data == null) dgvOrHis.DataSource = adOrHis.Filter();
            else dgvOrHis.DataSource = data.ToList();
        }
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormCusAdd_Up f = new FormCusAdd_Up(-1,-1);
            f.d = new FormCusAdd_Up.MyDel(ReloadCus);
            f.Show();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (dgvShowCus.SelectedRows.Count == 1)
            {
                int s = Convert.ToInt32(dgvShowCus.SelectedRows[0].Cells["ID_User"].Value);
                FormCusAdd_Up f = new FormCusAdd_Up(1,s);
                f.d = new FormCusAdd_Up.MyDel(ReloadCus);
                f.Show();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string txt = txtSearch.Text;
            string s = cbbSearch.Text;
            List<object> list = new List<object>();
            if (tbMana.SelectedIndex == 0)
            {
                if (s == "All")
                {
                    list = adMana.Search(txt, SearchAcoountEnum.All);
                }
                else if(s== "ID_User")
                {
                    list = adMana.Search(txt, SearchAcoountEnum.Id);
                }
                else
                {
                    list = adMana.Search(txt, SearchAcoountEnum.Name);
                }
                ReloadCus(list);
            }
            
            else if (tbMana.SelectedIndex == 1)
            {
                if (s == "All")
                {
                    list = adUCPH.Search(txt, SearchAcoountEnum.All);
                }
                else
                {
                    list = adUCPH.Search(txt, SearchAcoountEnum.Name,s);
                }
                ReloadHisUsed(list);
            }
            else if (tbMana.SelectedIndex == 2)
            {
                list = adOrHis.Search(txt,s);
                ReloadOrderHis(list);
            }

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            SortEnum sort = new SortEnum();
            if (tbMana.SelectedIndex == 0)
            {
                
                if ((cbbSortby.SelectedItem as string) == "Asc")
                {
                    sort = SortEnum.Asc;
                }
                else
                {
                    sort = SortEnum.Desc;
                }
                dgvShowCus.DataSource = adMana.Sort(sort, (cbbSortProperty.SelectedItem as string));
            }
            else if (tbMana.SelectedIndex == 1)
            {
                if ((cbbSortby.SelectedItem as string) == "Asc")
                {
                    sort = SortEnum.Asc;
                }
                else
                {
                    sort = SortEnum.Desc;
                }
                dgvHUse.DataSource = adUCPH.Sort(sort, (cbbSortProperty.SelectedItem as string));
            }
            else if (tbMana.SelectedIndex == 2)
            {
                if ((cbbSortby.SelectedItem as string) == "Asc")
                {
                    sort = SortEnum.Asc;
                }
                else
                {
                    sort = SortEnum.Desc;
                }
                dgvOrHis.DataSource = adOrHis.Sort(sort, (cbbSortProperty.SelectedItem as string));
            }
        }

        public void CreateCBB()
        {
            cbbSearch.Items.Clear();
            cbbSearch.Items.Add("All");
            cbbSearch.Items.Add("Name Customer");
            cbbSortProperty.Items.Clear();
            cbbSortProperty.Items.Add("Name Customer");
            if (tbMana.SelectedIndex == 0)
            {
                cbbSearch.Items.Add("ID_User");
                cbbSortProperty.Items.Add("ID_User");
                ReloadCus();
            }
            else if (tbMana.SelectedIndex == 1)
            {

                cbbSearch.Items.Add("Name PC");
                cbbSortProperty.Items.Add("ID_Computer");

                ReloadHisUsed();
            }
            else if (tbMana.SelectedIndex == 2)
            {
                cbbTypeView.Items.Clear();
                cbbSearch.Items.Add("Name Product");
                cbbSortProperty.Items.Add("Quality");
                cbbTypeView.Items.Add("All");
                foreach (string s in GetListCBB())
                {
                    cbbTypeView.Items.Add(s);
                }
                cbbTypeView.SelectedIndex = 0;
                ReloadOrderHis();
            }
        }

        private void tbMana_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            cbbSearch.Text = "";
            cbbSortby.Text = "";
            cbbSortProperty.Text = "";
            CreateCBB();
        }
        public List<string> GetListCBB()
        {
            List<string> list = new List<string>();
            list = adOrHis.GetAll().Select(p =>p.Product.Category.CategoryName).Distinct().ToList();
            return list;
        }

        private void cbbTypeView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTypeView.SelectedItem.ToString() == "All")
            {
                ReloadOrderHis();
            }
            else if (cbbTypeView.SelectedItem.ToString() == "Do An")
            {
                dgvOrHis.DataSource = adOrHis.Filter(adOrHis.GetAll().
                    Where(p => p.Product.Category.CategoryName == "Do An"));
            }
            else if (cbbTypeView.SelectedItem.ToString() == "Iteam")
            {
                dgvOrHis.DataSource = adOrHis.Filter(adOrHis.GetAll().
                    Where(p => p.Product.Category.CategoryName == "Iteam"));
            }
        }

        private void btnDel_Click_1(object sender, EventArgs e)
        {
            if (tbMana.SelectedIndex == 1)
            {
                string s;
                foreach (DataGridViewRow i in dgvHUse.SelectedRows)
                {
                    s = i.Cells["ID_HistoryUseComputer"].Value.ToString();
                    adUCPH.DelHis(s);
                }
            }
            ReloadOrderHis();
        }
    }
}
