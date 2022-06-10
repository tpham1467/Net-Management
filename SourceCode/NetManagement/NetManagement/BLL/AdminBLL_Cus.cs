using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            IEnumerable<Customer> data = repository.GetAll().ToList();
            foreach (Customer i in data)
            {
                i.FullNameCus = i.FirstName + i.LastName;
            }
            return data;
        }
        public void DelCus(int id)
        {
            //repository.Delete(id);
            //repository.Save();
        }
        public Customer GetCusById(int id)
        {
            return repository.GetById(id);

        }
        public void UpdateAdd(Customer cus)
        {
            bool add = true;
            foreach (Customer i in GetAll())
            {
                if (i.ID_User == cus.ID_User)
                {
                    add = false;
                    break;
                }
            }
            if (add)
            {
                Add(cus);
            }
            else UpDate(cus);
        }
        public void Add(Customer cus)
        {
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
        public List<Customer> Sort(string txt)
        {
            List<Customer> list = new List<Customer>();
            if (txt == "Name")
            {
                list = GetAll().OrderBy(p => p.LastName).ToList();
            }
            else if (txt == "ID_User")
            {
                list = GetAll().OrderBy(p => p.ID_User).ToList();
            }
            return list;
        }
        public List<Customer> Search(string s, string txt)
        {
            List<Customer> data1 = GetAll().ToList();
            List<Customer> data2 = new List<Customer>();

            if (s == "ID_User")
            {
                if(txt != "")
                {
                    int id = Convert.ToInt32(txt);
                    foreach (Customer i in repository.GetAll())
                    {
                        if (i.ID_User == id)
                        {
                            data2.Add(i);
                        }
                    }
                }
            }
            else if(s == "Name")
            {
                foreach (Customer i in data1)
                {
                    if (i.FullNameCus.ToLower().Contains(txt.ToLower()))
                    {
                        data2.Add(i);
                    }
                }

            }
            else if (s == "All")
            {
                data2 = GetAll().ToList();
            }
            return data2;
        }
    }
}
