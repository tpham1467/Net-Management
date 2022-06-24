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

namespace NetManagement.View.FormAdmin
{
    public partial class AddUpUnit_Form : Form
    {
        public delegate void MyDel(List<object> data = null);
        public MyDel d;
        public int check;
        public int ID;
        BLL_Unit BLL_Unit = new BLL_Unit();
        public AddUpUnit_Form(int m,int id)
        {
            check = m;
            ID = id;
            InitializeComponent();
            Gui();
        }
        public void Gui()
        {
            if(check == 1)
            {
                Unit unit = BLL_Unit.GetbyID(ID);
                txtNameUnit.Text = unit.NameUnit;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Unit unit = BLL_Unit.Create();
            unit.NameUnit = txtNameUnit.Text;
            unit.ID_Unit = ID;
            BLL_Unit.UpdateAdd(ID,unit);
            d();
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
