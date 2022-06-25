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
        AdminBLL_Inventory adminBLL_ExProduct = new AdminBLL_Inventory();
        int id;
        int check;

        public FormAddProductExport(int m,int Check)
        {
            id = m;
            check = Check;
            InitializeComponent();
            GUI();
            CreateCBB();
        }

        //string stri;
        public List<SetCBB> SetCBBs = new List<SetCBB>();
        DateTime dt;
        public void CreateCBB()
        {
            foreach (Inventory i in adminBLL_ExProduct.GetAll())
            {
                cbbProduct.Items.Add(new SetCBB { id = i.Product.ID_Product, name = i.Product.NameProduct });
                SetCBBs.Add(new SetCBB { id = i.Product.ID_Product, name = i.Product.NameProduct });
            }
        }
        public string str;

        void GUI()
        {
            if (id != -1)
            {
                int i = Convert.ToInt32(id);
                Inventory s = adminBLL_ExProduct.GetProductById(i);
                txtAmount.Text = s.Amount.ToString();
                cbbProduct.Text = s.Product.ID_Product + " - " + s.Product.NameProduct;
                txtImport.Text = s.ImportPrices.ToString();
                txtSalePr.Text = s.SalePrice.ToString();
                dtpIm.Text = s.ImportDay.ToLongDateString();
                dtpEx.Text = s.ExpiryDate.ToLongDateString();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Inventory pro = adminBLL_ExProduct.CreateIn();
            //pro.ID_Product = Convert.ToInt32(txtIDPro.Text),
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
            if(check == -1)
            {
                adminBLL_ExProduct.Add(pro);
            }
            else
            {
                pro.ID_Inventory = id;
                adminBLL_ExProduct.UpDate(pro);
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
