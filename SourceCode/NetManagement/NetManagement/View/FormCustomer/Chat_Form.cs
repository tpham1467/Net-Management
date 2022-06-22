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
namespace NetManagement.View.FormCustomer
{
    public partial class Chat_Form : Form
    {
        private BLLChat _BLLChat = new BLLChat();
        private int Id_Computer;
        private static bool statusTask ;
        public Chat_Form(int idComputer)
        {
            Id_Computer = idComputer;
            InitializeComponent();
            foreach (var i in _BLLChat.GetAllMessage(Id_Computer).ToList())
            {
                if (i.FromEmployee == true)
                    SetText(i._Message);
                else
                {
                    listBox1.Items.Add("Bạn  : " + i._Message);
                    listBox1.Items.Add("                              ");
                    listBox1.Items.Add("                              ");
                }
            }
            Task t = UpdateMess();
           // this. += btnClose_Click;
        }
        delegate void SetTextCallback(string tex);
        private void SetText(string text)
        {

            if (this.listBox1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.listBox1.Items.Add("Admin :" + text);
                listBox1.Items.Add("                              ");
                listBox1.Items.Add("                              ");
            }
        }
        public async Task UpdateMess()
        {
            Task t = new Task(() =>
            {
                statusTask = false;
                int old = _BLLChat.GetAllMessageAdmin(Id_Computer).ToList().Count ;
                while (true)
                {
                    int cur = _BLLChat.GetAllMessageAdmin(Id_Computer).ToList().Count;
                    if (cur > old)
                    {
                        List<Model.Message> messages = _BLLChat.GetAllMessageAdmin(Id_Computer).Skip(old).ToList();
                        foreach(var i in messages)
                        {
                            SetText(i._Message);
                        }

                        old = cur;
                    }
                    if(statusTask == true)
                    {

                    }
                    Task.Delay(3000).Wait();
                }
            }
               );

            t.Start();
            await t;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (textBoxmess.Text == "") return;
            else
            {
       
                listBox1.Items.Add("Bạn  : " + textBoxmess.Text);
                listBox1.Items.Add("                              ");
                listBox1.Items.Add("                              ");
                _BLLChat.AddMess(textBoxmess.Text , Id_Computer);
                textBoxmess.Text = "";
                
            }
        }
    }
}
