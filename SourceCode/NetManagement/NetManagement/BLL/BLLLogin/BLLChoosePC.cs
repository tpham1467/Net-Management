using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetManagement.Model;
using NetManagement.Repositories;
using NetManagement.DTO;
namespace NetManagement.BLL.BLLLogin
{
    
    public class BLLChoosePC
    {
        private IRepository<Computer> repository;

        public BLLChoosePC() : this( new GenericRepository<Computer>())
        {

        }

        public BLLChoosePC(IRepository<Computer> _repository)
        {
            repository = _repository;
        }
        public List<Computer> GetAll()
        {
            List<Computer> data = repository.GetAll().ToList();
            return data;
        }
        public List<PC> ConvertToPc()
        {
            List<PC> data = new List<PC>();
            foreach(var i in GetAll())
            {
                PC pc = new PC(i.Name_PC, i.ID_Computer, i.Status);
                data.Add(pc);

            }
            return data;
        }
    }

}
