using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetManagement.Model;
using NetManagement.DTO;

namespace NetManagement.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {

        private static readonly CSDL _context = new CSDL();
        private readonly DbSet<T> table = null;
        public GenericRepository()    
        {
            //this._context = new CSDL();
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
            T Swap = table.Find(id);
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
        public void Save()
        {
            _context.SaveChanges();
        }
        public IEnumerable<T> Sort<Tkey>(SortEnum sort, System.Linq.Expressions.Expression<Func<T, Tkey>> expression, IComparer<Tkey> action_compare = null)
        {
            if (sort == SortEnum.Asc)
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
        public T Create()
        {
            return table.Create<T>();
        }

    }
}
