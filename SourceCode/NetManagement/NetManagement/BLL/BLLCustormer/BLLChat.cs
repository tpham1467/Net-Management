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
    public class BLLChat
    {
        private IRepository<Message> repository;
        public BLLChat() : this(new GenericRepository<Message>())
        {

        }
        public BLLChat(IRepository<Message> _repository)
        {
            repository = _repository;
        }


        public IEnumerable<Object> GetAllMessage(int id)
        {
            var data = repository.GetAll();
            data = data.Where(x => x.Id == id).Select(p => new
            {
                p.
            });
        }
    }
}
