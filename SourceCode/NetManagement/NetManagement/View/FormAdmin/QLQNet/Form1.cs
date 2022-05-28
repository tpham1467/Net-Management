using ChoosePC_UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLQNet
{
    
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            KNSQL();
            Loadevent();
        }

        private void KNSQL()
        {
            string s = @"Data Source=DESKTOP-530ACSJ;Initial Catalog=PC;Integrated Security=True";
            QLPC p = new QLPC(s);
            string query = "select * from PC";
            p.getRecordPC(query);
            Create_Button(p.getRecordPC(query));
        }
        private void pcb_click(Object Sender , EventArgs e)
        {
            PC p = Sender as PC;
            //MessageBox.Show(p.Status.ToString());
            Detail_ChoosePC f = new Detail_ChoosePC();
            f.d(p.Name, p.IDMay, p.Status);
            f.Show();
        }
        private void Loadevent()
        {
            foreach(var i in this.flpListPC.Controls)
            {
                Panel p = i as Panel;
                foreach(var j in p.Controls)
                {
                    if(j is PC)
                    {
                        PC pc = j as PC;
                        pc.Click += new EventHandler(pcb_click);
                    }
                }
            }
        }
        private void Create_Button(List<PC> data)
        {
            foreach(var i in data)
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
