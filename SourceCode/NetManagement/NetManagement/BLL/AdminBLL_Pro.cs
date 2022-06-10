using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetManagement.Model;
using NetManagement.Repositories;

namespace NetManagement.BLL
{
    public class AdminBLL_Pro
    {
        private IRepository<Product> repository;

        public AdminBLL_Pro() : this(new GenericRepository<Product>())
        {

        }

        public AdminBLL_Pro(IRepository<Product> _repository)
        {
            repository = _repository;
        }
        public IEnumerable<Product> GetAll()
        {
            IEnumerable<Product> data = repository.GetAll().ToList();
            repository.Save();
            return data;
        }
        
    }
}
