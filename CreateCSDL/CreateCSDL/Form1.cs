using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreateCSDL.MODEL;

namespace CreateCSDL
{
    
    public partial class Form1 : Form
    {
        CSDL dl = new CSDL();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
        }
    }
}
