using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetManagement.Helper;
namespace NetManagement.DTO
{
    public class FoodOrder
    {
        public string name { get; set; }
        public string price { get; set; }
        public FoodOderStatus  Status { get; set; }
        public override string ToString()
        {
            return default; // name + Helper.Convert.ConvertMoneyToVND(price);
        }
    }
}
