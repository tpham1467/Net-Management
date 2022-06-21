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

            textBoxconformpass.UseSystemPasswordChar = true;
            textBoxoldpass.UseSystemPasswordChar = true;
            textBoxnewpass.UseSystemPasswordChar = true;
        }
        public void LoadInfor(Customer customer)
        {

            textBoxFirstName.Text = customer.FirstName;
            textBoxLatsName.Text = customer.LastName;
            textBoxPhone.Text = customer.Phone;
            dateTimePickerdob.Value = customer.DateOfBirth;
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
                Phone = textBoxPhone.Text,
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLatsName.Text,
                DateOfBirth = dateTimePickerdob.Value,
                Email = textBoxEmail.Text,
            };
            _BLLDisplayinfor.UpdateInfo(customer , Id);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonsavepass_Click(object sender, EventArgs e)
        {
            if (textBoxoldpass.Text == null || textBoxnewpass == null || textBoxconformpass.Text == null)
            {
                MessageBox.Show("Nhap Du Thong Tin");
            }
            else
            {
                if(textBoxconformpass.Text != textBoxnewpass.Text )
                {
                    MessageBox.Show("Mat Khau Khogn Giong Nhau");
                }
                else
                {
                    _BLLDisplayinfor.UpdatePassword(textBoxoldpass.Text, textBoxnewpass.Text, Id);
                    textBoxconformpass.Text = null;
                    textBoxnewpass.Text = null;
                    textBoxoldpass.Text = null;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           if(textBoxnewpass.UseSystemPasswordChar )
            {
                textBoxnewpass.UseSystemPasswordChar = false;
                textBoxconformpass.UseSystemPasswordChar = false;
                textBoxoldpass.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxconformpass.UseSystemPasswordChar = true;
                textBoxoldpass.UseSystemPasswordChar = true;
                textBoxnewpass.UseSystemPasswordChar = true;
            }
        }
    }
}
