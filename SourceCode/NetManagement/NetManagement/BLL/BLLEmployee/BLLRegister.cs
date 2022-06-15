using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetManagement.DTO;
using NetManagement.Helper;
using NetManagement.Model;
using NetManagement.Repositories;
namespace NetManagement.BLL.BLLEmployee
{
    public class BLLRegister
    {
        private IRepository<Shift> repository;
        public BLLRegister() : this(new GenericRepository<Shift>())
        {

        }
        public BLLRegister(IRepository<Shift> _repository )
        {
             repository = _repository;
        }
        public void CheckIn()
        {

        }
        public void CheckOut(int id )
        {

        }
    }
}
