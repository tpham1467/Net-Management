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
        void Reload(T obj);
        void Reload(List<string> naavigation , bool IsCollection ,  List<T> data  = null);
        IEnumerable<T> Sort<Tkey>(SortEnum sort, System.Linq.Expressions.Expression<Func<T, Tkey>> expressions, IComparer<Tkey> action_compare = null);
        IEnumerable<T> Search(string input, Func<T, string> key, bool IsContain, bool IsOnly, int num = 0);
        IEnumerable<object> Filter(Func<T, Object> func, Func<T, bool> where = null ,  IEnumerable<T> data = null);
    }
}
