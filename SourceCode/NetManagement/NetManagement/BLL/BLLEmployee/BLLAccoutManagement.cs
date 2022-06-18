using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetManagement.Model;
using NetManagement.Repositories;
using NetManagement.DTO;
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
        public IEnumerable<object> Filter(IEnumerable<Account> accounts = null)
        {
            if (accounts == null) accounts = GetAll();
            var data = accounts.Where(p => p.ID_Role == 1 && p.IsErase == 0 ).Select(p =>
            
                 new 
                {
                    p.ID_Account,
                    p.status ,
                    p.Password_Acc,
                    p.UserName_Acc,
                    p.User.FirstName,
                    p.User.LastName,
                    p.User.Email,
                    p.User.Phone,
                    (p.User as Customer).Money ,
                    p.IsErase
                }   );
            return data.ToList();
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
        public bool CheckExist(int id)
        {
            foreach(var i in GetAll())
            {
                if(i.ID_Account  == id )
                {
                    return true; 
                }
            }
            return false;
        } 
        public void UpdateAccount(Account account)
        {
            //repository.Update(account, account.ID_Account, Update);
        }
        public void AddAccount(Account account)
        {
            repository.Insert(account);
        }
        public void AllowanceAcoount(int money,int id)
        {
            TopUpAccount(money, id);
        }
        public void Lock(List<int> data)
        {
            foreach(var i in data)
            {
                repository.GetById(i).status = 1;
            }
        }
        public void Delete(List<int> data)
        {
            foreach(var i in data)
            {
                Account account = repository.GetById(i);
                account.IsErase = 1;
                
            }
            repository.Save();
        }
        public void Unlock(List<int> data )
        {
            foreach(var i in data)
            {
                repository.GetById(i).status = 0;
            }
        }
        public IEnumerable<object> Sort(SortEnum sort, string by)
        {

            if (string.Compare(by, "Id ") == 0)
                return Filter(repository.Sort<int>(sort, a => a.ID_Account));
            else return Filter(repository.Sort<string>(sort, a => a.User.FirstName));
        }
        public List<object> Search(string search)
        {
            return new List<object>();
        }
    }
    public class Compare<T> : IComparer<T>
    {
        int IComparer<T>.Compare(T x, T y)
        {
            throw new NotImplementedException();
        }
    }
}
