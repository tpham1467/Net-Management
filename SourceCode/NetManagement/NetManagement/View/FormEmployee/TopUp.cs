using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetManagement.DTO;
namespace NetManagement.View.FormEmployee
{
    public partial class TopUp : Form
    {

        public TopUp()
        {
            
            InitializeComponent();
            LoadObjectForCompoment();
        }
        private void LoadObjectForCompoment()
        {
           

            comboBoxmoney.Items.AddRange(new MoneyTopUp[]
                {
                new MoneyTopUp {Money = 5000 } ,
                new MoneyTopUp {Money =10000},
                new MoneyTopUp {Money = 20000},
                new MoneyTopUp {Money = 50000},
                new MoneyTopUp {Money = 100000}, 
                new MoneyTopUp {Money = 200000} ,
                new MoneyTopUp { Money = 500000}
            }) ;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {

        }
    }
}
