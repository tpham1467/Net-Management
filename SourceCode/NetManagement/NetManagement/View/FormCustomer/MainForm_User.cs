using NetManagement.View.FormEmployee;
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
using NetManagement.Helper;
namespace NetManagement.View.FormCustomer
{
    public partial class MainForm_User : Form
    {
        private int Id;
        private Form currentFormBody;
        private BLLDisplayinfor _BLLDisplayinfor = new BLLDisplayinfor();
        private BLLHandleStatus _BLLHandleStatus = new BLLHandleStatus();
        public  MainForm_User(int _id)
        {
            Id = _id;
            InitializeComponent();
            textBoxremaining.Enabled = false; textBoxused.Enabled = false; textBoxprices.Enabled = false;
            Task t = DisplayMoney();
        }
       
        delegate void SetTextCallback(string text,string text2);
        private void SetText(string text, string text2)
        {
           
            if (this.textBoxremaining.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text  , text2});
            }
            else
            {
                this.textBoxremaining.Text = text;
                lock(textBoxused)
                {
                  textBoxused.Text = text2;
                }
            }
        }
        public async void DisPlay(int s1 , int s2)
        {
            Task t = new Task
                (() =>
                {
                    for(int i=0;i<10;i++)
                    {
                        SetText(Helper.Convert.ConvertMenyToHour(s1), Helper.Convert.ConvertMenyToHour(s2));
                        Task.Delay(1000).Wait();
                        s1 -= 2; s2 -= 2;
                    }
                });
            t.Start();
            await t;


        }
        delegate void Hett();
        public void HetTien()
        {
            if (this.textBoxremaining.InvokeRequired)
            {
                Hett d = new Hett(HetTien);
                this.Invoke(d, new object[] { });
            }
            else
            {
                btnLoutout_Click(new object(), new EventArgs());
            }
           
        }
        public async Task DisplayMoney()
       {
            
            Task t = new Task(() =>
            {
                int remaining = _BLLDisplayinfor.GetCustomerById(Id).Money;
                int timeused = 0;
             
                while (true)
                {
                     
                    if(remaining!=_BLLDisplayinfor.GetCustomerById(Id).Money)
                    {
                        remaining = _BLLDisplayinfor.GetCustomerById(Id).Money;
                    }
                    remaining -= 2;
                    timeused += 2;
                    if (remaining <= 0||_BLLHandleStatus.CheckLock(Id) == true)
                    {
                        HetTien();
                        break;
                    }
                    lock(textBoxremaining)
                    {

                        SetText(Helper.Convert.ConvertMenyToHour( remaining ),Helper.Convert.ConvertMenyToHour( timeused ));
                    }
                    _BLLDisplayinfor.UpDate(remaining,Id);
                    Task.Delay(1000).Wait();
                   
                }
            }
                );
            t.Start();
            await t;
            //btnLoutout_Click(new object(), new EventArgs());
        }
        private void OpenFormBody(Form bodyForm)
        {
            if (currentFormBody != null)
            {
                currentFormBody.Close();
            }
            currentFormBody = bodyForm;
            bodyForm.TopLevel = false;
            bodyForm.FormBorderStyle = FormBorderStyle.None;
            bodyForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(bodyForm);
            panel_body.Tag = bodyForm;
            bodyForm.BringToFront();
            bodyForm.Show();
        }

        private void btnPersonalInfor_Click(object sender, EventArgs e)
        {
            OpenFormBody(new PersonalInfor_Form(Id));
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            OpenFormBody(new Chat_Form());
        }

        private  void btnLoutout_Click(object sender, EventArgs e)
        {
           
               Login_Form f = new Login_Form();
               f.Show();

               this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFormBody(new OrderCust_Form());
        }
    }
}
