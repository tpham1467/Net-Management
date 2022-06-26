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

        public Action<List<object>> action;
        public int ID;
        private int indexccbcatory;
        private int indexccbunit;
        private int idcatory;
        private int idunit;
        BLL_Product adBllProduct = new BLL_Product();
        AdminBLL_Category adBllCategory = new AdminBLL_Category();
        BLL_Unit adBllUnit = new BLL_Unit();

        public AddUpProduct( int id)
        {
            ID = id;
            if(ID != -1)
            {
                Product product = adBllProduct.GetProductById(ID);
                idcatory = product.ID_Category;
                idunit = product.ID_Unit;
            }
            this.AutoScaleMode = AutoScaleMode.None;
            InitializeComponent();
            CreateCBB();
            Gui();

        }
        public void CreateCBB()
        {
            int j = 0;
            foreach(var s in adBllCategory.GetAll())
            {
                if (ID != -1)
                {
                    if (idcatory == s.ID_Category) indexccbunit = j;
                }
                cbbCategory.Items.Add(new SetCBB {id = s.ID_Category , name = s.CategoryName });
                j++;
            }
            j = 0;
            foreach (var s in adBllUnit.GetAll())
            {
                if(ID != -1)
                {
                    if (idunit == s.ID_Unit) indexccbunit = j;
                }
                cbbUnit.Items.Add(new SetCBB { id = s.ID_Unit, name = s.NameUnit });
                j++;
            }
        }
        public void Gui()
        {
            if(ID != -1)
            {
                Product product = adBllProduct.GetProductById(ID);
                txtNameProduct.Text = product.NameProduct;
                cbbCategory.SelectedIndex = indexccbcatory;
                cbbUnit.SelectedIndex = indexccbunit;
            }
            else
            {
                cbbCategory.SelectedIndex = 0;
                cbbUnit.SelectedIndex = 0;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Product product = adBllProduct.Create();
            
            product.NameProduct = txtNameProduct.Text;
            product.ID_Unit = (cbbUnit.SelectedItem as SetCBB).id;

            product.ID_Category = (cbbCategory.SelectedItem as SetCBB).id;
            if(ID == -1)
            {
                adBllProduct.Add(product);
            }
            else
            {
                product.ID_Product = ID;
                adBllProduct.UpDate(product);
            }
            action(null);
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

   
    }
}
