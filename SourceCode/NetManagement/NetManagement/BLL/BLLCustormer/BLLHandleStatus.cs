using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetManagement.DTO;
using NetManagement.Helper;
using NetManagement.Model;
using NetManagement.Repositories;
namespace NetManagement.BLL.BLLCustormer
{
    public  class BLLHandleStatus
    {
        private IRepository<Account> repository;
        public BLLHandleStatus() : this(new GenericRepository<Account>())
        {

        }
        public BLLHandleStatus(IRepository<Account> _repository)
        {
            repository = _repository;
        }
        public bool CheckLock(int id)
        {
               foreach(var i in repository.GetAll())
            {
                if(id == i.ID_Account )
                {
                    repository.Reload(i);
                    if(i.status == 1 )
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool CheckErase(int id)
        {
            foreach (var i in repository.GetAll())
            {
                if (id == i.ID_Account)
                {
                    if (i.IsErase == 1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
