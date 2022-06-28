using NetManagement.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;
using System.Linq.Expressions;
using NetManagement.DTO;
using System.Data.Entity.Infrastructure;

namespace NetManagement.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {

        private static readonly NetManagemetnContext _context = new NetManagemetnContext();
        private readonly DbSet<T> table;
        public GenericRepository()
        {
         
            //  this._context = new NetManagemetnContext();
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

        public void Save()
        {
            try
            {
                int status = _context.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {

                string s = "Bạn Vui Lòng Kiểm Tra Lại Các Thuộc Tính Sau :" + '\n';
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        s += "Property:   " + validationError.PropertyName + "   Error:   " + validationError.ErrorMessage + "   Giá Trị :" + entityValidationErrors.Entry.CurrentValues.GetValue<object>(validationError.PropertyName) + '\n';         
                    }
                    DbEntityEntry entityEntry = entityValidationErrors.Entry;
                    entityEntry.State = EntityState.Detached;
                }                
                throw new Exception(s);
            }
        }

        public void Reload(T entity, Action<object> action = null ,string navigation = null )
        {
            if (action != null)
            {
                var _object = _context.Entry(entity).Reference(navigation).CurrentValue;
                action(_object);
            }
            else
            _context.Entry(entity).Reload();    
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
        public IEnumerable<T> Search( string input, Func<T, string> key, bool IsContain, bool IsOnly )
        {
            input = input.ToLower();
            if (string.IsNullOrEmpty(input)) return new List<T>();
            List<T> objectmatch = new List<T>();
            foreach (var i in table)
            {
                string keyofObject = key(i).ToLower();
                if (IsContain)
                {
                    if (keyofObject.Contains(input))
                        objectmatch.Add(i);
                }
                else
                {
                    if (string.Equals(keyofObject, input))
                    {
                        objectmatch.Add(i);
                        if (IsOnly) return objectmatch;
                    }
                }
            }
            return objectmatch;
        }
        public IEnumerable<object> Filter(Func<T, Object> func  , Func<T, bool> where = null , IEnumerable<T> data = null)
        {
            if (data == null)
            {
                if (where != null) data = data.Where(where);
                return table.Select(func);
            }
            else
            {
                 if (where != null) data = data.Where(where);
                return data.Select(func);
            }
        }

    }
}
