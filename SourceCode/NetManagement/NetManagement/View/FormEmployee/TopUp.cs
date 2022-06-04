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
using NetManagement.BLL.BLLEmployee;
namespace NetManagement.View.FormEmployee
{
    public partial class TopUp : Form
    {
        private List<int> id;
        private BLLAccoutManagement _BLLAccoutManagement   = new BLLAccoutManagement();
        public Action action;
        public TopUp(List<int> _id)
        {
            id = _id;
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
            MoneyTopUp money = comboBoxmoney.SelectedItem as MoneyTopUp;
            foreach (var i in id)
            {
                _BLLAccoutManagement.TopUpAccount(money.Money, i);
            }
            action.Invoke();
            this.Dispose();
        }
    }
}
