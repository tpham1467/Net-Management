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

namespace NetManagement.View.FormAdmin
{
    public partial class AddUpProduct : Form
    { 

        public delegate void MyDel(List<object> data = null);
        public MyDel d;
        public int check;
        public int ID;
        BLL_Product adBllProduct = new BLL_Product();
        
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
            foreach (Product product in adBllProduct.GetAll())
            {
                cbbCategory.Items.Add(new SetCBB { id = product.ID_Category, name = product.Category.CategoryName});
                cbbUnit.Items.Add(new SetCBB { id = product.ID_Unit, name = product.Unit.NameUnit});
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
            product.ID_Product = ID;
            product.NameProduct = txtNameProduct.Text;
            product.ID_Unit = (cbbUnit.SelectedItem as SetCBB).id;
            product.ID_Category = (cbbCategory.SelectedItem as SetCBB).id;
            adBllProduct.UpdateAdd(product,check);
            d();
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
