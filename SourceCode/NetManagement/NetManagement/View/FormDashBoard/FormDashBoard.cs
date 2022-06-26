using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetManagement.BLL.BLlDashBoard;
namespace NetManagement.View.FormDashBoard
{
    public partial class FormDashBoard : Form
    {
        //Fields
        private BllDashBoard  BllDashBoard = new BllDashBoard();

        //Constructor
        public FormDashBoard()
        {
            InitializeComponent();
            //Default - Last 7 days
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            btnLast7Days.Select();
            LoadData();
        }

        //Private methods
        private void LoadData()
        {
            BllDashBoard.SetTime(dtpStartDate.Value, dtpEndDate.Value);

            lblNumOrders.Text = BllDashBoard.CountTotalOrder().ToString();
            lblTotalRevenue.Text = "$" + BllDashBoard.TotalRevenue().ToString();
            lblTotalProfit.Text = "$" + BllDashBoard.TotalProfit().ToString();

            lblNumCustomers.Text = BllDashBoard.CountTotalCusomer().ToString();
            lblNumcomputer.Text = BllDashBoard.CountTotalComputer().ToString();
            lblNumemployee.Text = BllDashBoard.CountTotalEmployee().ToString();

            chartsoluongtiennapmoitaikhoa.DataSource = BllDashBoard.CountTotalTopUpAccount();
            chartsoluongtiennapmoitaikhoa.Series[0].XValueMember = "Account";
            chartsoluongtiennapmoitaikhoa.Series[0].YValueMembers = "Total Top Up";
            chartsoluongtiennapmoitaikhoa.DataBind();

            chartTopProducts.DataSource = BllDashBoard.CountTotalProductSale();
            chartTopProducts.Series[0].XValueMember = "ProDuct";
            chartTopProducts.Series[0].YValueMembers = "So Luong";
            chartTopProducts.DataBind();

            chartmaysudung.DataSource = BllDashBoard.CountTotalUseEachComputer();
            chartmaysudung.Series[0].XValueMember = "May";
            chartmaysudung.Series[0].YValueMembers = "So Gio";
            chartmaysudung.DataBind();

            labeltongsogiosudungmay.Text = BllDashBoard.TotalUseComputer().ToString();
            labeltongsotienbanhang.Text = BllDashBoard.TotalSaleproduct().ToString();
            labeltongsotiennapmay.Text = BllDashBoard.TotalTopUp(false).ToString();
            labeltongsotientraluong.Text = BllDashBoard.TotalPaySalary().ToString();
 
        }
        private void DisableCustomDates()
        {
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            btnOkCustomDate.Visible = false;
        }

        //Event methods
        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnLast30Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnCustomDate_Click(object sender, EventArgs e)
        {
            dtpStartDate.Enabled = true;
            dtpEndDate.Enabled = true;
            btnOkCustomDate.Visible = true;
        }

        private void btnOkCustomDate_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void chartGrossRevenue_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
