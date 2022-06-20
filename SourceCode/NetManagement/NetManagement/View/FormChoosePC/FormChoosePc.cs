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
using NetManagement.BLL.BLLLogin;
using NetManagement.DTO;
using NetManagement.View.FormCustomer;
namespace NetManagement.View.FormChoosePC
{
    
    public partial class FormChoosePc : Form
    {
        private int Id_Customer;
        private BLLChoosePC _BLLChoosePC = new BLLChoosePC();
     
        public FormChoosePc(int id_customer)
        {
            InitializeComponent();
            Id_Customer = id_customer;
            List<PC> data = _BLLChoosePC.ConvertToPc();
            Create_Button(data);
            Loadevent();

        }
        private void pcb_click(Object Sender, EventArgs e)
        {
            PC p = Sender as PC;
            MainForm_User mainForm_User = new MainForm_User(Id_Customer , p.IDMay);
            mainForm_User.Show();
            this.Hide();

        }
        private void Loadevent()
        {
            foreach (var i in this.flpListPC.Controls)
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

                this.flpListPC.Controls.Add(panel1);
            }
        }

    }


}
