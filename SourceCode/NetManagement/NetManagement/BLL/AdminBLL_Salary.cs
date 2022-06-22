using NetManagement.Model;
using NetManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetManagement.BLL
{
    public class AdminBLL_Salary
    {
        private IRepository<SalaryEmployee> repository;
        private IRepository<Employee> repository_empl = new GenericRepository<Employee>();
        public AdminBLL_Salary() : this(new GenericRepository<SalaryEmployee>())
        {

        }
        public AdminBLL_Salary(IRepository<SalaryEmployee> _repository)
        {
            repository = _repository;
        }
        public IEnumerable<SalaryEmployee> GetAll()
        {
            IEnumerable<SalaryEmployee> data = repository.GetAll().ToList();
            return data;
        }
        public SalaryEmployee GetSalaryById(int id)
        {
            return repository.GetById(id);
        }
        public IEnumerable<SalaryEmployee> GetAllById(List<int> id)
        {
            IEnumerable<SalaryEmployee> data = repository.GetAll().ToList();
            List<SalaryEmployee> data2 = new List<SalaryEmployee>();
            foreach (int i in id)
            {
                foreach (SalaryEmployee sal in data)
                {
                    if (i == sal.ID_SalaryEmployee)
                    {
                        data2.Add(sal);
                    }
                }
            }
            return data2;
        }

        public void TopUpSalary(List<int> ID_User, int ID_EmpSalary)
        {
            foreach (int i in ID_User)
            {
                repository_empl.GetById(i).ID_SalaryEmployee = ID_EmpSalary;
                repository_empl.Save();
            }
        }
        public SalaryEmployee CreateSal()
        {
            return repository.Create();
        }
        public void UpdateAdd(string str, SalaryEmployee sal)
        {
            bool add = true;
            foreach (SalaryEmployee i in GetAll())
            {
                if (i.ID_SalaryEmployee == Convert.ToInt32(str))
                {
                    add = false;
                    break;
                }
            }
            if (add)
            {
                Add(sal);
            }
            else
            {
                sal.ID_SalaryEmployee = Convert.ToInt32(str);
                UpDate(sal);
            }
        }
        public void Add(SalaryEmployee sal)
        {
            repository.Insert(sal);
            repository.Save();
        }

        public void UpdateDelegate(SalaryEmployee c1, SalaryEmployee c2)
        {
            c1.CoSalary = c2.CoSalary;
        }

        public void UpDate(SalaryEmployee salary)
        {
            repository.Update(salary, salary.ID_SalaryEmployee, UpdateDelegate);
            repository.Save();
        }
        public List<SalaryEmployee> Search(string txt, string txtcbb, List<int> list)
        {
            List<SalaryEmployee> data1 = GetAllById(list).ToList();
            List<SalaryEmployee> data2 = new List<SalaryEmployee>();

            if (txtcbb == "Salary")
            {
                foreach (SalaryEmployee sal in data1)
                {
                    if (sal.CoSalary.ToString().Contains(txt.ToLower()))
                    {
                        data2.Add(sal);
                    }
                }
            }
            else return data1;
            return data2;
        }
    }
}
