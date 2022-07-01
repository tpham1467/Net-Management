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
    public partial class AddUpUnit_Form : Form
    {
        public Action<List<object>> action;
        public int ID;
        BLL_Unit BLL_Unit = new BLL_Unit();
        public AddUpUnit_Form(int id)
        {
            ID = id;
           // this.AutoScaleMode = AutoScaleMode.None;
            InitializeComponent();
            Gui();
        }
        public void Gui()
        {
            if(ID != -1)
            {
                
                Unit unit = BLL_Unit.GetbyID(ID);
                txtNameUnit.Text = unit.NameUnit;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Unit unit = BLL_Unit.Create();
            try
            {
                unit.NameUnit = txtNameUnit.Text =="" ? throw new Exception("Bạn Chưa Nhập Tên Đơn Vị"):txtNameUnit.Text;
                try
                {
                    BLL_Unit.UpdateAdd(ID, unit);
                }
                catch
                {
                    //throw new Exception("Opp !!! . Xin lỗi Bạn hiện hệ thống không thể hoạt động . Vui Lòng Thử Lại");
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
