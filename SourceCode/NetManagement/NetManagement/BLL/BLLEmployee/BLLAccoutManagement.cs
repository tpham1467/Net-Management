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
        private IRepository<Account> repository;
        public BLLAccoutManagement() : this(new GenericRepository<Account>())
        {

        }
        public BLLAccoutManagement(IRepository<Account> _repository )
        {
            repository = _repository;
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
            account1.Password_Acc = account2.Password_Acc; account1.UserName_Acc = account2.UserName_Acc;
            account1.User.Email = account2.User.Email; account1.User.Phone = account2.User.Phone;
            Customer user1 = account1.User as Customer;  Customer user2 = account2.User as Customer;
            user1.Money = user1.Money;

                }
        public void TopUpAccount(int Currentmoney,int money , int id)
        {
            Account account = new Account();
            account.User = new Customer
            {
                Money = money + Currentmoney
            } ;
            repository.Update(account, id, Update);

        }
        public void AllowanceAcoount(int money,int id)
        {

        }
    }
}
