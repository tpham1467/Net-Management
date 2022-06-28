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
        private IRepository<Inventory> repository_inventory;
        public BLL_Unit() : this(new GenericRepository<Unit>() , new GenericRepository<Product>() , new GenericRepository<Inventory>())
        {

        }

        public BLL_Unit(IRepository<Unit> _repository, IRepository<Product> _repository_product , IRepository<Inventory> _repository_inventory)
        {
            repository = _repository;
            repository_product = _repository_product;
            repository_inventory = _repository_inventory;
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
                unit.ID_Unit = id;
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
            repository.Save();
            foreach (var i in repository_product.Search(unit.ID_Unit.ToString() , p => p.ID_Unit.ToString() , false , false ) )
            {
                repository_product.Reload(i, p => {
                    if (p is Unit unit1)
                    {
                        unit1.NameUnit = unit.NameUnit;
                    }
                }, "Unit");
            }
            repository_product.Save();
            foreach (var i in repository_inventory.Search(unit.ID_Unit.ToString(), p => p.Product.ID_Unit.ToString(), false, false))
            {
                repository_inventory.Reload(i, p => {
                    if (p is Product product)
                    {
                        product.Unit.NameUnit = unit.NameUnit;
                    }
                } , "Product");
            }
            repository_inventory.Save();

        }
        public void DelUnit(int id)
        {
            repository.Delete(id);
            repository.Save();
        }
    }
}
