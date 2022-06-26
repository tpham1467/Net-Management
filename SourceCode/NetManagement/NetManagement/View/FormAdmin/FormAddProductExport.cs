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
using NetManagement.Model;
using NetManagement.BLL.BLLAdmin;
namespace NetManagement.View.FormAdmin
{
    public partial class FormAddProductExport : Form
    {
        public Action<List<object>> action;
        AdminBLL_Inventory adminBLL_ExProduct = new AdminBLL_Inventory();
        BLL_Product _BLL_Product = new BLL_Product();
        int id;
        private int indexcbbproduct;
        private int idproduct;
        public FormAddProductExport(int m)
        {
            id = m;
            if(id != -1)
            {
                Inventory s = adminBLL_ExProduct.GetProductById(id);
                idproduct = s.ID_Product;
            }
            this.AutoScaleMode = AutoScaleMode.None;
            InitializeComponent();
            CreateCBB();
            GUI();
            
        }

        public void CreateCBB()
        {
            int j = 0;
            foreach (Product i in _BLL_Product.GetAll())
            {
                if(id != -1)
                {
                    if(i.ID_Product == idproduct)
                    {
                        indexcbbproduct = j;
                    }
                }
                j++;
                cbbProduct.Items.Add(new SetCBB { id = i.ID_Product, name = i.NameProduct });
                
            }
        }

        void GUI()
        {
            if (id != -1)
            {
                int i = Convert.ToInt32(id);
                Inventory s = adminBLL_ExProduct.GetProductById(i);
                txtAmount.Text = s.Amount.ToString();
                cbbProduct.SelectedIndex = indexcbbproduct;
                txtImport.Text = s.ImportPrices.ToString();
                txtSalePr.Text = s.SalePrice.ToString();
                dtpIm.Text = s.ImportDay.ToLongDateString();
                dtpEx.Text = s.ExpiryDate.ToLongDateString();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Inventory pro = adminBLL_ExProduct.CreateIn();
            pro.ID_Product = (cbbProduct.SelectedItem as SetCBB).id;
            pro.ImportPrices = Convert.ToInt32(txtImport.Text);
            pro.SalePrice = Convert.ToInt32(txtSalePr.Text);
            pro.ImportDay = dtpIm.Value;
            pro.ExpiryDate = dtpEx.Value;
            pro.Amount = Convert.ToInt32(txtAmount.Text);
            if(id == -1)
            {
                adminBLL_ExProduct.Add(pro);
            }
            else
            {
                pro.ID_Inventory = id;
                adminBLL_ExProduct.UpDate(pro);
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
