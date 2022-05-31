using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetManagement.Repositories;
using NetManagement.Model;
using NetManagement.DTO;
namespace NetManagement.BLL.BLLCustormer
{
    public class BLLDisplayinfor
    {
        private IRepository<Customer> repository;
        public BLLDisplayinfor() :this(new GenericRepository<Customer>())
        {

        }
        public BLLDisplayinfor(IRepository<Customer> _repository)
        {
            repository = _repository;
        }
        public Customer GetCustomerById(int id)
        {
            return repository.GetById(id);
        }
        public void UpdateDelegate(Customer  c1 , Customer c2)
        {
            c1.Email = c2.Email; c1.Phone = c2.Phone; c1.FirstName = c2.FirstName; c1.LastName = c2.LastName;
            c1.DateOfBirth = c2.DateOfBirth; c1.Money = c2.Money;
        }
        public void UpDate(Customer customer)
        {
            repository.Update(customer, customer.ID_User,UpdateDelegate);
            repository.Save();
        }
    }
}
