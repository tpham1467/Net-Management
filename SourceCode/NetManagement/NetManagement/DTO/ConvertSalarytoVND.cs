using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetManagement.DTO
{
    public class ConvertSalarytoVND
    {
        public int id;
        public int Money { get; set; }
        public override string ToString()
        {
            return Helper.Convert.ConvertMoneyToVND(Money);
        }
    }
}
