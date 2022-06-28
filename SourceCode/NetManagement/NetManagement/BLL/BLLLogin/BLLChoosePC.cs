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
        private IRepository<UseComputerHistory> repository_UseComputerHistory;
        public BLLChoosePC() : this( new GenericRepository<Computer>() , new GenericRepository<UseComputerHistory>())
        {

        }

        public BLLChoosePC(IRepository<Computer> _repository, IRepository<UseComputerHistory> _repository_UseComputerHistory)
        {
            repository = _repository;
            repository_UseComputerHistory = _repository_UseComputerHistory;
        }
        public List<Computer> GetAll()
        {
            List<Computer> data = repository.GetAll().ToList();
            return data;
        }
        public Computer GetComputerById(int id)
        {
            return repository.GetById(id);
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
        public void OnPc(int id)
        {
            Computer computer = repository.GetById(id);
            computer.Status = true;
            repository.Save();
        }
        public void OffPc(int id)
        {
            Computer computer = repository.GetById(id);
            computer.Status = false;
            repository.Save();
        }
        public int  LoginComputer(int idcomputer , int customer)
        {
            UseComputerHistory useComputerHistory = repository_UseComputerHistory.Create();
            useComputerHistory.ID_Computer = idcomputer;
            useComputerHistory.ID_Customer = customer;
            useComputerHistory._LogIn = DateTime.Now;
            repository_UseComputerHistory.Insert(useComputerHistory);
            repository_UseComputerHistory.Save();
            return useComputerHistory.ID_HistoryUseComputer;
        }
        public void LogOutComputer(int idusecpmputerhistory , float houruse)
        {
            UseComputerHistory useComputerHistory = repository_UseComputerHistory.GetById(idusecpmputerhistory);
            useComputerHistory._LogOut = DateTime.Now;
            useComputerHistory.HourUsed = houruse;
            repository_UseComputerHistory.Save();
        }
        public bool CheckComputer(int id)
        {
            foreach(var i in repository.GetAll())
            {
                if(i.ID_Computer == id)
                {
                   // repository.Reload(i);
                    if (i.Status) return false;
                    else return true;
                }
            }
            return false;
        }
        public void UpdateCustomerUse(int id_computer , int id_cutomer)
        {
            foreach(var i in repository.GetAll())
            {
                if(i.ID_Computer == id_computer)
                {
                    Computer computer = repository.GetById(id_computer);
                    computer.ID_Customer = id_cutomer;
                    break;
                }
            }
            repository.Save();
        }

    }

}
