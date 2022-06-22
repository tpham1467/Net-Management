using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            foreach(Employee emp in data)
            {
               // emp.FullNameEm = emp.FirstName + " "+ emp.LastName;
            }
            SaveChange();
            return data;
        }
       
        public Employee GetEmById(int id)
        {
            Employee emp = repository.GetById(id);
            //emp.FullNameEm = emp.FirstName + " " + emp.LastName;
            return emp;
        }
        public IEnumerable<Employee> GetAllById(List<int> id)
        {
            IEnumerable<Employee> data = repository.GetAll().ToList();
            List<Employee> data2 = new List<Employee>();
            foreach (int i in id)
            {
                foreach(Employee emp in data)
                {
                    if(i == emp.ID_User)
                    {
                        data2.Add(emp);
                    }
                }
            }
            return data2;
        }
        public List<Employee> Search(string txt, string txtcbb, List<int> list)
        {
            List<Employee> data1 = GetAllById(list).ToList();
            List<Employee> data2 = new List<Employee>();

            if (txtcbb == "Name Employee")
            {
                foreach(Employee emp in data1)
                {
                    //if (emp.FullNameEm.ToLower().Contains(txt.ToLower()))
                    //{
                    //    data2.Add(emp);
                    //}
                }
            }
            else return data1;
            return data2;
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
