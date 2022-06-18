using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetManagement.Helper;

namespace NetManagement.DTO
{
    public class MoneyTopUp
    {
       public int Money { get; set; }
        public override string ToString()
        {
            return Helper.Convert.ConvertMoneyToVND(Money);
        }
    }
}
