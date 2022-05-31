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

namespace QLQNet
{
    
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            List<PC> p = new List<PC>();
            for(int i=0;i<15;i++)
            {
                p.Add(new PC("May" + i.ToString(), i.ToString(), true));
            }
            Create_Button(p);
            Loadevet();
        }
        private void pcb_click(Object Sender , EventArgs e)
        {
            PC p = Sender as PC;
            MessageBox.Show(p.IDMay);
        }
        private void Loadevet()
        {
            foreach(var i in this.flpListPC.Controls)
            {
                Panel p = i as Panel;
                foreach(var j in p.Controls)
                {
                    if(j is PC)
                    {
                        PC pc = j as PC;
                        pc.DoubleClick += new EventHandler(pcb_click);
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
                    TabIndex = 0,
                };
                panel1.Controls.Add(PC.CreateLabel(i._Name));
                panel1.Controls.Add(i);

                this.flpListPC.Controls.Add(panel1);
            }
        }
      
    }
}
