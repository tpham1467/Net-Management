using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetManagement.Model;
using NetManagement.BLL;

namespace NetManagement.View.FormAdmin
{
    public partial class FormCusAdd_Up : Form
    {
        public delegate void MyDel();
        public MyDel d;
        AdminBLL_Cus adBLLCus = new AdminBLL_Cus();
        AdminBLL_Em adBLLEm = new AdminBLL_Em();
        string id;
        public FormCusAdd_Up(string m)
        {
            id = m;
            InitializeComponent();
            GUI();
            CreateCBB();
        }
        public string stri;
        public List<SetCBB> SetCBBs = new List<SetCBB>();
        DateTime dt;
        public void CreateCBB()
        {
            foreach (Employee em in adBLLEm.GetAll())
            {
                //cbbEm.Items.Add(new SetCBB { id = em.ID_User, name = em.FullNameEm });
                //SetCBBs.Add(new SetCBB { id = em.ID_User, name = em.FullNameEm });
            }
        }
        public string str;
        void GUI()
        {

            if (id != "")
            {
                int i = Convert.ToInt32(id);
                Customer s = adBLLCus.GetCusById(i);
               // str = s.Employee.ID_User + " - " + s.Employee.FullNameEm;
                txtFirstN.Text = s.FirstName.ToString();
                txtLastN.Text = s.LastName.ToString();
                txtPhone.Text = s.Phone.ToString();
                txtEmail.Text = s.Email.ToString();
                dtpDOB.Text = s.DateOfBirth.ToLongDateString();
                txtMoney.Text = s.Money.ToString();
                cbbEm.Text = str;
                if (s.Gender == true) rdMale.Checked = true;
                else rdFemale.Checked = true;
                stri = s.ID_User.ToString();
                dt = s.Day_Create;
            }
        }

        private void btnSend_Click_1(object sender, EventArgs e)
        {
            bool check;
            if (rdMale.Checked) check = true;
            else check = false;
            Customer cus = adBLLCus.CreateCus();
            cus.FirstName = txtFirstN.Text;
            cus.LastName = txtLastN.Text;
            cus.Phone = txtPhone.Text;
            cus.Email = txtEmail.Text;
            cus.DateOfBirth = dtpDOB.Value;
            cus.Money = Convert.ToInt32(txtMoney.Text);
            cus.Gender = check;
            int ktra = 0;
            foreach (SetCBB scbb in SetCBBs)
            {
                if (scbb.ToString() == cbbEm.Text)
                {
                    ktra++;
                    cus.ID_Employee = scbb.id;
                    break;
                }
                
            }
            if(ktra == 0)
            {
                cus.ID_Employee = (cbbEm.SelectedItem as SetCBB).id;
            }
            adBLLCus.UpdateAdd(stri, cus,dt);
            d();
            this.Dispose();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cbbEm_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cus.ID_Employee = (cbbEm.SelectedItem as SetCBB).id;
        }
    }
}
