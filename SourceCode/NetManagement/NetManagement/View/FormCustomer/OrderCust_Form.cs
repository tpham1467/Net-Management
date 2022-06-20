using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetManagement.Helper;
using NetManagement.DTO;
using NetManagement.BLL.BLLCustormer;
namespace NetManagement.View.FormCustomer
{
    public partial class OrderCust_Form : Form
    {
        public OrderCust_Form( int id_cus , int _idcpmuter)
        {
            id = id_cus;
            idcomputer = _idcpmuter;
            InitializeComponent();
            LoadEvent();
            dgvOrder.DataSource = dgvOrder.DataSource = foodOrders.Select(p =>
            new
            {
                p.Item1.name,
                p.Item1.price,
                SoLuong = p.Item2,
            }).ToList();
        }
        private static List<( FoodOrder, int )> foodOrders = new List< (FoodOrder, int )>();
        private BLLOrder _BLLOrder = new BLLOrder();
        private int id;
        private int idcomputer;
        private void LoadEvent()
        {

            foreach (var i in panel2.Controls)
            {
                if (i is TabControl)
                {
                    TabControl tabControl = i as TabControl;
                    foreach (var j in tabControl.Controls)
                    {
                        if (j is TabPage)
                        {
                            TabPage tabPage = j as TabPage;
                            foreach (var z in tabPage.Controls)
                            {
                                if (z is Panel)
                                {
                                    Panel panel = z as Panel;
                                    foreach (var w in panel.Controls)
                                    {
                                        if (w is Button)
                                        {
                                            Button button = w as Button;
                                            button.Click += buttun_click;
                                        }
                                    }
                                }
                            }
                        }

                    }
                }
            }

        }
        private void Addfood(FoodOrder foodOrder)
        {
            bool check = false;
            for (int i = 0  ; i < foodOrders.Count ; i++)
            {
                if(String.Equals( foodOrders[i].Item1.name , foodOrder.name ) )
                {
                    check = true;
                    int sl = foodOrders[i].Item2;
                    foodOrders.RemoveAt(i);
                    foodOrders.Insert(i, (foodOrder, sl + 1));
                }
            }
            if(check == false)
            {
                foodOrder.Status = FoodOderStatus.Current;
                foodOrders.Add((foodOrder, 1));
            }
            dgvOrder.DataSource = foodOrders.Select(p =>
            new
            {
                p.Item1.name,
                p.Item1.price,
                SoLuong = p.Item2,
            }).ToList();
            DisplayTotal();
        }
        private void buttun_click(Object sender , EventArgs e)
        {
            Panel panel = getpanel(sender as Button);
            string namefood="";
            string _price="";
            foreach(var i in panel.Controls)
            {
                if (i is Label)
                {
                    if (i is Label && (i as Label).Text.Any(c => char.IsLetter(c)))
                    {
                        namefood = (i as Label).Text;
                    }
                    else
                    {
                        _price = (i as Label).Text;
                    }
                }
            }

            Addfood(new FoodOrder { name = namefood , price = _price });
        }
        private Panel getpanel(Button button)
        {

            foreach (var i in panel2.Controls)
            {
                if (i is TabControl)
                {
                    TabControl tabControl = i as TabControl;
                    foreach (var j in tabControl.Controls)
                    {
                        if (j is TabPage)
                        {
                            TabPage tabPage = j as TabPage;
                            foreach (var z in tabPage.Controls)
                            {
                                if (z is Panel)
                                {
                                    Panel panel = z as Panel;
                                    foreach (var w in panel.Controls)
                                    {
                                        if (w is Button)
                                        {
                                            if (Button.Equals(w as Button, button) == true) return panel;
                                        }
                                    }
                                }
                            }
                        }

                    }
                }
            }
            return default;
        }
        private List<string> GetSelect()
        {
            if (dgvOrder.SelectedRows.Count > 0)
            {
                List<string> data = new List<string>();
                foreach (DataGridViewRow i in dgvOrder.SelectedRows)
                {
                    string id = i.Cells["name"].Value.ToString();
                    data.Add(id);
                }
                return data;
            }
            return new List<string>();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            List<string> data = GetSelect();
            if(data.Count >0 )
            {
                foreach(var i in data)
                {
                    for(int  j =0;j<foodOrders.Count;j++)
                    {
                        if(i == foodOrders[j].Item1.name)
                        {
                            if (foodOrders[j].Item2 == 1)
                            {
                                foodOrders.RemoveAt(j);
                            }
                            else
                            {
                                int sl = foodOrders[j].Item2;
                                FoodOrder foodOrder = foodOrders[j].Item1;
                                foodOrders.RemoveAt(j);

                                foodOrders.Insert(j, (foodOrder, sl - 1));
                            }
                            break;
                        }
                    }    
                }
                dgvOrder.DataSource = foodOrders.Select(p =>
             new
             {
                 p.Item1.name,
                 p.Item1.price,
                 SoLuong = p.Item2,
             }).ToList();
                DisplayTotal();
            }
            else
            {
                MessageBox.Show("Vui Long Chon");
            }
        }
        private int DisplayTotal()
        {
            int s = 0;
            foreach(var i in foodOrders)
            {
                s += i.Item2 * System.Convert.ToInt32(i.Item1.price.Replace(".", ""));
            }
            txtTongCong.Text = Helper.Convert.ConvertMoneyToVND(s);
            return s;
        }

        private void buttonthanhtoan_Click(object sender, EventArgs e)
        {
            _BLLOrder.HandelOrder(foodOrders, id , idcomputer, DisplayTotal() );
            dgvOrder.DataSource = null;
            foreach(var i in foodOrders)
            {
                i.Item1.Status = FoodOderStatus.Wait;
            }
            txtTongCong.Text = "";

        }
    }
}
