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
using NetManagement.Model;
using NetManagement.BLL.BLLEmployee.BLLAccoutManagement;
using NetMessageBox = NetManagement.Helper.NetMessageBox;
namespace NetManagement.View.FormEmployee
{
    public partial class TopUp : Form
    {
        private List<int> id;
        private BLLAccoutManagement _BLLAccoutManagement   = new BLLAccoutManagement();
        public Action<List<object>> action;
        private int Id_Employee;
        public TopUp(List<int> _id , int id_employee)
        {
            id = _id;
            Id_Employee = id_employee;
  
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
            int _money = 0;
            try
            {
                MoneyTopUp money = comboBoxmoney.SelectedItem as MoneyTopUp;
                if (money == null)
                {
                    if (comboBoxmoney.Text is string s)
                    {
                        s = s.ToLower();
                        try
                        {
                            _money = Convert.ToInt32(s);
                        }
                        catch
                        {
                            s = s.Replace("vnd", "");
                            s = s.Replace(" ", "");
                            try
                            {
                                _money = Convert.ToInt32(s);
                            }
                            catch
                            {
                                throw new Exception("Bạn vui Long kiểm Tra Lại Số Tiền");
                            }
                        }
                    }
                }
                else _money = money.Money;
                foreach (var i in id)
                {
                    HistoryAccountUser historyAccountUser = _BLLAccoutManagement.CreateHistoryAccountUser();
                    historyAccountUser.Date = DateTime.Now;
                    historyAccountUser.Description = "Nap Tien";
                    historyAccountUser.Direct = false;
                    historyAccountUser.ID_Customer = i;
                    historyAccountUser.ID_Employee = Id_Employee;
                    historyAccountUser.Money = _money ;
                    _BLLAccoutManagement.LogHistoryAccountUser(historyAccountUser);
                    _BLLAccoutManagement.TopUpAccount(money.Money, i);
                }
            }
            catch(Exception mess)
            {
                    DialogResult result = NetMessageBox.Show(mess.Message,
               "Important Message");
                    return;
                }
            action(null);
            this.Dispose();
        }
    }
}
