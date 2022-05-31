using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetManagement.BLL.BLLCustormer;
using NetManagement.Model;
namespace NetManagement.View.FormCustomer
{
    public partial class PersonalInfor_Form : Form
    {
        private BLLDisplayinfor _BLLDisplayinfor = new BLLDisplayinfor();
        private int Id;
        public PersonalInfor_Form(int _id)
        {
            Id = _id;
            InitializeComponent();
            Customer customer = _BLLDisplayinfor.GetCustomerById(Id);
            LoadInfor(customer);
        }
        public void LoadInfor(Customer customer)
        {
            
            textBoxFirstName.Text = customer.FirstName;
            textBoxLatsName.Text = customer.LastName;
            textBoxPhone.Text = customer.Phone;
            textBoxDateofbirth.Text = customer.DateOfBirth.ToString();
            textBoxEmail.Text = customer.Email;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer
            {
                ID_User = Id ,
                Phone = textBoxPhone.Text,
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLatsName.Text,
                DateOfBirth = Convert.ToDateTime(textBoxDateofbirth.Text),
                Email = textBoxEmail.Text
            };
            _BLLDisplayinfor.UpDate(customer);
            LoadInfor(customer);
        }

       
    }
}
