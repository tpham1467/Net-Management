using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetManagement.DTO;
using NetManagement.Model;
using NetManagement.Repositories;
namespace NetManagement.BLL.BLlDashBoard
{

    public class BllDashBoard
    {
        private IRepository<Order> repository_order;
        private IRepository<Customer> repository_customer;
        private IRepository<Employee> repository_employee;
        private IRepository<Computer> repository_computer;
        private IRepository<HistoryAccountUser> repository_historyaccountuser;
        private IRepository<HistoryPayroll> repository_historypayroll;
        private IRepository<UseComputerHistory> repository_UseComputerHistory;
        private IRepository<OrderDetail> repository_OrderDetail;
        private IRepository<Inventory> repository_Inventory;
        private DateTime starttime;
        private DateTime endtime ;

        public BllDashBoard() : this(new GenericRepository<Order>() , new GenericRepository<Customer>() , new GenericRepository<Employee>() ,
            new GenericRepository<Computer>() , new GenericRepository<HistoryAccountUser>(), new GenericRepository<HistoryPayroll>() ,
         new GenericRepository<UseComputerHistory>() , new GenericRepository<OrderDetail>(), new GenericRepository<Inventory>())
        {

        }
        public BllDashBoard(IRepository<Order> _repository_order , IRepository<Customer> _repository_customer , IRepository<Employee> _repository_employee ,
            IRepository<Computer> _repository_computer, IRepository<HistoryAccountUser> _repository_historyaccountuser , IRepository<HistoryPayroll> _repository_historypayroll ,
           IRepository<UseComputerHistory> _repository_UseComputerHistory, IRepository<OrderDetail> _repository_OrderDetail ,
            IRepository<Inventory> _repository_Inventory)
        {
            repository_order = _repository_order;
            repository_customer = _repository_customer;
            repository_employee = _repository_employee;
            repository_computer = _repository_computer;
            repository_historyaccountuser = _repository_historyaccountuser;
            repository_historypayroll = _repository_historypayroll;
            repository_UseComputerHistory = _repository_UseComputerHistory;
            repository_OrderDetail = _repository_OrderDetail;
            repository_Inventory = _repository_Inventory;
        }

        public void SetTime(DateTime start , DateTime end )
        {
            starttime = start;
            endtime = end;
        }
        public int CountTotalOrder()
        {
            var data = repository_order.GetAll().Where(p => DateTime.Compare(p.DateOfOrder, starttime) >= 0 &&
             DateTime.Compare(p.DateOfOrder, starttime) <= 0);
            return data.ToList().Count;
        }
        public int CountTotalCusomer()
        {
            return repository_customer.GetAll().ToList().Count;
        }
        public int CountTotalEmployee()
        {
            return repository_customer.GetAll().ToList().Count;
        }
        public int CountTotalComputer()
        {
            return repository_customer.GetAll().ToList().Count;
        }
        public int TotalTopUp(bool IsAll)
        {
            var data = repository_historyaccountuser.GetAll().Where(p => (!IsAll) ?p.Description != "Thanh Toan order" :true && p.Direct == true &&
            DateTime.Compare(p.Date, starttime) >= 0 &&
             DateTime.Compare(p.Date, starttime) <=0 );
            int total = (int)data.Sum(p => p.Money);
            return total;
        }
        public int TotalPaySalary()
        {
            var data = repository_historypayroll.GetAll().Where(p => DateTime.Compare(p.PayrollDate, starttime) >= 0 &&
             DateTime.Compare(p.PayrollDate, endtime) <= 0);
            int total = data.Sum(p => p.Salary);
            return total;
        }
        public float TotalUseComputer()
        {
            var data = repository_UseComputerHistory.GetAll().Where(p => DateTime.Compare(p._LogIn, starttime) >= 0 &&
             DateTime.Compare(p._LogIn, endtime) <= 0);
            float total = data.Sum(p => p.HourUsed);
            return total;
        }
        public int TotaImportMoney()
        {
            var data = repository_Inventory.GetAll().Where(p => DateTime.Compare(p.ImportDay, starttime) >= 0 &&
            DateTime.Compare(p.ImportDay, endtime) <= 0);
            int total = data.Sum(p => p.Init * p.ImportPrices);
            return total;
        }
        public int TotalSaleproduct()
        {
            var data = repository_order.GetAll().Where(p => p.status == true && DateTime.Compare(p.DateOfOrder, starttime) >= 0 &&
             DateTime.Compare(p.DateOfOrder, endtime) <= 0);
            float total = data.Sum(p => p.Total);
            return (int)total;
        }
        public List<(string, int)> CountTotalProductSale()
        {
            var data = repository_OrderDetail.GetAll().Where(p =>p.Order.status == true && p.status == true && DateTime.Compare(p.Order.DateOfOrder, starttime) >= 0 &&
            DateTime.Compare(p.Order.DateOfOrder, endtime) <= 0);
            var result = data.GroupBy(p => p.ID_Product);
            List<(string, int)> output = new List<(string, int)>();
            //foreach (var i in result.ToList())
            //{
            //   .// output.Add((i.Select(g => g.Product.NameProduct).Where() ,  )
            //}


            return output;

        }
        public List<(string, int)> CountTotalTopUpAccount()
        {
            var data = repository_historyaccountuser.GetAll().Where(p => p.Description != "Thanh Toan order" && p.Direct == true &&
            DateTime.Compare(p.Date, starttime) >= 0 &&
             DateTime.Compare(p.Date, endtime) <= 0);
            List<(string, int)> output = new List<(string, int)>();
            foreach (var i in data)
            {
                //if (CheckContainProduct(output, i.customer.FirstName + i.customer.LastName) != ("", 0))
                //{
                //    (string, int) value = CheckContainProduct(output, i.customer.FirstName + i.customer.LastName);
                //    value.Item2++;
                //}
                //else
                //{
                //    (string, int) value;
                //    value.Item1 = i.customer.FirstName +i.customer.LastName;
                //    value.Item2 = 1;
                //    output.Add(value);
                //}
            }
            return output;
        }

        public List<(string, int)> CountTotalUseEachComputer()
        {
            var data = repository_UseComputerHistory.GetAll().Where(p => 
            DateTime.Compare(p._LogIn, starttime) >= 0 &&
             DateTime.Compare(p._LogOut, endtime) <= 0);
            List<(string, int)> output = new List<(string, int)>();
            foreach (var i in data)
            {
                //if (CheckContainProduct(output, i.ID_Computer.ToString()) != ("", 0))
                //{
                //    (string, int) value = CheckContainProduct(output, i.ID_Computer.ToString());
                //    value.Item2++;
                //}
                //else
                //{
                //    (string, int) value;
                //    value.Item1 = i.ID_Computer.ToString();
                //    value.Item2 = 1;
                //    output.Add(value);
                //}
            }
            return output;
        }
        public int TotalRevenue()
        {
            return TotalTopUp(true) + TotalSaleproduct();
        }
        public int TotalProfit()
        {
            return TotalRevenue() - TotalPaySalary() - TotaImportMoney();
        }

    }
}
