using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetManagement.DTO;
using NetManagement.Helper;
using NetManagement.Model;
using NetManagement.Repositories;
namespace NetManagement.BLL.BLLCustormer
{
    public class BLLOrder
    {
        private IRepository<Order> repository_order;
        private IRepository<OrderDetail> repository_oderDetail;
        private IRepository<Product> repository_product;

        public BLLOrder() : this(new GenericRepository<Shift>())
        {

        }
        public BLLOrder(IRepository<Shift> _repository)
        {
           // repository = _repository;
        }
    }
}
