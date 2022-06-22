using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetManagement.BLL.BLLChat;
namespace NetManagement.View.FormEmployee
{
    public partial class Chat_Form : Form
    {
        private BLLChat _BLLChat = new BLLChat();
        private int Id_Computer;
        private  bool statusTask ;
        public Chat_Form(int idComputer)
        {
            Id_Computer = idComputer;
            InitializeComponent();
            this.Disposed += btnClose_Click;
            foreach (var i in _BLLChat.GetAllMessage(Id_Computer).ToList())
            {
                if (i.FromEmployee == false)
                {
                    this.listBox1.Items.Add("Customer :" + i._Message);
                    listBox1.Items.Add("                              ");
                    listBox1.Items.Add("                              ");
                }
                else
                {
                    listBox1.Items.Add("Bạn : " + i._Message);
                    listBox1.Items.Add("                              ");
                    listBox1.Items.Add("                              ");
                }
            }
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            Task t = UpdateMess();
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
                this.listBox1.Items.Add("Customer :" + text);
                listBox1.Items.Add("                              ");
                listBox1.Items.Add("                              ");
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
                listBox1.SelectedItems.Clear();
            }
        }
        public async Task UpdateMess()
        {
            Task t = new Task(() =>
            {
                statusTask = true;
                int old = _BLLChat.GetAllMessageUser(Id_Computer).ToList().Count ;
                while (statusTask)
                {
                    int cur = _BLLChat.GetAllMessageUser(Id_Computer).ToList().Count;
                    if (cur > old)
                    {
                        List<Model.Message> messages = _BLLChat.GetAllMessageUser(Id_Computer).Skip(old).ToList();
                        foreach(var i in messages)
                        {
                            SetText(i._Message);
                        }

                        old = cur;
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
           statusTask = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (textBoxmess.Text == "") return;
            else
            {
                listBox1.Items.Add("Bạn : " + textBoxmess.Text);
                listBox1.Items.Add("                              ");
                listBox1.Items.Add("                              ");
                _BLLChat.AddMessAdmin(textBoxmess.Text , Id_Computer);
                textBoxmess.Text = "";
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
                listBox1.SelectedItems.Clear();
                
            }
        }
    }
}
