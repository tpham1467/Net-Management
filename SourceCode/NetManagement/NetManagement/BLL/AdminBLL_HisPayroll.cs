using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetManagement.Model;
using NetManagement.Repositories;

namespace NetManagement.BLL
{
    public class AdminBLL_HisPayroll
    {
        private IRepository<HistoryPayroll> repository;

        public AdminBLL_HisPayroll() : this(new GenericRepository<HistoryPayroll>())
        {

        }

        public AdminBLL_HisPayroll(IRepository<HistoryPayroll> _repository)
        {
            repository = _repository;
        }
        public IEnumerable<HistoryPayroll> GetAll()
        {
            IEnumerable<HistoryPayroll> data = repository.GetAll().ToList();
            return data;
        }
        public List<HistoryPayroll> GetHisPayrollById(List<int> id)
        {
            IEnumerable<HistoryPayroll> data = repository.GetAll().ToList();
            List<HistoryPayroll> data2 = new List<HistoryPayroll>();
            foreach (int i in id)
            {
                foreach (HistoryPayroll his in data)
                {
                    if (i == his.ID_User)
                    {
                        his.PayrollDate = DateTime.Now.ToString();
                        data2.Add(his);
                    }
                }
            }
            repository.Save();
            return data2;
        }
        public List<HistoryPayroll> Sort(List<int> id,string txtcbb)
        {
            List<HistoryPayroll> list = GetHisPayrollById(id);
            if (txtcbb == "WorkHour")
            {
                list = list.OrderBy(p=>p.Shift.WorkedHour).ToList();
            }
            return list;
        }
        public void SaveChange()
        {
            repository.Save();
        }
    }
}
