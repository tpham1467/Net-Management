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
            return repository.GetAll().ToList();
        }
        public SalaryEmployee GetSalaryById(int id)
        {
            return repository.GetById(id);
        }

        public SalaryEmployee CreateSal()
        {
            return repository.Create();
        }
        public void Add(SalaryEmployee sal)
        {
            repository.Insert(sal);
            repository.Save();
        }

        public void UpDate(SalaryEmployee salary  , int id)
        {
            SalaryEmployee salaryEmployee = GetSalaryById(id);
            salaryEmployee.CoSalary = salary.CoSalary;
            repository.Save();
        }
     
    }
}
