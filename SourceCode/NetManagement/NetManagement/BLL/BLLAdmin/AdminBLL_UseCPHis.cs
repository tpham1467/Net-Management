using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                //i.Customer.FullNameCus = i.Customer.FirstName +" "+ i.Customer.LastName;
                //i.HourUsed = Convert.ToInt32(i._LogOut.to);
            }
            repository.Save();
            return data;
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

        public List<UseComputerHistory> Sort(string txt)
        {
            List<UseComputerHistory> list = new List<UseComputerHistory>();
            if (txt == "Name")
            {
               // list = GetAll().OrderBy(p => p.Customer.FullNameCus).ToList();
            }
            if (txt == "ID_Computer")
            {
                list = GetAll().OrderBy(p => p.ID_Customer).ToList();
            }
            if (txt == "ID_History")
            {
                list = GetAll().OrderBy(p => p.ID_HistoryUseComputer).ToList();
            }
            return list;

        }
        public List<UseComputerHistory> Search(string s, string txt)
        {
            List<UseComputerHistory> data = new List<UseComputerHistory>();
            List<UseComputerHistory> data1 = GetAll().ToList();
            foreach (UseComputerHistory i in data1)
            {
               // i.Customer.FullNameCus = i.Customer.FirstName + i.Customer.LastName;
            }
            if (s == "Name")
            {
                foreach (UseComputerHistory i in data1)
                {
                    //if (i.Customer.FullNameCus.ToLower().Contains(txt.ToLower()))
                    //{
                    //    data.Add(i);
                    //    return data;
                    //}
                }
            }
            else if (s == "ID_Computer")
            {
                int id = Convert.ToInt32(txt);
                foreach (UseComputerHistory i in repository.GetAll())
                {
                    if (i.ID_Computer == id)
                    {
                        data.Add(i);
                    }
                }
            }
            else if (s == "ID_History")
            {
                int id = Convert.ToInt32(txt);
                foreach (UseComputerHistory i in repository.GetAll())
                {
                    if (i.ID_HistoryUseComputer == id)
                    {
                        data.Add(i);
                    }
                }
            }
            else if (s == "All")
            {
                data = GetAll().ToList();
            }
            return data;
        }
    }
}
