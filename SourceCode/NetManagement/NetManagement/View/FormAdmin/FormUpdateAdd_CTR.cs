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
    public partial class FormUpdateAdd_CTR : Form
    {
        public delegate void MyDel(List<object> data = null);
        public MyDel d;
        AdminBLL_Category adBLL = new AdminBLL_Category();
        string id;
        int k;
        public FormUpdateAdd_CTR(string m)
        {
            id = m;
            InitializeComponent();
            GUI();
        }
        void GUI()
        {
            if (id != "")
            {
                int i = Convert.ToInt32(id);
                Category s = adBLL.GetCTRById(i);
                txtNameCTR.Text = s.CategoryName.ToString();
                txtDesCTR.Text = s.Description.ToString();
                k = s.ID_Category;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Category ctr = new Category
            {
                CategoryName = txtNameCTR.Text,
                Description = txtDesCTR.Text,
            };
            adBLL.UpdateAdd(ctr, k);
            d();
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
