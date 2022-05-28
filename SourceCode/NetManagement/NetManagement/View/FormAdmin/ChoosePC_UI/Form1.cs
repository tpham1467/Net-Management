using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChoosePC_UI
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            flowLayoutPanel1.AutoScroll = true;
        }

        private void pbMay1_DoubleClick(object sender, EventArgs e)
        {
            string txt = "Máy 1";
            Detail_ChoosePC f = new Detail_ChoosePC();
            f.d(txt);
            f.Show();
        }

        private void pbMay2_Click(object sender, EventArgs e)
        {
            string txt = "Máy 2";
            Detail_ChoosePC f = new Detail_ChoosePC();
            f.d(txt);
            f.Show();
        }

        List<PC> p = new List<PC>();

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
