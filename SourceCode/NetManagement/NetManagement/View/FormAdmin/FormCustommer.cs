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
    public partial class FormCustommer : Form
    {
        AdminBLL_Cus adMana = new AdminBLL_Cus();
        AdminBLL_UseCPHis adUCPH = new AdminBLL_UseCPHis();
        AdminBLL_OrderHis adOrHis = new AdminBLL_OrderHis();
        public FormCustommer()
        {
            InitializeComponent();
            ShowAll_Mana();
            CreateCBB();
        }
        public void ShowAll_Mana()
        {
            
            var l = adMana.GetAll().Select(p => 
            new { 
                p.ID_User, 
               // p.FullNameCus, 
                p.DateOfBirth, 
                p.Phone,
                p.Email, 
                p.Day_Create, 
                p.Gender,
                p.Money,
                //p.Employee.FullNameEm
            });
            dgvShowCus.DataSource = l.ToList();
        }
        public void ShowAll_His()
        {
            var l = adUCPH.GetAll().Select(p => 
            new { 
                p.ID_HistoryUseComputer, 
               // p.Customer.FullNameCus, 
                p.ID_Computer, 
                p._LogIn, 
                p._LogOut, 
                p.HourUsed 
            });
            dgvHUse.DataSource = l.ToList();
        }
        public void ShowAll_OrderHis(List<OrderDetail> l)
        {
            var list = l.Select(p => new {p.ID_OrderDetail, //p.Order.Customer.FullNameCus,
                p.Product.NameProduct ,p.Product.Category.CategoryName,p.Description,p.Quality});
            adOrHis = new AdminBLL_OrderHis();
            var data = list.ToList();
            dgvOrHis.DataSource = data;
        }
        public void CreateCBB()
        {
            cbbSort.Items.Clear();
            cbbSearch.Items.Clear();
            cbbSearch.Items.Add("All");
            cbbSearch.Items.Add("ID_User");
            cbbSearch.Items.Add("Name");
            cbbSort.Items.Add("Name");
            cbbSort.Items.Add("ID_User");
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormCusAdd_Up f = new FormCusAdd_Up("");
            f.d = new FormCusAdd_Up.MyDel(ShowAll_Mana);
            f.Show();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (dgvShowCus.SelectedRows.Count == 1)
            {
                string s = dgvShowCus.SelectedRows[0].Cells["ID_User"].Value.ToString();
                FormCusAdd_Up f = new FormCusAdd_Up(s);
                f.d = new FormCusAdd_Up.MyDel(ShowAll_Mana);
                f.Show();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string txt = txtSearch.Text;
            string s = cbbSearch.Text;

            if (tbMana.SelectedIndex == 0)
            {
                foreach (Customer i in adMana.GetAll())
                {
                    //i.FullNameCus = i.FirstName + " " + i.LastName;
                    //i.Employee.FullNameEm = i.Employee.FirstName + " " + i.Employee.LastName;
                }
                var l = adMana.Search(s, txt).Select(p => 
                new { 
                    p.ID_User, 
                   // p.FullNameCus, 
                    p.DateOfBirth, 
                    p.Phone, 
                    p.Email, 
                    p.Day_Create, 
                    p.Gender,
                    p.Money,
                   // p.Employee.FullNameEm 
                });
                dgvShowCus.DataSource = l.ToList();
            }
            else if (tbMana.SelectedIndex == 1)
            {
                var l = adUCPH.Search(s, txt).Select(p => 
                new { 
                    p.ID_HistoryUseComputer, 
                  //  p.Customer.FullNameCus, 
                    p.ID_Computer, 
                    p._LogIn, 
                    p._LogOut, 
                    p.HourUsed 
                });
                dgvHUse.DataSource = l.ToList();
            }
            else if (tbMana.SelectedIndex == 2)
            {
                if(cbbTypeView.SelectedItem.ToString() == "All")
                {
                    var l = adOrHis.Search(s, txt);
                    ShowAll_OrderHis(l.ToList());
                }
                else if (cbbTypeView.SelectedItem.ToString() == "Do An")
                {
                    var l = adOrHis.Search(s, txt).Where(p => p.Product.Category.CategoryName == "Do An");
                    ShowAll_OrderHis(l.ToList());
                }
                else if (cbbTypeView.SelectedItem.ToString() == "Do Uong")
                {
                    var l = adOrHis.Search(s, txt).Where(p => p.Product.Category.CategoryName == "Do Uong");
                    ShowAll_OrderHis(l.ToList());
                }
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (tbMana.SelectedIndex == 0)
            {
                var l = adMana.Sort(cbbSort.Text).Select(p => 
                new { 
                    p.ID_User, 
              //     p.FullNameCus, 
                    p.DateOfBirth, 
                    p.Phone, 
                    p.Email, 
                    p.Day_Create, 
                    p.Gender,
                    p.Money,
                //    p.Employee.FullNameEm 
                });
                
                dgvShowCus.DataSource = l.ToList();
            }
            else if (tbMana.SelectedIndex == 1)
            {
                var l = adUCPH.Sort(cbbSort.Text).Select(p => 
                new { 
                    p.ID_HistoryUseComputer, 
                 //   p.Customer.FullNameCus, 
                    p.ID_Computer, p._LogIn, 
                    p._LogOut, 
                    p.HourUsed 
                });
                dgvHUse.DataSource = l.ToList();
            }
            else if (tbMana.SelectedIndex == 2)
            {
                var l = adOrHis.Sort(cbbSort.Text).Select(p => 
                new { 
                    p.ID_OrderDetail, 
                   // p.Order.Customer.FullNameCus, 
                    p.Product.NameProduct, 
                    p.Product.Category.CategoryName, 
                    //p._Description, p.Quality 
                });

                dgvOrHis.DataSource = l.ToList();
            }
        }

        private void tbMana_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbMana.SelectedIndex == 0)
            {
                CreateCBB();

                ShowAll_Mana();
            }
            else if (tbMana.SelectedIndex == 1)
            {
                cbbSearch.Items.Clear();
                cbbSort.Items.Clear();
                cbbSearch.Items.Add("All");
                cbbSearch.Items.Add("ID_History");
                cbbSearch.Items.Add("Name");
                cbbSearch.Items.Add("ID_Customer");
                cbbSort.Items.Add("ID_Computer");
                cbbSort.Items.Add("ID_History");
                cbbSort.Items.Add("Name");

                ShowAll_His();
            }
            else if (tbMana.SelectedIndex == 2)
            {
                cbbSearch.Items.Clear();
                cbbSort.Items.Clear();
                cbbTypeView.Items.Clear();
                cbbSearch.Items.Add("Name Customer");
                cbbSearch.Items.Add("Name Product");
                cbbSort.Items.Add("Quality");
                cbbSort.Items.Add("Name");
                cbbTypeView.Items.Add("All");
                foreach (string s in GetListCBB())
                {
                    cbbTypeView.Items.Add(s);
                }
                cbbTypeView.SelectedIndex = 0;
                List <OrderDetail>l = adOrHis.GetAll().ToList();
                ShowAll_OrderHis(l);
            }
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
                List<OrderDetail> l = adOrHis.GetAll().ToList();
                ShowAll_OrderHis(l);
            }
            else if (cbbTypeView.SelectedItem.ToString() == "Do An")
            {
                List<OrderDetail> l = adOrHis.GetAll().Where(p => p.Product.Category.CategoryName == "Do An").ToList();
                ShowAll_OrderHis(l);
            }
            else if (cbbTypeView.SelectedItem.ToString() == "Nuoc Uong")
            {
                List<OrderDetail> l = adOrHis.GetAll().Where(p => p.Product.Category.CategoryName == "Nuoc Uong").ToList();
                ShowAll_OrderHis(l);
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
            ShowAll_His();
        }
    }
}
