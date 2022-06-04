using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetManagement.Model;
using NetManagement.Repositories;
namespace NetManagement.BLL.BLLEmployee
{
    public  class BLLAccoutManagement
    {
        private IRepository<Status> repository_status;
        private IRepository<Account> repository;
        private IRepository<User> repository_user = new GenericRepository<User>();
        public BLLAccoutManagement() : this(new GenericRepository<Account>() , new GenericRepository<Status>())
        {

        }
        public BLLAccoutManagement(IRepository<Account> _repository , IRepository<Status> _repository_status)
        {
            repository = _repository;
            repository_status = _repository_status;
        }
        public IEnumerable<Account> GetAll()
        {
            List<Account> data = new List<Account>();
            data = repository.GetAll().ToList();
            return data;
        }
        public IEnumerable<object> Filter()
        {
            
            var data = GetAll().Where(p => p.ID_Role == 1).Select(p =>
            
                 new 
                {
                    p.ID_Account,
                    p.Password_Acc,
                    p.UserName_Acc,
                    p.User.FirstName,
                    p.User.LastName,
                    p.User.Email,
                    p.User.Phone,
                    (p.User as Customer).Money
                }   );
            return data.ToList();
        }
        public void Update(Account account1 , Account  account2 )
        {
            //account1.Password_Acc = account2.Password_Acc; account1.UserName_Acc = account2.UserName_Acc;
            //account1.User.Email = account2.User.Email; account1.User.Phone = account2.User.Phone;
            Customer user1 = account1.User as Customer;  Customer user2 = account2.User as Customer;
            user1.Money = user2.Money;

                }

        public void TopUpAccount(int money , int id)
        {

            Status status = repository_status.GetById(3);
            repository_status.Reload(status);
            if(status.status == false)
            {
                status.status = true;
                repository_status.Save();

                User user = repository.GetById(id).User;
                repository_user.Reload(user as User);
                Customer customer = user as Customer;
                customer.Money += money;
                repository.Save();

                status.status = false;
                repository_status.Save();
            }
            else
            {
                while(status.status == true)
                {
                    repository_status.Reload(status);
                }

                status.status = true ;
                repository_status.Save();

                User user = repository.GetById(id).User;
                repository_user.Reload(user as User);
                Customer customer = user as Customer;
                customer.Money += money;
                repository.Save();

                status.status = false;
                repository_status.Save();
            }


           
            

        }
        public void AllowanceAcoount(int money,int id)
        {

        }
    }
}
