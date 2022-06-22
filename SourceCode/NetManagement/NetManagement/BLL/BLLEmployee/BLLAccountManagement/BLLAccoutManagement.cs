using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetManagement.Model;
using NetManagement.Repositories;
using NetManagement.DTO;
namespace NetManagement.BLL.BLLEmployee.BLLAccoutManagement
{
    public  class BLLAccoutManagement
    {
        private IRepository<Status> repository_status;
        private IRepository<Account> repository;
        private IRepository<User> repository_user;
        private IRepository<HistoryAccountUser> repository_HistoryAccountUser;
        private IRepository<Computer> repository_computer;
        public BLLAccoutManagement() : this(new GenericRepository<Account>() , new GenericRepository<Status>() , new GenericRepository<User>()  , new GenericRepository<HistoryAccountUser>() ,
            new GenericRepository<Computer>())
        {

        }
        public BLLAccoutManagement(IRepository<Account> _repository , IRepository<Status> _repository_status , IRepository<User> _repository_User , IRepository<HistoryAccountUser> _repository_HistoryAccountUser,
            IRepository<Computer> _repository_computer)
        {
            repository = _repository;
            repository_status = _repository_status;
            repository_user = _repository_User;
            repository_HistoryAccountUser = _repository_HistoryAccountUser;
            repository_computer = _repository_computer;
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
        public void UpdateAccount(User user , string username , string password , int id)
        {
            Account account = repository.GetById(id);
            account.UserName_Acc = username;
            account.Password_Acc = password;
            account.User.Email = user.Email;
            account.User.Phone = user.Phone;
            account.User.DateOfBirth = user.DateOfBirth;
            account.User.FirstName = user.FirstName;
            account.User.LastName = user.LastName;
            account.User.Gender = user.Gender;
            repository_user.Save();
        }
        public void AddAccount(User accUserount , string username , int IdEmloyee)
        {
            (accUserount as Customer).ID_Employee = IdEmloyee;
            (accUserount as Customer).Money = 0;
            (accUserount as Customer).Day_Create = DateTime.Now;
            repository_user.Insert(accUserount);
            repository_user.Save();
            User user = repository_user.GetAll().Last() ;


            Account account = repository.Create();
            account.UserName_Acc = username;
            account.Password_Acc = "123456";
            account.ID_Role = 1; account.Id_User = user.ID_User;
            repository.Insert(account);
            repository.Save();

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
            repository.Save();
        }
        public Account GetById(int id)
        {
            return repository.GetById(id);
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
            repository.Save();
        }
        public IEnumerable<object> Sort(SortEnum sort, string by)
        {

            if (string.Compare(by, "Id ") == 0)
                return Filter(repository.Sort<int>(sort, a => a.ID_Account));
            else return Filter(repository.Sort<string>(sort, a => a.User.FirstName));
        }
        public List<object> Search(string search )
        {
            return Filter(repository.Search(search, (p) => p.Password_Acc , true , false ) ).ToList();
        }

        public void LogHistoryAccountUser(HistoryAccountUser historyAccountUser )
        {
            if (GetId_CustomerByIdComputer(historyAccountUser.ID_Customer) != -1)
                historyAccountUser.ID_Computer = GetId_CustomerByIdComputer(historyAccountUser.ID_Customer);
            repository_HistoryAccountUser.Insert(historyAccountUser);
            repository_HistoryAccountUser.Save();
        }
        public HistoryAccountUser CreateHistoryAccountUser()
        {
            return repository_HistoryAccountUser.Create();
        }
        public int GetId_CustomerByIdComputer(int id)
        {
            foreach(var i in repository_computer.GetAll())
            {
                if (i.ID_Customer == id) return i.ID_Computer; 
            }
            return -1;
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
