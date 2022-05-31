using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetManagement.Repositories;
using NetManagement.Model;
using NetManagement.DTO;
namespace NetManagement.BLL.BLLLogin
{
    public class BLLLogin
    {
        private IRepository<Account> repository ;
        public BLLLogin() : this(new GenericRepository<Account>() )
        {
           
        }
        public BLLLogin(IRepository<Account> _repository)
        {
            repository = _repository;
        }
        public Account SingUp(string user , string password)
        {
            Account account = new Account();
            foreach(var i in repository.GetAll())
            {
                if(i.UserName_Acc == user && i.Password_Acc == password)
                {
                    return i;
                }
            }
            return null;
        }
        public void Update(Account acc1 , Account acc2 )
        {
            acc1.Password_Acc = acc2.Password_Acc;
        }
        public bool ForgetPassword(ForgetPassword forgetPassword)
        {
            Account account = new Account();
            List<Account> data = repository.GetAll().ToList();
            foreach(var i in data)
            {
                if(i.User.Phone == forgetPassword.phone && i.User.Email ==  forgetPassword.email)
                {
                    try
                    {
                        i.Password_Acc = forgetPassword.NewPassword;
                        repository.Update(i, i.ID_Account, Update);
                        repository.Save();
                        
                        return true;
                    }
                    catch (Exception e)
                    {
                        return false;
                    }

                }
            }
            return false;
        }
    }
}
