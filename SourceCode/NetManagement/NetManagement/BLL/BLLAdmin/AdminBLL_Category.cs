using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetManagement.Model;
using NetManagement.Repositories;

namespace NetManagement.BLL
{
    public class AdminBLL_Category
    {
        private IRepository<Category> repository;

        public AdminBLL_Category() : this(new GenericRepository<Category>())
        {

        }

        public AdminBLL_Category(IRepository<Category> _repository)
        {
            repository = _repository;
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


        public List<Category> Search(string s, string txt)
        {
            List<Category> data1 = GetAll().ToList();
            List<Category> data2 = new List<Category>();

            if (s == "ID_Category")
            {
                if (txt != "")
                {
                    int id = Convert.ToInt32(txt);
                    foreach (Category i in repository.GetAll())
                    {
                        if (i.ID_Category == id)
                        {
                            data2.Add(i);
                        }
                    }
                }
            }
            else if (s == "Name")
            {
                foreach (Category i in data1)
                {
                    if (i.CategoryName.ToLower().Contains(txt.ToLower()))
                    {
                        data2.Add(i);
                    }
                }
            }
            return data2;
        }

        public void UpdateAdd(Category ctr, int k)
        {
            bool add = true;
            foreach (Category i in GetAll())
            {
                if (i.ID_Category == k)
                {
                    add = false;
                    break;
                }
            }
            if (add)
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
            repository.Update(category, category.ID_Category, UpdateDelegate);
            repository.Save();
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
        public void Del(string id)
        {
            repository.Delete(Convert.ToInt32(id));
            repository.Save();
        }
        public List<Category> Sort(string txt1, string txt2)
        {
            List<Category> list = new List<Category>();
            if (txt1 == "Name")
            {
                if (txt2 == "Increase" || txt2 == "")
                {
                    list = GetAll().OrderBy(p => p.CategoryName).ToList();
                }
                else if (txt2 == "Decrease")
                {
                    list = GetAll().OrderByDescending(p => p.CategoryName).ToList();
                }
            }
            if (txt1 == "ID_Category")
            {
                if (txt2 == "Increase" || txt2 == "")
                {
                    list = GetAll().OrderBy(p => p.ID_Category).ToList();
                }
                else if (txt2 == "Decrease")
                {
                    list = GetAll().OrderByDescending(p => p.ID_Category).ToList();
                }
            }
            return list;

        }

    }
}
