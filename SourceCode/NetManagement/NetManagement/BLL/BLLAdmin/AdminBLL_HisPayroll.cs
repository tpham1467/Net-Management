using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetManagement.Model;
using NetManagement.Repositories;

namespace NetManagement.BLL
{
    public class AdminBLL_HisPayroll
    {
        private IRepository<HistoryPayroll> repository;
        private IRepository<Shift> repository_shift;
        private IRepository<Employee> repository_employee;
        public AdminBLL_HisPayroll() : this(new GenericRepository<HistoryPayroll>() , new GenericRepository<Shift>() , new GenericRepository<Employee>())
        {

        }

        public AdminBLL_HisPayroll(IRepository<HistoryPayroll> _repository , IRepository<Shift> _repository_shift , IRepository<Employee> _repository_employee)
        {
            repository = _repository;
            repository_shift = _repository_shift;
            repository_employee = _repository_employee;
        }

        #region Get Object
        public IEnumerable<HistoryPayroll> GetAll()
        {
            IEnumerable<HistoryPayroll> data = repository.GetAll().ToList();
            return data;
        }
        public IEnumerable<object> Filter(IEnumerable<HistoryPayroll> HistoryPayrolls = null)
        {
            if (HistoryPayrolls == null) HistoryPayrolls = GetAll();
            var data = HistoryPayrolls.Select(p =>

                new
                {
                    p.Employee.ID_User ,
                    Name  = p.Employee.FirstName + p.Employee.LastName ,
                   Date = p.PayrollDate.ToString("MM / dd / yyyy") ,
                   p.Salary ,
                });
            return data.ToList();
        }

        public List<HistoryPayroll> GetHisPayrollById(List<int> id)
        {
            IEnumerable<HistoryPayroll> data = repository.GetAll().ToList();
            List<HistoryPayroll> data2 = new List<HistoryPayroll>();
            foreach (int i in id)
            {
                foreach (HistoryPayroll his in data)
                {
                    if (i == his.ID_User)
                    {
                        his.PayrollDate = DateTime.Now;
                        data2.Add(his);
                    }
                }
            }
            repository.Save();
            return data2;
        }
        #endregion
        public List<HistoryPayroll> Sort(List<int> id,string txtcbb)
        {
            List<HistoryPayroll> list = GetHisPayrollById(id);
            if (txtcbb == "WorkHour")
            {
                //list = list.OrderBy(p=>p.Shift.WorkedHour).ToList();
            }
            return list;
        }
        public void SaveChange()
        {
            repository.Save();
        }


        public IEnumerable<object> PayRoll(List<int> id_employee , bool ModeSave)
        {
            if(id_employee == null)
            {
                id_employee = repository_employee.GetAll().Select(p => p.ID_User).ToList();
            }
            List<HistoryPayroll> historyPayrolls = new List<HistoryPayroll>();
            foreach (var j in id_employee)
            {
                HistoryPayroll historyPayroll = ChangeStatusShift(j, ModeSave);
                if (historyPayroll != null)
                {
                    historyPayroll.Employee = repository_employee.GetById(j);
                    historyPayrolls.Add(historyPayroll);
                }
              

            }
            if (ModeSave)
                return new List<object>();
            else
            {
                var data  =  historyPayrolls.Select(p =>
  new
  {
        p.Employee.ID_User, 
      p.Salary ,
      Name = p.Employee.FirstName + p.Employee.LastName,
      p.Employee.SalaryEmployee.CoSalary,
  });
                return data.ToList();
            }
        }
        private HistoryPayroll ChangeStatusShift(int id_employee , bool ModeSave)
        {
            HistoryPayroll historyPayroll = repository.Create();
            historyPayroll.ID_User = id_employee;
            historyPayroll.PayrollDate = DateTime.Now;
            int salary = 0;
            foreach(var i in repository_shift.GetAll())
            {
                if (i.ID_Employee == id_employee && i.ID_StatusShift == 2)
                {
                    Employee employee = i.Employee;
                    
                    salary += employee.SalaryEmployee.CoSalary * i.WorkedHour;
                    if (ModeSave)
                    {
                        i.ID_StatusShift = 4;
                    }
                }
            }
            historyPayroll.Salary = salary;
         
            if (ModeSave)
            {

                repository.Insert(historyPayroll);
                repository.Save();
                repository_shift.Save();
                return null;
            }
            else
            {
                return historyPayroll;
            }
        }
    }
}
