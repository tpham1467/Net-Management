using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetManagement.DTO;
using NetManagement.Helper;
using NetManagement.Model;
using NetManagement.Repositories;
using System.Windows.Forms;
namespace NetManagement.BLL.BLLEmployee.BLLOrder
{
    public class BLlHandelOrder
    {
        private IRepository<Order> repository_Order;
        private IRepository<OrderDetail> repository_OrderDetail;
        private IRepository<Product> repository_Prodcut;
        private IRepository<Inventory> repository_Inventory;

        #region Contructor
        public BLlHandelOrder() : this(new GenericRepository<Order>() , new GenericRepository<OrderDetail>(), new GenericRepository<Product>()
            , new GenericRepository<Inventory>())
        {

        }
        public BLlHandelOrder(IRepository<Order> _repository_Order , IRepository<OrderDetail> _repository_OrderDetail
            , IRepository<Product> _repository_Prodcut , IRepository<Inventory> _repository_Inventory)
        {
            repository_Order = _repository_Order;
            repository_OrderDetail = _repository_OrderDetail;
            repository_Prodcut = _repository_Prodcut;
            repository_Inventory = _repository_Inventory;
        }
        #endregion

        #region Get List Object

        private Product GetProductById(int id)
        {
            return repository_Prodcut.GetById(id);
        }
        private List<Product> GetAllProDuct()
        {
            return repository_Prodcut.GetAll().ToList();
        }
        private List<Order> GetAllOrder()
        {
            return repository_Order.GetAll().ToList();
        }
        private List<OrderDetail> GetAllOrderDetail(int id)
        {
            return repository_OrderDetail.GetAll().Where(p => p.ID_Order == id).ToList();
        }
        private List<Inventory> GetAllInventoy()
        {
            return repository_Inventory.GetAll().ToList();
        }
        private List<Inventory> GetAllQualityProductExsit(int id)
        {
            return repository_Inventory.GetAll().Where(p => p.ID_Product == id).ToList();
        }
        #endregion

        #region Check Food

        private bool CheckOutsideFood(string name)
        {
            if (name == "Bánh Mỳ" || name == "Cơm Gà")
            {
                return true;
            }
            else return false;
        }

        public int CheckExsitProductInventory(string NameProduct, int id, int quality)
        {
            if (CheckOutsideFood(NameProduct) == true) return -1;
            int s = 0;
            foreach(var i in repository_Inventory.GetAll())
            {
                if(i.ID_Product == id && DateTime.Compare(i.ExpiryDate , DateTime.Now ) >= 0 && i.Amount != 0)
                {
                    s += i.Amount;
                }
            }
            if (s == 0) return -1;
            else if (s >= quality) return 0;
            else return s;
        }
        #endregion

        #region Filter 
        //public void ReLoadOrder()
        //{
        //    foreach(var i in GetAllOrder())
        //    {
        //        repository_Order.Reload(i);
        //        foreach(var j in GetAllOrderDetail(i.ID_Order))
        //        {
        //            repository_OrderDetail.Reload(j);
        //        }
        //    }
        //    repository_Order.Save();
        //    repository_OrderDetail.Save();

        //}
        public IEnumerable<Object> FilterOrder()
        {
         //   ReLoadOrder();
            var data = GetAllOrder().Where(p => p.status == false).Select(p =>
            new
            {
                p.ID_Order ,
                p.Customer.FirstName ,
                p.Customer.LastName ,
                p.Id_Computer ,
                DateTime = p.DateOfOrder.ToString("h:mm tt") ,
                p.Total,
            });
            return data.ToList();
        }
        public IEnumerable<Object> FilterOrderDeTail(int id)
        {
            var data = GetAllOrderDetail(id).Select(p =>
            new
            {
                p.Product.NameProduct ,
                p.Quality ,
                p.Description ,
                OutSideFood = CheckOutsideFood(p.Product.NameProduct) == true ? "Mua Ngoai" :"Trong Kho",
                Status = CheckExsitProductInventory(p.Product.NameProduct, p.ID_Product , p.Quality) == -1 ? "Không Có Sản Phẩm Hoặc Hết Hạn": (
                CheckExsitProductInventory(p.Product.NameProduct, p.ID_Product, p.Quality) == 0 ? "Đủ Cho Tất Cả": "Chỉ Đủ Cho"+
                CheckExsitProductInventory(p.Product.NameProduct, p.ID_Product, p.Quality).ToString()+" Cái"),
                Ok = CheckExsitProductInventory(p.Product.NameProduct, p.ID_Product, p.Quality) == -1 ? false : true ,
            });
            return data.ToList();
        }
        #endregion

        #region Handel
        public void DeleteProductFromInventory(int id_product , int quality)
        {
            List<Inventory> data = new List<Inventory>();
            foreach(var i in repository_Inventory.GetAll())
            {
                if(i.ID_Product == id_product)
                {
                    data.Add(i);
                }
            }
            data = data.OrderBy(p => p.ExpiryDate).ToList();
            for(int i =0;i<data.Count;i++)
            {
                if(data[i].Amount >= quality)
                {
                    data[i].Amount -= quality;
                    break;
                }
                else
                {
                    quality -= data[i].Amount;
                    data[i].Amount = 0;
                  
                }
            }
            repository_Inventory.Save();
        }
        public void Payment(int idorder , List<bool> ok)
        { 
            int j = 0;
            foreach(var i in GetAllOrderDetail(idorder))
            {
                
                i.status = ok[j];
                if(i.status == true)
                {
                    DeleteProductFromInventory(i.ID_Product ,i.Quality );
                }
                j++;
            }
            repository_OrderDetail.Save();
        }
        public void Fill(List<int> orders)
        {
            foreach(var i in orders)
            {
                Order order = repository_Order.GetById(i);
                order.status = true;
                foreach(var j in GetAllOrderDetail(order.ID_Order) )
                {
                    j.status = false;
                    j.Description = "Hủy Đơn";
                }
            }
            repository_Order.Save();
            repository_OrderDetail.Save();
        }
        #endregion
    }
}
