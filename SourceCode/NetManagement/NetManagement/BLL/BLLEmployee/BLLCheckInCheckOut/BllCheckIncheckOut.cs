﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetManagement.DTO;
using NetManagement.Helper;
using NetManagement.Model;
using NetManagement.Repositories;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NetManagement.BLL.BLLEmployee.BLLCheckInCheckOut
{
    public class BllCheckIncheckOut
    {
        private IRepository<Shift> repository;

        #region Contructor
        public BllCheckIncheckOut() : this(new GenericRepository<Shift>())
        {

        }
        public BllCheckIncheckOut(IRepository<Shift> _repository)
        {
            repository = _repository;
        }
        #endregion

        #region Get List Object
        public IEnumerable<Shift> GetAll()
        {
            List<Shift> data = new List<Shift>();
            data = repository.GetAll().ToList();
            return data;
        }
        public IEnumerable<object> Filter(int id, StatusShift statusShift, DateTime From, DateTime To , IEnumerable<Shift> shifts = null)
        {
            if (shifts == null) shifts = GetAll();
            var data = shifts.Where(p => p.ID_Employee == id && p.StatusShift.ID_StatusShift == statusShift.ID_StatusShift)
                .Where(p => DateTime.Compare(p.WorkedDate, From) > 0 && DateTime.Compare(p.WorkedDate, To) < 0).Select(p =>

                new
                {
                    p.ID_Shift,
                    StartTime = p.ShiftStartTime.ToString("hh:mm tt"),
                    EndTime = p.ShiftEndTime.ToString("hh: mm tt"),
                    WorkDate = p.WorkedDate.ToString("MM / dd / yyyy"), 
                    Status = p.StatusShift.Description ,
                });
            return data.ToList() ;
           
    }
        public IEnumerable<object> Filter(int id, StatusShift statusShift, IEnumerable<Shift> shifts = null)
        {
            if (shifts == null) shifts = GetAll();
            var data = shifts.Where(p => p.ID_Employee == id && p.StatusShift.ID_StatusShift == statusShift.ID_StatusShift).Select(p =>

                new
                {
                    p.ID_Shift,
                    StartTime = p.ShiftStartTime.ToString("hh:mm tt"),
                    EndTime = p.ShiftEndTime.ToString("hh: mm tt"),
                    WorkDate = p.WorkedDate.ToString("MM / dd / yyyy"),
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

        #endregion

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
            shift.Hour = shift.ShiftEndTime.Hour - shift.ShiftStartTime.Hour;
            shift.ID_StatusShift = 2;
            repository.Save();
        }
        public void SetShiftOff(int id_shift)
        {
            Shift shift = repository.GetById(id_shift);
            shift.ID_StatusShift = 3;
            repository.Save();
        }
        public int Total_WorkingDay(int id_emloyee)
        {
            List<DateTime> data = new List<DateTime>();
            foreach (var i in GetAll())
            {
                if (i.ID_StatusShift == 2)
                {
                    bool check = false;
                    foreach (var j in data)
                    {
                        if (j.Day == i.WorkedDate.Day)
                        {
                    
                            check = true;
                            break;
                        }
                    }
                    if (check == false)
                    {
                        data.Add(i.WorkedDate);
                    }

                }
            }
            return data.Count;
        }
        public float TotalWorkingTime(int id_emloyee)
        {
            int total = 0;
            foreach( var i in GetAll())
            {
                if(i.ID_StatusShift == 2)
                {
                    total += i.Hour;
                }
            }
            return total;
        }
        public float AveWorkingTime(int id_emloyee)
        {
            return TotalWorkingTime(id_emloyee) / (float)Total_WorkingDay(id_emloyee) ;
        }
        public IEnumerable<object> Sort(int id , StatusShift statusShift, SortEnum sort, string by)
        {
            if (string.Compare(by, "Id") == 0)
               return Filter(id , statusShift , repository.Sort<int>(sort, p => p.ID_Shift) );
            else return Filter(id , statusShift, repository.Sort<DateTime>(sort ,p => p.WorkedDate ));

        }
    }
}
