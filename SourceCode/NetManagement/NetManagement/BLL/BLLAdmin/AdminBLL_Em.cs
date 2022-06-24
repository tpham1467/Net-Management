using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetManagement.DTO;
using NetManagement.Model;
using NetManagement.Repositories;

namespace NetManagement.BLL
{
    public class AdminBLL_Em
    {
        private IRepository<Employee> repository;
        public AdminBLL_Em() : this(new GenericRepository<Employee>())
        {
        }
        public AdminBLL_Em(IRepository<Employee> _repository)
        {
            repository = _repository;
        }
        public IEnumerable<Employee> GetAll()
        {
            IEnumerable<Employee> data = repository.GetAll().ToList();
            return data;
        }
        public IEnumerable<object> Filter(IEnumerable<Employee> emp = null)
        {
            if(emp == null) emp = GetAll();
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
       
        public Employee GetEmById(int id)
        {
            Employee emp = repository.GetById(id);
            return emp;
        }
        
        public IEnumerable<object> Sort(SortEnum sort, string by)
        {

            if (string.Compare(by, "Name Employee") == 0)
                return Filter(repository.Sort<string>(sort, a => a.LastName));
            else return Filter(repository.Sort<DateTime>(sort, a => a.Day_Create));
        }
        public List<object> Search(string search, SearchAcoountEnum searchby)
        {

            if (searchby == SearchAcoountEnum.All)
            {
                return Filter(repository.GetAll()).ToList();
            }
            else if(searchby == SearchAcoountEnum.Name)
            {
                return Filter(repository.Search(search, p => p.FirstName + p.LastName, true, false)).ToList();
            }
            else return Filter(repository.Search(search, p => p.ID_User.ToString(), true, true)).ToList();
        }
        public void UpdateAdd(string str, Employee emp, DateTime dt)
        {
            bool add = true;
            foreach (Employee i in GetAll())
            {
                if (i.ID_User == Convert.ToInt32(str))
                {
                    add = false;
                    break;
                }
            }
            if (add)
            {
                Add(emp);
            }
            else
            {
                emp.Day_Create = dt;
                emp.ID_User = Convert.ToInt32(str);
                UpDate(emp);
            }
        }
        public void Add(Employee emp)
        {
            emp.Day_Create = DateTime.Now;
            repository.Insert(emp);
            repository.Save();
        }

        public void UpdateDelegate(Employee c1, Employee c2)
        {
            c1.FirstName = c2.FirstName; c1.LastName = c2.LastName; c1.DateOfBirth = c2.DateOfBirth;
            c1.Phone = c2.Phone; c1.Gender = c2.Gender; c1.Day_Create = c2.Day_Create; c1.Identify = c2.Identify;
            c1.ID_SalaryEmployee = c2.ID_SalaryEmployee; c1.Email = c2.Email;
        }

        public void UpDate(Employee employee)
        {
            repository.Update(employee, employee.ID_User, UpdateDelegate);
            repository.Save();
        }
        public Employee CreateEm()
        {
            return repository.Create();
        }

        public void SaveChange()
        {
            repository.Save();
        }
    }
}
