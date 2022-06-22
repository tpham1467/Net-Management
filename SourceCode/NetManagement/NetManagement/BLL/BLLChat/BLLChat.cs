using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetManagement.Repositories;
using NetManagement.Model;
using NetManagement.DTO;
using System.Transactions;

namespace NetManagement.BLL.BLLChat
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


        public IEnumerable<Message> GetAllMessage(int id)
        {

            var data = repository.GetAll();
            data = data.Where(x => x.id_computer == id);
            return data?.ToList();
        }
        public IEnumerable<Message> GetAllMessageAdmin(int id)
        {

            var data = repository.GetAll();
            data = data.Where(x => x.id_computer == id && x.FromEmployee == true);
            return data.ToList();
        }
        public IEnumerable<Message> GetAllMessageUser(int id)
        {

            var data = repository.GetAll();
            data = data.Where(x => x.id_computer == id && x.FromEmployee == false);
            return data.ToList();
        }

        public void AddMessAdmin(string s, int idcomputer)
        {
            Message message = repository.Create();
            message.FromEmployee = true;
            message.id_computer = idcomputer;
            message.time = DateTime.Now;
            message._Message = s;
            repository.Insert(message);
            repository.Save();
        } 

        public void AddMess(string s, int idcomputer)
        {
            Message message = repository.Create();
            message.FromEmployee = false;
            message.id_computer = idcomputer;
            message.time = DateTime.Now;
            message._Message = s;
            repository.Insert(message);
            repository.Save();
        }
    }
}
