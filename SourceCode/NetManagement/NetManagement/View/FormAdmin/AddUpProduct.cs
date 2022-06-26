using NetManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetManagement.BLL.BLLAdmin;
using NetManagement.BLL;

namespace NetManagement.View.FormAdmin
{
    public partial class AddUpProduct : Form
    { 

        public delegate void MyDel(List<object> data = null);
        public MyDel d;
        public int check;
        public int ID;
        BLL_Product adBllProduct = new BLL_Product();
        AdminBLL_Category adBllCategory = new AdminBLL_Category();
        BLL_Unit adBllUnit = new BLL_Unit();

        public AddUpProduct(int m, int id)
        {
            check = m;
            ID = id;
            InitializeComponent();
            CreateCBB();
            Gui();

        }
        DateTime dt;
        public void CreateCBB()
        {
            
            foreach(string s in adBllCategory.GetAll().Select(p=>p.CategoryName).Distinct().ToList())
            {
                cbbCategory.Items.Add(s);
            }
            foreach (string s in adBllUnit.GetAll().Select(p => p.NameUnit).Distinct().ToList())
            {
                cbbUnit.Items.Add(s);
            }
        }
        public void Gui()
        {
            if(ID != -1)
            {
                Product product = adBllProduct.GetProductById(ID);
                txtNameProduct.Text = product.NameProduct;
                cbbCategory.Text =product.ID_Category+ " - "+ product.Category.CategoryName;
                cbbUnit.Text = product.ID_Unit + " - " + product.Unit.NameUnit;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Product product = adBllProduct.Create();
            
            product.NameProduct = txtNameProduct.Text;
            product.ID_Unit = (cbbUnit.SelectedItem as SetCBB).id;

            product.ID_Category = (cbbCategory.SelectedItem as SetCBB).id;
            if(check == -1)
            {
                adBllProduct.Add(product);
            }
            else
            {
                product.ID_Product = ID;
                adBllProduct.UpDate(product);
            }
            d();
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
