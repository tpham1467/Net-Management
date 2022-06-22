using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetManagement.Model;
using NetManagement.Repositories;

namespace NetManagement.BLL
{
    public class AdminBLL_MerMana
    {
        private IRepository<Inventory> repository;

        public AdminBLL_MerMana() : this(new GenericRepository<Inventory>())
        {

        }

        public AdminBLL_MerMana(IRepository<Inventory> _repository)
        {
            repository = _repository;
        }
        public IEnumerable<Inventory> GetAll()
        {
            IEnumerable<Inventory> data = repository.GetAll().ToList();
            return data;
        }
        public Inventory GetProById(int id)
        {
            return repository.GetById(id);

        }
        public void DelMer(string s)
        {
            repository.Delete(Convert.ToInt32(s));
            repository.Save();
        }
        public void UpdateAdd(string str, Inventory pro)
        {
            bool add = true;
            foreach (Inventory i in GetAll())
            {
                if (i.ID_Inventory == Convert.ToInt32(str))
                {
                    add = false;
                    break;
                }
            }
            if (add)
            {
                Add(pro);
            }
            else
            {
                pro.ID_Inventory = Convert.ToInt32(str);
                UpDate(pro);
            }
            repository.Save();
        }
        public void Add(Inventory pro)
        {
            repository.Insert(pro);
            repository.Save();
            
            Inventory inven = GetAll().Last();
            repository.Save();
        }

        public Inventory CreateIn()
        {
            return repository.Create();
        }

        public void UpdateDelegate(Inventory p1, Inventory p2)
        {
            p1.ExpiryDate = p2.ExpiryDate; p1.ImportPrices = p2.ImportPrices; p1.SalePrice = p2.SalePrice;p1.ImportDay = p2.ImportDay;
            p1.ID_Inventory = p2.ID_Inventory; p1.ID_Product = p2.ID_Product;
        }

        public void UpDate(Inventory exPro)
        {
            repository.Update(exPro, exPro.ID_Inventory, UpdateDelegate);
            repository.Save();
        }
        public List<Inventory> Sort(string Inde,string txt)
        {
            List<Inventory> list = new List<Inventory>();
            if (txt== "ImportDay")
            {
                if (Inde == "Increase")
                {
                    list = GetAll().OrderBy(p => p.ImportDay).ToList();
                }
                if (Inde == "Decrease")
                {
                    list = GetAll().OrderByDescending(p => p.ImportDay).ToList();
                }
            }
            else if (txt == "ExpiryDate")
            {
                if (Inde == "Increase")
                {
                    list = GetAll().OrderBy(p => p.ExpiryDate).ToList();
                }
                if (Inde == "Decrease")
                {
                    list = GetAll().OrderByDescending(p => p.ExpiryDate).ToList();
                }
            }
            else if (txt == "ImportPrices")
            {
                if (Inde == "Increase")
                {
                    list = GetAll().OrderBy(p => p.ImportPrices).ToList();
                }
                if (Inde == "Decrease")
                {
                    list = GetAll().OrderByDescending(p => p.ImportPrices).ToList();
                }
            }
            else if (txt == "SalePrice")
            {
                if (Inde == "Increase")
                {
                    list = GetAll().OrderBy(p => p.SalePrice).ToList();
                }
                if (Inde == "Decrease")
                {
                    list = GetAll().OrderByDescending(p => p.SalePrice).ToList();
                }
            }
            return list;
        }
        public List<Inventory> Search(string txt, string txtcbb)
        {
            List<Inventory> data1 = GetAll().ToList();
            List<Inventory> data2 = new List<Inventory>();

            if (txtcbb == "Name Product")
            {
                if (txt != "")
                {
                    foreach (Inventory i in data1)
                    {
                        if (i.Product.NameProduct.ToLower().Contains(txt.ToLower()))
                        {
                            data2.Add(i);
                        }
                    }
                }
            }
            else if (txtcbb == "SalePrice")
            {
                if (txt != "")
                {
                    int cost = Convert.ToInt32(txt);
                    foreach (Inventory i in data1)
                    {
                        if (i.SalePrice == cost)
                        {
                            data2.Add(i);
                        }
                    }
                }
            }
            else data2= GetAll().ToList(); 
            return data2;
        }
    }
}
