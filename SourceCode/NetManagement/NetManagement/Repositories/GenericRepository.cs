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
        public IEnumerable<T> Search( string input, Func<T, string> key, bool IsContain, bool IsOnly , int num = 0)
        {
            if (string.IsNullOrEmpty(input)) return new List<T>();
            List<T> objectmatch = new List<T>();
            foreach (var i in table)
            {
                string keyofObject = key(i);
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

        public void Reload(List<string> navigation, bool IsColection, List<T> data = null)
        {
            if (data == null)
            {
                data = table.ToList();
            }
            for (int i = 0; i < data.Count; i++)
            {

                if (data[i].GetType().BaseType == typeof(Employee))
                {
                    Employee employee = data[i] as Employee;
                    var result = _context.Database.SqlQuery<int>("select CoSalary from SalaryEmployee where ID_SalaryEmployee = @id ", new SqlParameter("@id", employee.ID_SalaryEmployee)).FirstOrDefault();
                    employee.SalaryEmployee.CoSalary = result;
                }
                else
                {
                    foreach (var j in navigation)
                    {
                        if (!IsColection)
                            _context.Entry(data[i]).Reference(j).Load();
                        else
                            _context.Entry(data[i]).Collection(j).Load();
                    }
                }
            }

        }
    }
}
