using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetManagement.Repositories;
using NetManagement.Model;
using NetManagement.BLL;
using NetManagement.DTO;

namespace NetManagement.BLL
{
    public class AdminBLL_OrderHis
    {
        private IRepository<OrderDetail> repository;

        public AdminBLL_OrderHis() : this(new GenericRepository<OrderDetail>())
        {

        }

        public AdminBLL_OrderHis(IRepository<OrderDetail> _repository)
        {
            repository = _repository;
        }
        public IEnumerable<OrderDetail> GetAll()
        {
            IEnumerable<OrderDetail> data = repository.GetAll().ToList();
            return data;
        }
        public IEnumerable<object> Filter(IEnumerable<OrderDetail> orderHis = null)
        {
            if (orderHis == null) orderHis = GetAll();
            var data = orderHis.Select(p => new
            {
                p.ID_OrderDetail,
                p.Order.Customer.FirstName,
                p.Order.Customer.LastName,
                p.Product.NameProduct,
                p.Product.Category.CategoryName,
                p.Description,
                p.Quality 
            });
            return data.ToList();
        }
        public IEnumerable<object> Sort(SortEnum sort, string by)
        {

            if (string.Compare(by, "Quality") == 0)
                return Filter(repository.Sort<int>(sort, a => a.Quality));
            else return Filter(repository.Sort<string>(sort, a => a.Order.Customer.LastName));
        }
        public List<object> Search(string search,string txtCbb)
        {
            if(txtCbb == "All")
            {
                return Filter(repository.GetAll()).ToList();
            }
            if (txtCbb == "Name Customer")
            {
                return Filter(repository.Search(search, p => p.Order.Customer.FirstName + p.Order.Customer.LastName, true, false)).ToList();
            }
            else return Filter(repository.Search(search, p => p.Product.NameProduct, true, false)).ToList();
        }

        public OrderDetail GetCusById(int id)
        {
            return repository.GetById(id);

        }

        

        

        public List<OrderDetail> Sort(string txt)
        {
            List<OrderDetail> list = new List<OrderDetail>();
            if (txt == "Name Customer")
            {
               list = GetAll().OrderBy(p => p.Order.Customer.LastName).ToList();
            }
            if (txt == "Quality")
            {
                list = GetAll().OrderBy(p => p.Quality).ToList();
            }
            return list;

        }
        
    }
}
