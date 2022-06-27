using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetManagement.DTO;
using NetManagement.Model;
using NetManagement.Repositories;

namespace NetManagement.BLL.BLLAdmin
{
    public class AdminBLL_Category
    {
        private IRepository<Category> repository;
        private IRepository<Product> repository_product;
        public AdminBLL_Category() : this(new GenericRepository<Category>()  , new GenericRepository<Product>() ) 
        {

        }

        public AdminBLL_Category(IRepository<Category> _repository, IRepository<Product> _repository_product)
        {
            repository = _repository;
            repository_product = _repository_product;
        }
        public Category GetCTRById(int id)
        {
            return repository.GetById(id);
        }

        public IEnumerable<Category> GetAll()
        {
            List<Category> data = repository.GetAll().ToList();
            return data;
        }
        public IEnumerable<object> Filter(IEnumerable<Category> categories = null)
        {
            if (categories == null) categories = GetAll();
            var data = categories.Select(p => new { p.ID_Category, p.CategoryName, p.Description });
            return data.ToList();
        }


        public List<object> Search(string search, SearchAcoountEnum searchby)
        {

            if (searchby == SearchAcoountEnum.All)
            {
                return Filter(repository.GetAll()).ToList();
            }
            else if (searchby == SearchAcoountEnum.Name)
            {
                return Filter(repository.Search(search, p => p.CategoryName, true, false)).ToList();
            }
            else return Filter(repository.Search(search, p => p.ID_Category.ToString(), true, true)).ToList();
        }

        public void UpdateAdd(Category ctr, int k)
        {
            if (k == -1)
            {
                Add(ctr);

            }
            else
            {
                ctr.ID_Category = k;
                UpDate(ctr);
            }


        }
        public void UpDate(Category category)
        {
            try
            {   foreach(var i in repository_product.GetAll())
                {
                    if(i.ID_Category == category.ID_Category)
                    {
                        i.Category.CategoryName = category.CategoryName;
                    }
                }
                repository_product.Save();
                repository.Update(category, category.ID_Category, UpdateDelegate);
                repository.Save();
            }
            catch
            {
                throw new Exception();
            }
        }
        public void Add(Category cus)
        {
            repository.Insert(cus);
            repository.Save();
        }
        public void UpdateDelegate(Category c1, Category c2)
        {
            c1.CategoryName = c2.CategoryName; c1.Description = c2.Description;
        }
        public void Del(int id)
        {
            repository.Delete(id);
            repository.Save();
        }
        public IEnumerable<object> Sort(SortEnum sort, string by)
        {

            if (string.Compare(by, "Name Category") == 0)
                return Filter(repository.Sort<string>(sort, a => a.CategoryName));
            else return Filter(repository.Sort<int>(sort, a => a.ID_Category));
        }
        public Category Create()
        {
            return repository.Create();
        }

    }
}
