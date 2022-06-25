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

namespace NetManagement.View.FormAdmin
{
    public partial class FormAddProductExport : Form
    {
        public delegate void MyDel(List<object> data = null);
        public MyDel d;
        AdminBLL_Inventory adminBLL_Product = new AdminBLL_Inventory();
        string id;
        int check;

        public FormAddProductExport(string m, int k)
        {
            id = m;
            check = k;
            InitializeComponent();
            GUI();
            CreateCBB();
        }

        string stri;
        public List<SetCBB> SetCBBs = new List<SetCBB>();
        DateTime dt;
        public void CreateCBB()
        {
            cbbProduct.Items.Add("Sản phẩm mới");
            foreach (Inventory i in adminBLL_Product.GetAll())
            {
                cbbProduct.Items.Add(new SetCBB { id = i.Product.ID_Product, name = i.Product.NameProduct });
                SetCBBs.Add(new SetCBB { id = i.Product.ID_Product, name = i.Product.NameProduct });
            }
        }
        public string str;

        void GUI()
        {
            if (id != "")
            {
                int i = Convert.ToInt32(id);
                Inventory s = adminBLL_Product.GetProductById(i);
                //txtIDPro.Text = s.ID_Product.ToString();
                txtAmount.Text = s.Amount.ToString();
                str = s.Product.ID_Product + " - " + s.Product.NameProduct;
                cbbProduct.Text = str;
                txtImport.Text = s.ImportPrices.ToString();
                txtSalePr.Text = s.SalePrice.ToString();
                dtpIm.Text = s.ImportDay.ToLongDateString();
                dtpEx.Text = s.ExpiryDate.ToLongDateString();
                stri = s.ID_Inventory.ToString();
                if (check == 0)
                {
                    txtImport.Enabled = false;
                    txtSalePr.Enabled = false;
                }
                else
                {
                    dtpEx.Enabled = false;
                    dtpIm.Enabled = false;
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Inventory pro = adminBLL_Product.CreateIn();
            //ID_Product = Convert.ToInt32(txtIDPro.Text),
            pro.ImportPrices = Convert.ToInt32(txtImport.Text);
            pro.SalePrice = Convert.ToInt32(txtSalePr.Text);
            pro.ImportDay = dtpIm.Value;
            pro.ExpiryDate = dtpEx.Value;
            pro.Amount = Convert.ToInt32(txtAmount.Text);
            int ktra = 0;
            foreach (SetCBB scbb in SetCBBs)
            {
                if (scbb.ToString() == cbbProduct.Text)
                {
                    ktra++;
                    pro.ID_Product = scbb.id;
                    break;
                }

            }
            if (ktra == 0)
            {
                pro.ID_Product = (cbbProduct.SelectedItem as SetCBB).id;
            }
            adminBLL_Product.UpdateAdd(stri, pro);
            d();
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
