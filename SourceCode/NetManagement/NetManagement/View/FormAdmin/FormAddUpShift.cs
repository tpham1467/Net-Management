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
    public partial class FormAddUpShift : Form
    {
        public delegate void MyDel();
        public MyDel d;
        AdminBLL_Em adBLLEm = new AdminBLL_Em();
        AdminBLL_Timekeeping adShi = new AdminBLL_Timekeeping();
        string id;

        public FormAddUpShift(string m)
        {
            id = m;
            InitializeComponent();
            CreateCBB();
            Gui();
        }

        string maso;
        string status;

        public void Gui()
        {
            if (id != "")
            {
                cbbStatus.Enabled = true;
                int i = Convert.ToInt32(id);
                Shift sh = adShi.GetShiById(i);
                dtpWD.Value = Convert.ToDateTime(sh.WorkedDate);
                //cbbNameE.Text = sh.Employee.ID_User + " - " + sh.Employee.FullNameEm;
                //mTbStartTime.Text = sh.ShiftStartTime;
                //mTbEndTime.Text = sh.ShiftEndTime;
                cbbStatus.Text = sh.StatusShift.Description;
                maso = sh.Employee.ID_User.ToString();
            }
            else
            {
                cbbStatus.Enabled = false;
                cbbStatus.Text = "";
            }
        }

        public void CreateCBB()
        {
            foreach (Employee em in adBLLEm.GetAll())
            {
              //  cbbNameE.Items.Add(new SetCBB { id = em.ID_User, name = em.FullNameEm });
            }
        }

        int iden;

        private void btnSend_Click(object sender, EventArgs e)
        {
            string str = dtpWD.Value.ToString("MM/dd/yyyy");

            foreach (Shift s in adShi.GetAll())
            {
                //if (s.Employee.FullNameEm == cbbNameE.Text)
                //{
                //    iden = s.Employee.ID_User;
                //}
            }
            Shift sh = adShi.Create();
            //sh.ShiftStartTime = mTbStartTime.Text;
            //sh.ShiftEndTime = mTbEndTime.Text;
            sh.ID_Employee = (cbbNameE.SelectedItem as SetCBB).id;
            sh.WorkedDate = Convert.ToDateTime(str);

            status = cbbStatus.Text;
            adShi.UpdateAdd(id, sh, status);
            d();
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
