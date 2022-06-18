using NetManagement.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;
using System.Linq.Expressions;
using NetManagement.DTO;
namespace NetManagement.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {

        private static readonly NetManagemetnContext _context = new NetManagemetnContext();
        private readonly DbSet<T> table = null;
        public GenericRepository()
        {
            //this._context = new NetManagemetnContext();
            this.table = _context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return table;
        }
        public T GetById(int id)
        {
            return table.Find(id);
        }
        public void Insert(T obj)
        {
            table.Add(obj);
        }
        public void Update(T obj, int id, Action<T, T> ActionUpdate)
        {
            T Swap = GetById(id);
            if (Swap == null)
            {
                return;
            }
            ActionUpdate(Swap, obj);
        }
        public void Delete(int id)
        {
            var data = table.Find(id);
            table.Remove(data);
        }
      
        public void Save(int i = 0)
        {
            try
            {
                int status = _context.SaveChanges();
                if (status > 0 && i == 1)
                {
                    MessageBox.Show("Thanh Comg");
                }
                else if (i == 1)
                {
                    MessageBox.Show("Khong Thanh Cong");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void Reload(T entity)
        {
            Type s = entity.GetType();
            if (entity.GetType().BaseType.Name == "Customer")
            {
                Customer customer = entity as Customer;
                var result = _context.Database.SqlQuery<int>("select _Money from Customer where ID_User = @id ", new SqlParameter("@id", customer.ID_User)).FirstOrDefault();
                customer.Money = Convert.ToInt32(result);
            }
            else
            {
                _context.Entry(entity).Reload();
            }

        }

        public IEnumerable<T> Sort<Tkey>(SortEnum sort, System.Linq.Expressions.Expression<Func<T, Tkey>> expression, IComparer<Tkey> action_compare = null) 
        {
            if (sort  == SortEnum.Asc)
            {
                if (action_compare == null)
                    return table.OrderBy(expression).ToList();
                else
                    return table.OrderBy(expression, action_compare);
            }
            else
            {
                if (action_compare == null)
                    return table.OrderByDescending(expression).ToList();
                else
                    return table.OrderByDescending(expression, action_compare);
            }
        }
    }
}
