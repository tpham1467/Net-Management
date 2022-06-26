using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetManagement.BLL;
using NetManagement.Model;
using NetManagement.Repositories;

namespace NetManagement.BLL.BLLAdmin
{
    public class BLL_Unit
    {
        private IRepository<Unit> repository;
        private IRepository<Product> repository_product;

        public BLL_Unit() : this(new GenericRepository<Unit>() , new GenericRepository<Product>())
        {

        }

        public BLL_Unit(IRepository<Unit> _repository, IRepository<Product> _repository_product)
        {
            repository = _repository;
            repository_product = _repository_product;
        }
        public IEnumerable<Unit> GetAll()
        {

            List<Unit> data = repository.GetAll().ToList();
            return data;
        }
        public IEnumerable<object> Filter(IEnumerable<Unit> units = null)
        {
            if (units == null) units = GetAll();
            var data = units.Select(p => new
            {
                p.ID_Unit,
                p.NameUnit
            });
            return data.ToList();
        }
        public Unit GetbyID(int id)
        {
            return repository.GetById(id);
        }
        public Unit Create()
        {
            return repository.Create();
        }
        public void UpdateAdd(int id, Unit unit)
        {
            if (id == -1)
            {
                Add(unit);
            }
            else
            {
                Update(unit);
            }
        }
        public void UpdateDelegate(Unit unit1, Unit unit2)
        {
            unit1.NameUnit = unit2.NameUnit;
        }
        public void Add(Unit unit)
        {
            repository.Insert(unit);
            repository.Save();
        }
        public void Update(Unit unit)
        {
            repository.Update(unit, unit.ID_Unit, UpdateDelegate);
            List<string> navigation = new List<string>(); navigation.Add("Unit");
            foreach(var i in repository_product.Search(unit.ID_Unit.ToString(), p => p.ID_Unit.ToString(),
                false, false).ToList())
            {
                repository_product.Reload(i);
            }
            repository_product.Save();
            repository.Save();
        }
        public void DelUnit(int id)
        {
            repository.Delete(id);
            repository.Save();
        }
    }
}
