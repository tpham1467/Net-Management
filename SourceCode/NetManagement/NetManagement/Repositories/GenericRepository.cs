using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetManagement.Model;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NetManagement.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {

        private readonly NetManagemetnContext _context = null;
        private readonly DbSet<T> table = null;
        public GenericRepository()
        {
            this._context = new NetManagemetnContext();
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
        public void Update(T obj ,int id ,  Action<T , T > ActionUpdate)
        {  
            T Swap = GetById(id);
            if (Swap == null)
            {
                return;                
            }
            ActionUpdate(Swap, obj);
            Console.WriteLine("ddd");
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

    }
}
