using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetManagement.Model;
using NetManagement.Repositories;
using NetManagement.DTO;
namespace NetManagement.BLL
{
    public class AdminBLL_Timekeeping
    {
        private IRepository<Shift> repository;

        public AdminBLL_Timekeeping() : this(new GenericRepository<Shift>())
        {

        }

        public AdminBLL_Timekeeping(IRepository<Shift> _repository)
        {
            repository = _repository;
        }
        public IEnumerable<Shift> GetAll()
        {
            IEnumerable<Shift> data = repository.GetAll().ToList();
            repository.Save();
            return data;
        }

        public IEnumerable<object> Filter(StatusShift statusShift ,  IEnumerable<Shift> sh = null)
        {
            if (sh == null) sh = GetAll();
            var data = sh.Where(p => (statusShift != null )?p.ID_StatusShift == statusShift.ID_StatusShift : (p.ID_StatusShift == 4 ? false : true) )
                .Select(
                    p =>
                        new
                        {
                            p.ID_Shift,
                            p.Employee.FirstName,
                            p.Employee.LastName,
                            WorkDate =  p.WorkedDate.ToString("MM/dd/yyyy"),
                            StartTime =  p.ShiftStartTime.ToString("hh: mm tt"),
                            EndTime = p.ShiftEndTime.ToString("hh: mm tt"),
                            p.StatusShift.Description
                        }
                );
            return data.ToList();
        }
        public IEnumerable<object> FilterFromDateToDate(DateTime From, DateTime To ,StatusShift statusShift = null)
        {
            List<Shift> shifts = new List<Shift>();
            foreach(var i in GetAll())
            {
                if(DateTime.Compare(From , i.WorkedDate ) < 0 && DateTime.Compare(To , i.WorkedDate) > 0)
                {
                    shifts.Add(i);
                }
            }
          
            var data = shifts.Where(p => (statusShift != null) ? p.ID_StatusShift == statusShift.ID_StatusShift : true)
                .Select(
                    p =>
                        new
                        {
                            p.ID_Shift,
                            p.Employee.FirstName,
                            p.Employee.LastName,
                            WorkDate = p.WorkedDate.ToString("MM/dd/yyyy"),
                            StartTime = p.ShiftStartTime.ToString("hh: mm tt"),
                            EndTime = p.ShiftEndTime.ToString("hh: mm tt"),
                            p.StatusShift.Description
                        }
                );
            return data.ToList();
        }


        public Shift GetCusById(int id)
        {
            return repository.GetById(id);

        }
        
        public IEnumerable<object> Sort(SortEnum sortEnum, string by)
        {
  
            if (by == "Worked Hour")
            {
                return Filter(new StatusShift { ID_StatusShift = 2 }, repository.Sort(sortEnum, p => p.Hour)).ToList();
            }
            else if (by == "Worked Date")
            {
                return Filter(new StatusShift { ID_StatusShift = 2 }, repository.Sort(sortEnum, p => p.WorkedDate)).ToList();
            }
            else
            {
                 return Filter(new StatusShift { ID_StatusShift = 2 }, repository.Sort(sortEnum, p => p.Employee.FirstName + p.Employee.LastName)).ToList();
            }
        }
        public IEnumerable<Object> Search(string input, SearchAcoountEnum searchAcoountEnum )
        {
            if(searchAcoountEnum == SearchAcoountEnum.Name)
            {
                return Filter(new StatusShift { ID_StatusShift = 2 }, repository.Search(input, p => p.Employee.FirstName + " " + p.Employee.LastName, true, false)).ToList();
               
            }
            else 
            {
                return Filter(new StatusShift { ID_StatusShift = 2 }, GetAll()).ToList();
            }
        }
        public Shift GetShiById(int i)
        {
            Shift sh =  repository.GetById(i);
            return sh;
        }
        public void DelShift(string s)
        {
            repository.Delete(Convert.ToInt32(s));
            repository.Save();
        }
  
        public void Add(Shift sh)
        {
            repository.Insert(sh);
            repository.Save();
        }

        public void UpdateDelegate(Shift c1, Shift c2)
        {
            c1.ShiftStartTime = c2.ShiftStartTime;
            c1.ShiftEndTime= c2.ShiftEndTime;
            c1.WorkedDate = c2.WorkedDate;
            c1.Hour = c2.Hour;
            c1.ID_StatusShift = c2.ID_StatusShift;
            c1.ID_Employee = c2.ID_Employee;
        }

        public void UpDate(Shift sh , int id)
        {
            repository.Update(sh, id, UpdateDelegate);
            repository.Save();
        }
        public Shift Create()
        {
            return repository.Create();
        }
    }
}
