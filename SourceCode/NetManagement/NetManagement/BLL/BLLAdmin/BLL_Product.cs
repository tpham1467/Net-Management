using NetManagement.DTO;
using NetManagement.Model;
using NetManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetManagement.BLL.BLLAdmin
{
    public class BLL_Product
    {
        private IRepository<Product> repository;

        public BLL_Product() : this(new GenericRepository<Product>())
        {

        }

        public BLL_Product(IRepository<Product> _repository)
        {
            repository = _repository;
        }
        public Product GetProductById(int id)
        {
            return repository.GetById(id);
        }

        public IEnumerable<Product> GetAll()
        {
            List<Product> data = repository.GetAll().ToList();
            return data;
        }
        public IEnumerable<object> Filter(IEnumerable<Product> products = null)
        {
            if (products == null) products = GetAll();
            var data = products.Select(p => new { p.ID_Product, p.NameProduct, p.Category.CategoryName, p.Unit.NameUnit });
            return data.ToList();
        }


        //public List<object> Search(string search, SearchAcoountEnum searchby)
        //{

        //    if (searchby == SearchAcoountEnum.All)
        //    {
        //        return Filter(repository.GetAll()).ToList();
        //    }
        //    else if (searchby == SearchAcoountEnum.Name)
        //    {
        //        return Filter(repository.Search(search, p => p.NameProduct, true, false)).ToList();
        //    }
        //    else return Filter(repository.Search(search, p => p.ID_Category.ToString(), true, true)).ToList();
        //}

        public void UpdateAdd(Product product, int check)
        {

            if (check == -1)
            {
                Add(product);
            }
            else
            {
                UpDate(product);
            }


        }
        public void UpDate(Product product)
        {
            repository.Update(product, product.ID_Product, UpdateDelegate);
            repository.Save();
        }
        public void Add(Product product)
        {
            repository.Insert(product);
            repository.Save();
        }
        public void UpdateDelegate(Product product, Product product1)
        {
            product.NameProduct = product1.NameProduct;
            product.ID_Category = product1.ID_Category;
            product.ID_Unit = product1.ID_Unit;
        }
        public void Del(string id)
        {
            repository.Delete(Convert.ToInt32(id));
            repository.Save();
        }
        //public IEnumerable<object> Sort(SortEnum sort, string by)
        //{

        //    if (string.Compare(by, "Name Category") == 0)
        //        return Filter(repository.Sort<string>(sort, a => a.CategoryName));
        //    else return Filter(repository.Sort<int>(sort, a => a.ID_Category));
        //}
        public Product Create()
        {
            return repository.Create();
        }
    }
}
