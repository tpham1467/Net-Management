using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetManagement.DTO;
using NetManagement.Helper;
using NetManagement.Model;
using NetManagement.Repositories;
namespace NetManagement.BLL.BLLEmployee.BLLCheckInCheckOut
{
    public class BllCheckIncheckOut
    {
        private IRepository<Shift> repository;
        public BllCheckIncheckOut() : this(new GenericRepository<Shift>())
        {

        }
        public BllCheckIncheckOut(IRepository<Shift> _repository)
        {
            repository = _repository;
        }
        public IEnumerable<Shift> GetAll()
        {
            List<Shift> data = new List<Shift>();
            data = repository.GetAll().ToList();
            return data;
        }
        public IEnumerable<object> Filter(int id , StatusShift statusShift  ,IEnumerable<Shift> shifts = null  )
        {
            if (shifts == null) shifts = GetAll();
            var data = shifts.Where(p => p.ID_Employee == id && p.StatusShift.ID_StatusShift == statusShift.ID_StatusShift).Select(p =>

                new
                {
                    p.ID_Shift ,
                    StartTime = p.ShiftStartTime.ToString("hh:mm tt"),
                    EndTime =  p.ShiftEndTime.ToString("hh: mm tt") ,
                    WorkDate =  p.WorkedDate.ToString("MM / dd / yyyy") ,
                    Status = p.StatusShift.Description,
                });
            return data.ToList();
        }
        public int GetShiftForDay(int id_emloyee )
        {
            DateTime now = DateTime.Now;
            foreach(var i in GetAll())
            {
                if(i.ID_StatusShift == 1 && i.ID_Employee == id_emloyee && 
                    now.Day == i.WorkedDate.Day && i.WorkedDate.Month == now.Month &&  now.Hour >= i.ShiftStartTime.Hour && now.Hour <= i.ShiftEndTime.Hour)
                {
                    return i.ID_Shift;
                }
            }
            return -1;
        }
        public void CheckIn(int id_shift)
        {
            Shift shift = repository.GetById(id_shift);
            shift.CheckInTime = DateTime.Now;
            repository.Save();
        }
        public void CheckOut(int id_shift)
        {
            Shift shift = repository.GetById(id_shift);
            shift.CheckOutTime = DateTime.Now;
            shift.WorkedHour = shift.ShiftEndTime.Hour - shift.ShiftStartTime.Hour;
            shift.ID_StatusShift = 2;
            repository.Save();
        }
        public void SetShiftOff(int id_shift)
        {
            Shift shift = repository.GetById(id_shift);
            shift.ID_StatusShift = 3;
            repository.Save();
        }
        public float Total_WorkingDay(int id_emloyee)
        {
            return default;
        }
        public float TotalWorkingTime(int id_emloyee)
        {
            return default;
        }
        public float AveWorkingTime(int id_emloyee)
        {
            return default;
        }
        public float TotalDayoff(int id_emloyee)
        {
            return default;
        }
        public IEnumerable<object> Sort(int id , StatusShift statusShift, SortEnum sort, string by)
        {
            if (string.Compare(by, "Id") == 0)
               return Filter(id , statusShift , repository.Sort<int>(sort, p => p.ID_Shift) );
            else return Filter(id , statusShift, repository.Sort<DateTime>(sort ,p => p.WorkedDate ));
        }
    }
}
