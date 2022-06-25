using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetManagement.DTO;
using NetManagement.Model;
using NetManagement.Repositories;

namespace NetManagement.BLL
{
    public class AdminBLL_UseCPHis
    {
        private IRepository<UseComputerHistory> repository;

        public AdminBLL_UseCPHis() : this(new GenericRepository<UseComputerHistory>())
        {

        }

        public AdminBLL_UseCPHis(IRepository<UseComputerHistory> _repository)
        {
            repository = _repository;
        }
        public IEnumerable<UseComputerHistory> GetAll()
        {
            IEnumerable<UseComputerHistory> data = repository.GetAll().ToList();
            foreach (UseComputerHistory i in data)
            {
                i.HourUsed = Convert.ToInt32(i._LogOut.Hour - i._LogIn.Hour);
            }
            repository.Save();
            return data;
        }
        public IEnumerable<object> Filter(IEnumerable<UseComputerHistory> UsedCP = null)
        {
            if (UsedCP == null) UsedCP = GetAll();
            var data = UsedCP.Select(p => new
            {
                p.ID_HistoryUseComputer,
                p.Customer.FirstName, 
                p.Customer.LastName,
                p.Computer.Name_PC,
                p._LogIn,
                p._LogOut,
                p.HourUsed
            });
            return data.ToList();
        }

        public void DelHis(string id)
        {

            repository.Delete(Convert.ToInt32(id));
            repository.Save();
        }
        public UseComputerHistory GetCusById(int id)
        {
            return repository.GetById(id);

        }

        public void Add(UseComputerHistory cus)
        {
            repository.Insert(cus);
            repository.Save();
        }

        
        public IEnumerable<object> Sort(SortEnum sort, string by)
        {
            if (string.Compare(by, "Name Customer") == 0)
                return Filter(repository.Sort<string>(sort, a => a.Customer.LastName));
            else return Filter(repository.Sort<string>(sort, a => a.Computer.Name_PC));
        }
        public List<object> Search(string search, SearchAcoountEnum searchby,string txtCbb = null)
        {

            if (searchby == SearchAcoountEnum.All)
            {
                return Filter(repository.GetAll()).ToList();
            }
            else if (searchby == SearchAcoountEnum.Name)
            {
                if(txtCbb == "Name PC")
                {
                    return Filter(repository.Search(search, p => p.Computer.Name_PC, true, true)).ToList();
                }
                else return Filter(repository.Search(search, p => p.Customer.FirstName + p.Customer.LastName, true, false)).ToList();
            }
            else return Filter(repository.Search(search, p => p.ID_HistoryUseComputer.ToString(), true, true)).ToList();
        }
    }
}
