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
    public partial class Detail_ChoosePC : Form
    {
        public delegate void Mydel(string Message);
        public Mydel d;
        public Detail_ChoosePC()
        {
            InitializeComponent();
            d= new Mydel(setName);
        }

        private void tbTenMay_TextChanged(object sender, EventArgs e)
        {

        }

        public void setName(string txt)
        {
            tbTenMay.Text = txt;
        }
    }
}
