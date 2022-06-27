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
using NetManagement.Model;
using NetManagement.Helper;
namespace NetManagement.View.FormAdmin
{
    public partial class FormUpdateAdd_CTR : Form
    {
        public Action<List<object>> action;
        AdminBLL_Category adBLL = new AdminBLL_Category();
        int  id;
        public FormUpdateAdd_CTR(int m)
        {
            id = m;
            this.AutoScaleMode = AutoScaleMode.None;
            InitializeComponent();
            GUI();
        }
        void GUI()
        {
            if (id != -1)
            {
            
                Category s = adBLL.GetCTRById(id);
                txtNameCTR.Text = s.CategoryName;
                txtDesCTR.Text = s.Description;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Category ctr = adBLL.Create();

                ctr.CategoryName = txtNameCTR.Text == "" ? throw new Exception("Bạn Chưa Nhập Tên Danh Mục") : txtNameCTR.Text;
                ctr.Description = txtDesCTR.Text == "" ? throw new Exception("Bạn Chưa Nhập Mô Tả Cho Danh Mục") : txtDesCTR.Text;
                
                try
                {
                    adBLL.UpdateAdd(ctr, id);
                }
                catch
                {
                    // throw new Exception("Opp !!! . Xin lỗi Bạn hiện hệ thống không thể hoạt động . Vui Lòng Thử Lại");
                    throw;
                }
            }
            catch (Exception mess)
            {
                DialogResult result = NetMessageBox.Show(mess.Message,
                "Important Message");
                return;
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
