using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetManagement.DTO
{
    public class Search
    {
        public enum SearchEnum
        {
            All = -1,
            Id = 0,
            Name = 1,
        }
    }
    public class SearchCustomer : Search
    {
        public enum SearchCustomerEnum 
        {

        }
    }
    public class SearchHistoryUse : Search
    {
        public enum SearchHistoryUseEnum
        {
            ID_Cus = 0
        }
    }
    public class SearchOrderHistory : Search
    {
        public  enum SearchHistoryUseEnum
        {
            Name_Customer
        }
    }
}
