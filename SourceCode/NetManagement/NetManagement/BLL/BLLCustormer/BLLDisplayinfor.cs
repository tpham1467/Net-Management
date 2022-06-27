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
        private IRepository<Account> repository_account;
        public BLLDisplayinfor() :this(new GenericRepository<Customer>() , new GenericRepository<Status>() , new GenericRepository<Account>())
        {

        }
        public BLLDisplayinfor(IRepository<Customer> _repository , IRepository<Status> repository_status ,IRepository<Account> _repository_account)
        {
            repository = _repository;
            repository_Status = repository_status;
            repository_account = _repository_account;
        }
        public Customer GetCustomerById(int id)
        {
            return repository.GetById(id);
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
        public void UpdateInfo(Customer customer , int id)
        {
            Customer customer2 = repository.GetById(id);
            customer2.Phone = customer.Phone;
            customer2.DateOfBirth = customer.DateOfBirth;
            customer2.FirstName = customer.FirstName;
            customer2.LastName = customer.LastName;
            customer2.Email = customer.Email;
            repository.Save();
        }
        private Account GetAcoontByIdCustomer(int Id)
        {
            foreach (var customer in repository.GetAll())
            {
                if(customer.ID_User == Id )
                {
                    return customer.Accounts.First();
                }
            }
            return null;
        }
        public void UpdatePassword(string oldpass ,string newpass , int id)
        {
            string username = GetAcoontByIdCustomer(id).UserName_Acc;
            foreach (var i in repository_account.GetAll())
            {
                if(i.UserName_Acc == username && i.Password_Acc == oldpass)
                {
                    i.Password_Acc = newpass;
                }
            }
            repository_account.Save();
        }
    }
}
