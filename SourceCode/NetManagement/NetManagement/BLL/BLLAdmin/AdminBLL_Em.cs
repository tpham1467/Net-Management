using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetManagement.Model;
using NetManagement.Repositories;
using NetManagement.DTO;
namespace NetManagement.BLL
{
    public class AdminBLL_Em
    {
        private IRepository<Employee> repository;
        private IRepository<Account> repository_account;
        #region Contructor
        public AdminBLL_Em() : this(new GenericRepository<Employee>() , new GenericRepository<Account>())
        {
        }
        public AdminBLL_Em(IRepository<Employee> _repository , IRepository<Account> _repository_account)
        {
            repository = _repository;
            repository_account = _repository_account;
        }
        public Employee CreateEm()
        {
            return repository.Create();
        }
        public Account CreateAcoount()
        {
            return repository_account.Create();
        }
        #endregion

        #region Get Object
        public IEnumerable<Employee> GetAll()
        {
            IEnumerable<Employee> data = repository.GetAll().Where(p => p.Accounts.ToList()[0].ID_Role  == 2).ToList();
            return data;
        }
       
        public Employee GetEmById(int id)
        {
            Employee emp = repository.GetById(id);
            return emp;
        }

        public IEnumerable<object> Filter(IEnumerable<Employee> emp = null)
        {
            if (emp == null) emp = GetAll();
            repository.Reload(new List<string>() , true , emp.ToList());
            var data = emp.Select(p => new
            {
                p.ID_User,
                p.FirstName,
                p.LastName,
                p.DateOfBirth,
                p.Phone,
                p.Email,
                p.Day_Create,
                p.Gender,
                p.SalaryEmployee.CoSalary,
                p.Identify
            });
            return data.ToList();
        }

        #endregion

        #region Search And Sort
        public List<object> Search(string search, SearchAcoountEnum searchby)
        {

            if (searchby == SearchAcoountEnum.All)
            {
                return Filter(repository.GetAll()).ToList();
            }
            else if (searchby == SearchAcoountEnum.Name)
            {
                return Filter(repository.Search(search, p => p.FirstName + p.LastName, true, false)).ToList();
            }
            else return Filter(repository.Search(search, p => p.ID_User.ToString(), true, true)).ToList();
        }

        public IEnumerable<object> Sort(SortEnum sort, string by)
        {

            if (string.Compare(by, "Name Employee") == 0)
                return Filter(repository.Sort<string>(sort, a => a.LastName));
            else return Filter(repository.Sort<DateTime>(sort, a => a.Day_Create));
        }

        #endregion

        #region Modified 
        public void Add(Account account ,  Employee emp)
        {
            account.ID_Role = 2;
            emp.Day_Create = DateTime.Now;
            repository.Insert(emp);
            repository.Save();
            account.Id_User = emp.ID_User;
            repository_account.Insert(account);
            repository_account.Save();
        }

        public void UpDate(Employee employee1 , int id , Account account)
        {
            Employee employee2 = GetEmById(id);

            employee2.FirstName = employee1.FirstName; employee2.LastName = employee1.LastName; employee2.DateOfBirth = employee1.DateOfBirth;
            employee2.Phone = employee1.Phone; employee2.Gender = employee1.Gender;  employee2.Identify = employee1.Identify;
            employee2.ID_SalaryEmployee = employee1.ID_SalaryEmployee; employee2.Email = employee1.Email; employee2.Accounts.ToList().ElementAt(0).Password_Acc = account.Password_Acc;
            employee2.Accounts.ToList().ElementAt(0).UserName_Acc = account.UserName_Acc;
            repository.Save();
        }

        #endregion

    }
}
