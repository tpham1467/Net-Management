using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetManagement.Model;
using NetManagement.Repositories;

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
            foreach (Shift i in data)
            {
                i.WorkedHour = i.ShiftEndTime.Hour - i.ShiftEndTime.Hour;
            }
            repository.Save();
            return data;
        }
        public IEnumerable<object> Filter(StatusShift statusShift, IEnumerable<Shift> shifts = null)
        {
            if (shifts == null) shifts = GetAll();
            var data = shifts.Where(p=>p.StatusShift.ID_StatusShift == statusShift.ID_StatusShift).Select(p =>

                new
                {
                    p.ID_Employee,
                    p.ID_Shift,
                    Name = p.Employee.FirstName + p.Employee.LastName,
                    StartTime = p.ShiftStartTime.ToString("hh:mm tt"),
                    EndTime = p.ShiftEndTime.ToString("hh: mm tt"),
                    WorkDate = p.WorkedDate.ToString("MM / dd / yyyy"),
                    Status = p.StatusShift.Description,
                    

                });
            return data.ToList();
        }


        public IEnumerable<object> Filter(IEnumerable<Shift> sh = null)
        {
            if (sh == null) sh = GetAll();
            var data = sh
                .Select(
                    p =>
                        new
                        {
                            p.ID_Shift,
                            p.Employee.FirstName,
                            p.Employee.LastName,
                            p.WorkedDate,
                            p.ShiftStartTime,
                            p.ShiftEndTime,
                            p.StatusShift.Description
                        }
                );
            return data.ToList();
        }

        public Shift GetCusById(int id)
        {
            return repository.GetById(id);

        }
        
        public List<Shift> Sort(string txt)
        {
            List<Shift> list = new List<Shift>();
            if (txt == "Worked Hour")
            {
                list = GetAll().OrderBy(p => p.WorkedHour).ToList();
            }
            else if (txt == "Worked Date")
            {
                list = GetAll().OrderBy(p => p.WorkedDate).ToList();
            }
            return list;
        }
        public List<Shift> Search(string txt, string txtcbb)
        {
            List<Shift> data1 = GetAll().ToList();
            List<Shift> data2 = new List<Shift>();
            if(txtcbb == "Name Employee")
            {
                foreach (Shift i in data1)
                {
                    //if (i.Employee.FullNameEm.ToLower().Contains(txt.ToLower()))
                    //{
                    //    data2.Add(i);
                    //}
                }
            }
            else if(txt == "" && txtcbb != "All")
            {
                foreach (Shift i in data1)
                {
                    string ch = i.WorkedDate.ToString("M/dd/yyyy");
                    if (ch == txtcbb)
                    {
                        data2.Add(i);
                    }
                }
            }
            else
            {
                return data1;
            }
            return data2;
        }
        public Shift GetShiById(int i)
        {
            Shift sh =  repository.GetById(i);
            return sh;
        }
        public List<Shift> updateIDStatus(string s)
        {
            List<Shift> shi = GetAll().ToList<Shift>();
            foreach (Shift em in shi)
            {
                if(em.StatusShift.Description == "Đã làm")
                {
                    em.ID_StatusShift = 4;
                }
            }
            repository.Save();
            return shi;
        }
        public void DelShift(string s)
        {
            repository.Delete(Convert.ToInt32(s));
            repository.Save();
        }
        public void UpdateAdd(string id, Shift sh,string status)
        {
            bool add = true;
            foreach (Shift i in GetAll())
            {
                if(id != "")
                {
                    if (i.ID_Shift == Convert.ToInt32(id))
                    {
                        add = false;
                        break;
                    }
                }
            }
            if (add)
            {
                Add(sh);
            }
            else
            {
                if(status == "Đã làm")
                {
                    sh.ID_StatusShift = 1;
                }
                if (status == "Chưa làm")
                {
                    sh.ID_StatusShift = 2;
                }
                if (status == "Nghỉ phép")
                {
                    sh.ID_StatusShift = 3;
                }
                sh.ID_Shift = Convert.ToInt32(id);
                UpDate(sh);
            }
        }
        public void Add(Shift sh)
        {
            sh.ID_StatusShift = 2;
            repository.Insert(sh);
            repository.Save();
        }

        public void UpdateDelegate(Shift c1, Shift c2)
        {
            c1.ShiftStartTime = c2.ShiftStartTime;
            c1.ShiftEndTime= c2.ShiftEndTime;
            c1.WorkedDate = c2.WorkedDate;
            c1.ID_Employee = c2.ID_Employee;
            c1.ID_StatusShift = c2.ID_StatusShift;
        }

        public void UpDate(Shift sh)
        {
            repository.Update(sh, sh.ID_Shift, UpdateDelegate);
            repository.Save();
        }
        public Shift Create()
        {
            return repository.Create();
        }
        public List<Shift> ViewDay()
        {
            List<Shift> data1 = GetAll().ToList();
            List<Shift> data2 = new List<Shift>();
            foreach (Shift s in data1)
            {

            }
            return data2;
        }
    }
}
