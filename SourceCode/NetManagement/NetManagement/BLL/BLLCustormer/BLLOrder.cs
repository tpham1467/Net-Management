using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetManagement.DTO;
using NetManagement.Helper;
using NetManagement.Model;
using NetManagement.Repositories;
namespace NetManagement.BLL.BLLCustormer
{
    public class BLLOrder
    {
        private IRepository<Order> repository_Order;
        private IRepository<OrderDetail> repository_OrderDetail;
        private IRepository<Product> repository_Prodcut;
        private IRepository<Inventory> repository_Inventory;

        #region Contructor
        public BLLOrder() : this(new GenericRepository<Order>(), new GenericRepository<OrderDetail>(), new GenericRepository<Product>()
            , new GenericRepository<Inventory>())
        {

        }
        public BLLOrder(IRepository<Order> _repository_Order, IRepository<OrderDetail> _repository_OrderDetail
            , IRepository<Product> _repository_Prodcut, IRepository<Inventory> _repository_Inventory)
        {
            repository_Order = _repository_Order;
            repository_OrderDetail = _repository_OrderDetail;
            repository_Prodcut = _repository_Prodcut;
            repository_Inventory = _repository_Inventory;
        }
        #endregion

        #region Get List Object

        public List<Product> GetAllProDuct()
        {
            return repository_Prodcut.GetAll().ToList();
        }
        #endregion

        #region 

        private bool CheckOutsideFood(string name)
        {
            if (name == "Bánh Mỳ" || name == "Cơm Gà")
            {
                return true;
            }
            else return false;
        }
        private bool CheckCookFood(string name)
        {
            if (name == "Mỳ Tôm Trứng")
            {
                return true;
            }
            else return false;
        }
        private int GetIdProductByName(string name)
        {
            foreach (var i in GetAllProDuct())
            {
                if (i.NameProduct == name)
                {
                    return i.ID_Product;
                }
            }
            return -1;
        }
        public void HandelOrder(List<(FoodOrder, int)> foodOrders, int Id_Cus , int idcomputer , int total)
        {
            if (foodOrders.Count > 0)
            {
                // Create order
                Order order = repository_Order.Create();
                order.ID_Customer = Id_Cus;
                order.DateOfOrder = DateTime.Now;
                order.Total = total;
                order.Id_Computer = idcomputer;
                repository_Order.Insert(order);
                repository_Order.Save();

                foreach (var i in foodOrders)
                {

                    if (CheckOutsideFood(i.Item1.name))
                    {
                        OrderDetail orderDetail = repository_OrderDetail.Create();
                        orderDetail.ID_Order = order.ID_Order;
                        orderDetail.Quality = i.Item2;
                        orderDetail.Description = i.Item1.name + " Mua Ngoài";
                        if (GetIdProductByName(i.Item1.name) == -1) throw new Exception();
                        else orderDetail.ID_Product = GetIdProductByName(i.Item1.name);
                        repository_OrderDetail.Insert(orderDetail);

                    }
                    else if (CheckCookFood(i.Item1.name))
                    {
                        OrderDetail orderDetail1 = repository_OrderDetail.Create();
                        orderDetail1.ID_Order = order.ID_Order;
                        orderDetail1.Quality = i.Item2;
                        orderDetail1.Description = "Mỳ Tôm-Mỳ Tôm Trứng";
                        orderDetail1.ID_Product = GetIdProductByName("Mỳ Tôm");


                        OrderDetail orderDetail2 = repository_OrderDetail.Create();
                        orderDetail2.ID_Order = order.ID_Order;
                        orderDetail2.Quality = i.Item2;
                        orderDetail2.Description = "Trứng-Mỳ Tôm Trứng";
                        orderDetail2.ID_Product = GetIdProductByName("Trứng");
                        repository_OrderDetail.Insert(orderDetail1);
                        repository_OrderDetail.Insert(orderDetail2);

                    }
                    else
                    {
                        OrderDetail orderDetail = repository_OrderDetail.Create();
                        orderDetail.ID_Order = order.ID_Order;
                        orderDetail.Quality = i.Item2;
                        orderDetail.Description = i.Item1.name + " Trong Kho";
                        if (GetIdProductByName(i.Item1.name) == -1) throw new Exception();
                        else orderDetail.ID_Product = GetIdProductByName(i.Item1.name);
                        repository_OrderDetail.Insert(orderDetail);

                    }
                }

                repository_OrderDetail.Save();
            }
            else
            {
                return;
            }
        }

        #endregion
    }
}
