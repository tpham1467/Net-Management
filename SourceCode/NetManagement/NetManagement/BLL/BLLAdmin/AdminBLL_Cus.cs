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
    public class AdminBLL_Cus
    {
        private IRepository<Customer> repository;

        public AdminBLL_Cus() : this(new GenericRepository<Customer>())
        {

        }

        public AdminBLL_Cus(IRepository<Customer> _repository)
        {
            repository = _repository;
        }
        

        public IEnumerable<Customer> GetAll()
        {
            
            List<Customer> data = repository.GetAll().ToList();
            return data;
        }
        public IEnumerable<object> Filter(IEnumerable<Customer> cus = null)
        {
            if (cus == null) cus = GetAll();
            var data = cus.Select(p => new
            {
                p.ID_User,
                p.FirstName,
                p.LastName,
                p.DateOfBirth,
                p.Phone,
                p.Email,
                p.Day_Create,
                p.Gender,
                p.Money,
                p.ID_Employee
            });
            return data.ToList();
        }

        public Customer GetCusById(int id)
        {
            Customer cus = repository.GetById(id);
            return cus;

        }
        public void UpdateAdd(string str,Customer cus,DateTime dt)
        {
            bool add = true;
            foreach (Customer i in GetAll())
            {
                if (i.ID_User == Convert.ToInt32(str))
                {
                    add = false;
                    break;
                }
            }
            if (add)
            {
                Add(cus);
            }
            else
            {
                cus.Day_Create = dt;
                cus.ID_User = Convert.ToInt32(str);
                UpDate(cus);
            }
        }
        public void Add(Customer cus)
        {
            cus.Day_Create = DateTime.Now;
            repository.Insert(cus);
            repository.Save();
        }

        public void UpdateDelegate(Customer c1, Customer c2)
        {
            c1.FirstName = c2.FirstName; c1.LastName = c2.LastName;c1.Phone = c2.Phone;c1.Email = c2.Email;
            c1.DateOfBirth = c2.DateOfBirth;c1.Day_Create = c2.Day_Create;c1.Money = c2.Money;c1.ID_Employee = c2.ID_Employee;
            c1.Gender = c2.Gender;c1.ID_User = c2.ID_User;
        }

        public void UpDate(Customer customer)
        {
            repository.Update(customer, customer.ID_User, UpdateDelegate);
            repository.Save();
        }
        public IEnumerable<object> Sort(SortEnum sort, string by)
        {

            if (string.Compare(by, "Name Customer") == 0)
                return Filter(repository.Sort<string>(sort, a => a.LastName));
            else return Filter(repository.Sort<int>(sort, a => a.ID_User));
        }
        public List<object> Search(string search, SearchAcoountEnum searchby)
        {

            if (searchby == SearchAcoountEnum.All)
            {
                return Filter(repository.GetAll()).ToList();
            }
            else if(searchby == SearchAcoountEnum.Id)
            {
                return Filter(repository.Search(search, p => p.ID_User.ToString(), true, true)).ToList();
            }
            else
            {
                return Filter(repository.Search(search,p=>p.FirstName + p.LastName,true,false)).ToList();
            }
        }
        public Customer CreateCus() { 
            return repository.Create();
        }
    }
}
