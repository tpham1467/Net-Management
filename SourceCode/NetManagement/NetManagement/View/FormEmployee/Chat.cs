using NetManagement.BLL.BLLLogin;
using NetManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetManagement.View.FormEmployee
{
    public partial class Chat : Form
    {
        private BLLChoosePC _BLLChoosePC = new BLLChoosePC();
        public Chat()
        {
            InitializeComponent();
            List<PC> data = _BLLChoosePC.ConvertToPc();
            Create_Button(data);
            Loadevent();
        }
        private void pcb_click(Object Sender, EventArgs e)
        {
            PC pC = Sender as PC;
            if (_BLLChoosePC.CheckComputer(pC.IDMay))
            {
                MessageBox.Show("May Hien Tai Khong Co Ai Dung");
            }
            else
            {
                Chat_Form chat_Form = new Chat_Form(pC.IDMay);
                chat_Form.Show();
            }
        }
        private void Loadevent()
        {
            foreach (var i in this.flowLayoutPanel1.Controls)
            {
                Panel p = i as Panel;
                foreach (var j in p.Controls)
                {
                    if (j is PC)
                    {
                        PC pc = j as PC;
                        pc.Click += new EventHandler(pcb_click);
                    }
                }
            }
        }
        private void Create_Button(List<PC> data)
        {
            foreach (var i in data)
            {
                Panel panel1 = new Panel()
                {
                    Location = new System.Drawing.Point(3, 3),
                    Name = "panel2",
                    Size = new System.Drawing.Size(275, 226),
                    TabIndex = 0
                };
                panel1.Controls.Add(PC.CreateLabel(i._Name));
                panel1.Controls.Add(i);

                this.flowLayoutPanel1.Controls.Add(panel1);
            }
        }
    }
}
