using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetManagement.DTO;

namespace NetManagement.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Create();
        T GetById(int id);
        void Insert(T obj);
        void Update(T obj, int id, Action<T, T> ActionUpdate);
        void Delete(int obj);
        void Save();
        IEnumerable<T> Sort<Tkey>(SortEnum sort, System.Linq.Expressions.Expression<Func<T, Tkey>> expressions, IComparer<Tkey> action_compare = null);
    }
}
