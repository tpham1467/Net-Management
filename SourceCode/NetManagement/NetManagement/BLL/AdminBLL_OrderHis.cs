using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetManagement.Repositories;
using NetManagement.Model;
using NetManagement.BLL;

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
            foreach (OrderDetail i in data)
            {
                i.Order.Customer.FullNameCus = i.Order.Customer.FirstName +" "+ i.Order.Customer.LastName;
            }
            repository.Save();
            return data;
        }

        public OrderDetail GetCusById(int id)
        {
            return repository.GetById(id);

        }

        

        

        public List<OrderDetail> Sort(string txt)
        {
            List<OrderDetail> list = new List<OrderDetail>();
            if (txt == "Name")
            {
                list = GetAll().OrderBy(p => p.Order.Customer.FullNameCus).ToList();
            }
            if (txt == "Quality")
            {
                list = GetAll().OrderBy(p => p.Quality).ToList();
            }
            return list;

        }
        public List<OrderDetail> Search(string s, string txt)
        {
            List<OrderDetail> data1 = GetAll().ToList();
            List<OrderDetail> data2 = new List<OrderDetail>();
            if (s == "Name Customer")
            {
                foreach (OrderDetail i in data1)
                {

                    if (i.Order.Customer.FullNameCus.ToLower().Contains(txt.ToLower()))
                    {
                        data2.Add(i);
                    }
                }
            }
            else if (s == "Name Product")
            {
                foreach (OrderDetail i in data1)
                {
                    if (i.Product.NameProduct.ToLower().Contains(txt.ToLower()))
                    {
                        data2.Add(i);
                    }
                }
            }
            return data2;
        }
    }
}
