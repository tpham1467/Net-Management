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
        private IRepository<Status> repository_Status;
        public BLLDisplayinfor() :this(new GenericRepository<Customer>() , new GenericRepository<Status>())
        {

        }
        public BLLDisplayinfor(IRepository<Customer> _repository , IRepository<Status> repository_status)
        {
            repository = _repository;
            repository_Status = repository_status;
        }
        public Customer GetCustomerById(int id)
        {
            return repository.GetById(id);
        }
        public void UpdateDelegate(Customer  c1 , Customer c2)
        {
            //c1.Email = c2.Email; c1.Phone = c2.Phone; c1.FirstName = c2.FirstName; c1.LastName = c2.LastName;
          /*//  c1.DateOfBirth = c2.DateOfBirth;*/ //c1.Money = c2.Money;
        }
        public void UpDate(int money , int Id)
        {
            Status status = repository_Status.GetById(3);
            repository_Status.Reload(status);
            if (status.status == false)
            {
                status.status = true;
                repository_Status.Save();

                int _money = GetCustomerById(Id).Money;
                repository.Reload(GetCustomerById(Id));
                Customer customer = GetCustomerById(Id);
                if (_money != customer.Money)
                {

                }
                else
                {
                    customer.Money = money; repository.Save();
                }

                status.status = false;
                repository_Status.Save();
            }
            else
            {
                while (status.status == true)
                {
                    repository_Status.Reload(status);
                }
                status.status = true;
                repository_Status.Save();


                repository.Reload(GetCustomerById(Id));
              
                status.status = false;
                repository_Status.Save();
            }
         
            
           // repository.Update(customer, Id,UpdateDelegate);
           
        }
    }
}
