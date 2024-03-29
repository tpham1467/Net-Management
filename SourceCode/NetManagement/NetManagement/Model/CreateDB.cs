﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace NetManagement.Model
{
    public class CreateDB :
     CreateDatabaseIfNotExists<NetManagemetnContext> //CSDL chưa tồn tại sẽ tạo ra CSDL mới, nếu tồn tại rồi sẽ không khưởi tạo
                                                     //DropCreateDatabaseIfModelChanges<CSDL> // chỉ thay đổi Record thfi sẽ không tahy đổi, nếu thay đổi liên kết sẽ xóa đi cái cũ đê rkhwoir tạo cái mới
                                                     //      DropCreateDatabaseAlways<NetManagemetnContext> // Mỗi lần chạy lại thì sẽ xóa cái cũ và tahy cái mới
    {
        protected override void Seed(NetManagemetnContext context)
        {

            context.Units.AddRange(new Unit[]{
                new Unit{NameUnit = "Cái"},
                new Unit{NameUnit = "Chai"},
                new Unit{NameUnit = "Gói"} ,
                new Unit{NameUnit = "Quà"}
            });
            context.SalaryEmployees.AddRange(new SalaryEmployee[]
            {
                new SalaryEmployee{ CoSalary = 123},
                new SalaryEmployee{ CoSalary = 1234},
                new SalaryEmployee{ CoSalary = 1235}
            });
            context.Computers.AddRange(new Computer[]
            {
                new Computer{Name_PC = "Máy 1", ID_Customer=0, Status = true},
                new Computer{Name_PC = "Máy 2", ID_Customer=0, Status = false},
                new Computer{Name_PC = "Máy 3", ID_Customer=0, Status = true},
            });
            context.Categories.AddRange(new Category[]{
                new Category{ CategoryName = "Đồ Ăn", Description = "Đồ bỏ vào miệng phải nhai mới nuốt được"},
                new Category{ CategoryName = "Nước uống", Description = "Đồ bỏ vào miệng nuốt luôn cũng được"},
                new Category{ CategoryName = "Card", Description = "Các loại card điện thoại, card game"},
            });
            context.Users.AddRange(new User[]{
                new Employee{ FirstName = "Nguyen Van", LastName = "Vien", DateOfBirth  = DateTime.Now, Phone = "0914142562", Email = "abc@gmail.com",Day_Create = DateTime.Now, Gender = true , ID_SalaryEmployee =1,Identify = "12345678"},
                new Employee{ FirstName = "Pham Van Tien", LastName = "Truong", DateOfBirth  = DateTime.Now, Phone = "0914142563", Email = "abd@gmail.com",Day_Create = DateTime.Now, Gender = false , ID_SalaryEmployee =2,Identify = "12345679"},
                new Employee{ FirstName = "Pham Cong", LastName = "Huy1", DateOfBirth  = DateTime.Now, Phone = "0914142564", Email = "abe@gmail.com",Day_Create = DateTime.Now, Gender = true , ID_SalaryEmployee =3,Identify = "12345670"},
            });
            context.StatusShifts.AddRange(new StatusShift[]{
                new StatusShift{ Description = "Chưa làm"},
                new StatusShift{ Description = "Dã Làm"},
                new StatusShift{ Description = "Xin Phép Nghĩ"},
                new StatusShift{ Description = "Đã Trả Lương"},
            });
            context.Roles.AddRange(new Role[]{
                new Role { NameRole = "Admin", Description = "Quản Lí Nhân Viên"},
                new Role { NameRole = "Employee", Description = "Quản Lí Khách Hàng"},
                new Role { NameRole = "Customer", Description = "Sử dụng dịch vụ"}
            });
            context.SaveChanges();
            context.Users.AddRange(new User[]{
                new Customer{ FirstName = "Nguyen Van", LastName = "Phong", DateOfBirth  = DateTime.Now, Phone = "0914142562", Email = "abc@gmail.com",Day_Create = DateTime.Now, Gender = true ,Money = 1234, ID_Employee =1 },
                new Customer{ FirstName = "Pham Van Tien", LastName = "Hai", DateOfBirth  = DateTime.Now, Phone = "0914142563", Email = "abd@gmail.com",Day_Create = DateTime.Now, Gender = false , Money = 5000, ID_Employee =2 },
               new Customer{ FirstName = "Pham Cong", LastName = "Vu1", DateOfBirth  = DateTime.Now, Phone = "0914142564", Email = "abe@gmail.com",Day_Create = DateTime.Now, Gender = true , Money = 1234, ID_Employee =3 }
            });

            context.SaveChanges();
            context.UseComputerHistorys.AddRange(new UseComputerHistory[]
            {
                new UseComputerHistory{ ID_Customer = 4, ID_Computer =1,_LogIn = DateTime.Now, _LogOut = DateTime.Now, HourUsed = 1},
                new UseComputerHistory{ ID_Customer = 5, ID_Computer =2,_LogIn = DateTime.Now, _LogOut = DateTime.Now, HourUsed = 2},
                new UseComputerHistory{ ID_Customer = 6, ID_Computer =3,_LogIn = DateTime.Now, _LogOut = DateTime.Now, HourUsed = 3},
                new UseComputerHistory{ ID_Customer = 5, ID_Computer =1,_LogIn = DateTime.Now, _LogOut = DateTime.Now, HourUsed = 1},
                new UseComputerHistory{ ID_Customer = 5, ID_Computer =2,_LogIn = DateTime.Now, _LogOut = DateTime.Now, HourUsed = 1},
                new UseComputerHistory{ ID_Customer = 4, ID_Computer =3,_LogIn = DateTime.Now, _LogOut = DateTime.Now, HourUsed = 2},
                new UseComputerHistory{ ID_Customer = 6, ID_Computer =1,_LogIn = DateTime.Now, _LogOut = DateTime.Now, HourUsed = 5},
                new UseComputerHistory{ ID_Customer = 4, ID_Computer =3,_LogIn = DateTime.Now, _LogOut = DateTime.Now, HourUsed = 2},
                new UseComputerHistory{ ID_Customer = 6, ID_Computer =3,_LogIn = DateTime.Now, _LogOut = DateTime.Now, HourUsed = 1},
            });
            context.Shifts.AddRange(new Shift[]{
                new Shift{ID_Employee = 2, WorkedDate = DateTime.Now, Hour = 3,ShiftStartTime = new SqlDateTime(2022,6,18,20,0 ,0).Value , ShiftEndTime =  new SqlDateTime(2022,6,18,23,0 ,0).Value,  ID_StatusShift = 1},
                new Shift{ID_Employee = 3, WorkedDate = DateTime.Now, Hour = 3,ShiftStartTime = new SqlDateTime(2022,6,18,14,0 ,0).Value , ShiftEndTime =  new SqlDateTime(2022,6,18,17,0 ,0).Value,  ID_StatusShift = 1},
                new Shift{ID_Employee = 3, WorkedDate = DateTime.Now, Hour = 3,ShiftStartTime = new SqlDateTime(2022,6,18,7,0 ,0).Value , ShiftEndTime =  new SqlDateTime(2022,6,18,10,0 ,0).Value, ID_StatusShift = 2},
                new Shift{ID_Employee = 3, WorkedDate = DateTime.Now, Hour = 3,ShiftStartTime = new SqlDateTime(2022,6,16,7,0 ,0).Value , ShiftEndTime =  new SqlDateTime(2022,6,16,10,0 ,0).Value, ID_StatusShift = 1},
                new Shift{ID_Employee = 2, WorkedDate = DateTime.Now, Hour = 4,ShiftStartTime = new SqlDateTime(2022,6,16,11,0 ,0).Value , ShiftEndTime =  new SqlDateTime(2022,6,16,15,0 ,0).Value, ID_StatusShift = 3},
                new Shift{ID_Employee = 3, WorkedDate = DateTime.Now, Hour = 3,ShiftStartTime = new SqlDateTime(2022,6,16,16,0 ,0).Value , ShiftEndTime =  new SqlDateTime(2022,6,16,19,0 ,0).Value, ID_StatusShift = 1},
                new Shift{ID_Employee = 1, WorkedDate = DateTime.Now, Hour = 3,ShiftStartTime = new SqlDateTime(2022,6,20,7,0 ,0).Value , ShiftEndTime =  new SqlDateTime(2022,6,20,10,0 ,0).Value, ID_StatusShift = 1},
                new Shift{ID_Employee = 2, WorkedDate = DateTime.Now, Hour = 4,ShiftStartTime = new SqlDateTime(2022,6,20,11,0 ,0).Value , ShiftEndTime =  new SqlDateTime(2022,6,20,15,0 ,0).Value, ID_StatusShift = 4},
                new Shift{ID_Employee = 3, WorkedDate = DateTime.Now, Hour = 4,ShiftStartTime = new SqlDateTime(2022,6,20,16,0 ,0).Value , ShiftEndTime =  new SqlDateTime(2022,6,20,20,0 ,0).Value, ID_StatusShift = 1},
                new Shift{ID_Employee = 1, WorkedDate = DateTime.Now, Hour = 4,ShiftStartTime = new SqlDateTime(2022,6,19,13,0 ,0).Value , ShiftEndTime =  new SqlDateTime(2022,6,19,17,0 ,0).Value, ID_StatusShift = 1},
                new Shift{ID_Employee = 3, WorkedDate = DateTime.Now, Hour = 2,ShiftStartTime = new SqlDateTime(2022,6,19,12,0 ,0).Value , ShiftEndTime =  new SqlDateTime(2022,6,19,14,0 ,0).Value, ID_StatusShift = 2},
                new Shift{ID_Employee = 1, WorkedDate = DateTime.Now, Hour = 4,ShiftStartTime = new SqlDateTime(2022,6,19,7,0 ,0).Value , ShiftEndTime =  new SqlDateTime(2022,6,19,11,0 ,0).Value, ID_StatusShift = 2},
                new Shift{ID_Employee = 2, WorkedDate = DateTime.Now, Hour = 4,ShiftStartTime = new SqlDateTime(2022,6,15,7,0 ,0).Value , ShiftEndTime =  new SqlDateTime(2022,6,15,11,0 ,0).Value, ID_StatusShift = 4},
                new Shift{ID_Employee = 3, WorkedDate = DateTime.Now, Hour = 4,ShiftStartTime = new SqlDateTime(2022,6,15,12,0 ,0).Value , ShiftEndTime =  new SqlDateTime(2022,6,15,16,0 ,0).Value, ID_StatusShift = 1},
                new Shift{ID_Employee = 1, WorkedDate = DateTime.Now, Hour = 3,ShiftStartTime = new SqlDateTime(2022,6,15,16,0 ,0).Value , ShiftEndTime =  new SqlDateTime(2022,6,15,19,0 ,0).Value, ID_StatusShift = 3},
            });
            context.SaveChanges();
            List<Shift> data = context.Shifts.ToList();
            context.Products.AddRange(new Product[] {
                new Product {ID_Category = 1, NameProduct = "Mỳ Tôm", ID_Unit = 1},
                new Product {ID_Category = 3, NameProduct = "Coca Cola", ID_Unit = 1},
                new Product {ID_Category = 3, NameProduct = "Bim Bim", ID_Unit = 1},
                new Product {ID_Category = 1, NameProduct = "Trứng", ID_Unit = 1} ,
                new Product {ID_Category = 1, NameProduct = "Bánh Mỳ", ID_Unit = 1} ,
                new Product {ID_Category = 1, NameProduct = "Cơm Gà", ID_Unit = 1} ,
                new Product {ID_Category = 1, NameProduct = "Xúc Xích", ID_Unit = 1} ,
                new Product {ID_Category = 1, NameProduct = "Bò Húc", ID_Unit = 1} ,
                new Product {ID_Category = 1, NameProduct = "Sting Vàng", ID_Unit = 1} ,
                new Product {ID_Category = 1, NameProduct = "Sting Đỏ", ID_Unit = 1} ,
                new Product {ID_Category = 1, NameProduct = "Nước Lọc", ID_Unit = 1} ,
                new Product {ID_Category = 1, NameProduct = "Nutifood", ID_Unit = 1} ,
                new Product {ID_Category = 1, NameProduct = "Viettel 10K", ID_Unit = 1} ,
                new Product {ID_Category = 1, NameProduct = "Viettel 50k", ID_Unit = 1} ,
                new Product {ID_Category = 1, NameProduct = "Garena 10K", ID_Unit = 1} ,
                new Product {ID_Category = 1, NameProduct = "Vinaphone 10K", ID_Unit = 1} ,
                new Product {ID_Category = 1, NameProduct = "Garena 50K", ID_Unit = 1} ,
                new Product {ID_Category = 1, NameProduct = "Mobiphone 10K", ID_Unit = 1} ,

            });
            context.Orders.AddRange(new Order[]{
                new Order{ID_Customer = 5, DateOfOrder = new SqlDateTime(2022,6,19,7,0 ,0).Value , status = true , Id_Computer = 1 },
                new Order{ID_Customer = 6, DateOfOrder = new SqlDateTime(2022,6,19,18,0 ,0).Value , status = true , Id_Computer = 2} ,
                new Order{ID_Customer = 4, DateOfOrder = new SqlDateTime(2022,6,18,10,0 ,0).Value , status = true , Id_Computer = 2},
                new Order{ID_Customer = 5, DateOfOrder = new SqlDateTime(2022,6,17,8,0 ,0).Value , status = true , Id_Computer = 3},
                new Order{ID_Customer = 4, DateOfOrder = new SqlDateTime(2022,6,16,9,0 ,0).Value , status = true , Id_Computer = 1},
            });

            context.SaveChanges();
            context.OrderDetails.AddRange(new OrderDetail[]{
                new OrderDetail { ID_Product = 2, ID_Order = 1, Description = "Ok", Quality =1, status = true},
                new OrderDetail { ID_Product = 1, ID_Order = 1, Description = "Ok", Quality =2 ,status = true},
                new OrderDetail { ID_Product = 3, ID_Order = 2, Description = "Ok", Quality =3 , status = true},
                new OrderDetail { ID_Product = 2, ID_Order = 2, Description = "Het Hang", Quality =3 , status = false},
                new OrderDetail { ID_Product = 3, ID_Order = 3, Description = "ok", Quality =3 , status = true},
                new OrderDetail { ID_Product = 5 ,ID_Order = 3, Description = "Banh Mi Mua Ngoai", Quality =1 , status = true},
                new OrderDetail { ID_Product = 11, ID_Order = 4, Description = "Ok", Quality =1, status = true},
                new OrderDetail { ID_Product = 13, ID_Order = 4, Description = "Ok", Quality =1 ,status = true},
                new OrderDetail { ID_Product = 6, ID_Order = 4, Description = "Cơm gà mua ngoài", Quality =3 , status = true},
                new OrderDetail { ID_Product = 12, ID_Order = 5, Description = "Het Hang", Quality =1, status = false},
                new OrderDetail { ID_Product = 17, ID_Order = 5, Description = "Ok", Quality =1 ,status = true},
            });


            context.Accounts.AddRange(new Account[]{
                new Account{ UserName_Acc = "HphamE", Password_Acc = "Hpham321" , ID_Role = 1 , Id_User = 3 , status = 0 , IsErase = 0},
                new Account{ UserName_Acc = "TphamE", Password_Acc = "Tpham321" , ID_Role = 2 , Id_User = 2 , status = 0 , IsErase = 0},
                new Account{ UserName_Acc = "VVienE", Password_Acc = "VVien321",  ID_Role = 2 , Id_User = 1  , status = 0 , IsErase = 0} ,
                new Account{ UserName_Acc = "HphamC", Password_Acc = "Hpham321" , ID_Role = 3 , Id_User = 4  , status = 0  , IsErase = 0},
                new Account{ UserName_Acc = "TphamC", Password_Acc = "Tpham321" , ID_Role = 3 , Id_User = 5 ,  status = 0 , IsErase =0},
                new Account{ UserName_Acc = "VVienC", Password_Acc = "VVien321",  ID_Role = 3, Id_User = 6 , status = 0 ,IsErase =0 }
            });

            context.HistoryAccountUsers.AddRange(new HistoryAccountUser[]{
                new HistoryAccountUser{ ID_Customer = 4, ID_Employee = 1, ID_Computer =1, Direct = true, Money = 12321, Description = "egwjeh", Date = new DateTime(2022,6,15,16,1 ,1)},
                new HistoryAccountUser{ ID_Customer = 5, ID_Employee = 2, ID_Computer =2, Direct = false, Money = 13541, Description = "egwdgh", Date = new DateTime(2022,6,15,16,1 ,1)},
                new HistoryAccountUser{ ID_Customer = 6, ID_Employee = 3, ID_Computer =3, Direct = true, Money = 14321, Description = "egwdfgh", Date = new DateTime(2022,6,15,16,1 ,1)},
                new HistoryAccountUser{ ID_Customer = 4, ID_Employee = 1, ID_Computer =1, Direct = true, Money = 45637, Description = "egwjeh", Date = new DateTime(2022,6,16,8,1 ,1) },
                new HistoryAccountUser{ ID_Customer = 5, ID_Employee = 2, ID_Computer =2, Direct = false, Money = 76543, Description = "egwdgh", Date = new DateTime(2022,6,16,11,0 ,0)},
                new HistoryAccountUser{ ID_Customer = 6, ID_Employee = 3, ID_Computer =3, Direct = false, Money = 12455, Description = "egwdfgh", Date = new DateTime(2022,6,17,13,0 ,0)},
                new HistoryAccountUser{ ID_Customer = 4, ID_Employee = 1, ID_Computer =1, Direct = true, Money = 76432, Description = "egwjeh", Date = new DateTime(2022,6,17,14,0 ,0) },
                new HistoryAccountUser{ ID_Customer = 5, ID_Employee = 2, ID_Computer =2, Direct = false, Money = 44567, Description = "egwdgh", Date = new DateTime(2022,6,18,8,0 ,0)},
                new HistoryAccountUser{ ID_Customer = 6, ID_Employee = 3, ID_Computer =3, Direct = true, Money = 24578, Description = "egwdfgh", Date = new DateTime(2022,6,18,7,0 ,0)},
                new HistoryAccountUser{ ID_Customer = 6, ID_Employee = 3, ID_Computer =3, Direct = false, Money = 14321, Description = "egwdfgh", Date = new DateTime(2022,6,19,11,0 ,0)},
                new HistoryAccountUser{ ID_Customer = 4, ID_Employee = 1, ID_Computer =1, Direct = true, Money = 50000, Description = "egwjeh", Date = new DateTime(2022,6,20,16,0 ,0) },
                new HistoryAccountUser{ ID_Customer = 5, ID_Employee = 2, ID_Computer =2, Direct = true, Money = 43532, Description = "egwdgh", Date = new DateTime(2022,6,20,9,0 ,0)},
                new HistoryAccountUser{ ID_Customer = 6, ID_Employee = 3, ID_Computer =3, Direct = true, Money = 12000, Description = "egwdfgh", Date = new DateTime(2022,6,20,8,0 ,0)},

            });
            context.Statuses.AddRange(new Status[]
                {
                    new Status { NameTable ="Account" , status = false},
                    new Status { NameTable ="Computer" , status = false },
                    new Status { NameTable ="Customer"   , status = false},
                    new Status { NameTable ="Employee" , status = false },
                    new Status { NameTable ="HistoryAccountUser"    , status = false},
                    new Status { NameTable ="Order"  , status = false},
                    new Status { NameTable ="OrderDetail"   , status = false},
                    new Status { NameTable ="Shift"  , status = false},
                    new Status { NameTable ="UseComputerHistory"  , status = false}
                });

            context.Inventories.AddRange(new Inventory[] {
                new Inventory {Amount = 20,ImportDay = Convert.ToDateTime("06-13-2022"), ExpiryDate = Convert.ToDateTime("06-13-2022"), ImportPrices = 12, SalePrice = 15, ID_Product = 1 , Init = 20 },
                new Inventory {Amount = 15,ImportDay = Convert.ToDateTime("06-13-2022"), ExpiryDate = Convert.ToDateTime("09-13-2023"), ImportPrices = 16, SalePrice = 18, ID_Product = 3 , Init = 15},
                new Inventory {Amount = 20,ImportDay = Convert.ToDateTime("06-13-2022"), ExpiryDate = Convert.ToDateTime("06-13-2022"), ImportPrices = 5, SalePrice = 10, ID_Product = 2 , Init = 10},
                new Inventory {Amount = 10,ImportDay = Convert.ToDateTime("06-13-2022"), ExpiryDate = Convert.ToDateTime("06-13-2022"), ImportPrices = 8, SalePrice = 10, ID_Product = 17, Init = 10},
                new Inventory {Amount = 30,ImportDay = Convert.ToDateTime("06-13-2022"), ExpiryDate = Convert.ToDateTime("06-13-2022"), ImportPrices = 5, SalePrice = 10, ID_Product = 4 , Init = 30},
                new Inventory {Amount = 10,ImportDay = Convert.ToDateTime("06-13-2022"), ExpiryDate = Convert.ToDateTime("06-13-2022"), ImportPrices = 8, SalePrice = 10, ID_Product = 11, Init = 10},
                new Inventory {Amount = 30,ImportDay = Convert.ToDateTime("06-13-2022"), ExpiryDate = Convert.ToDateTime("06-13-2022"), ImportPrices = 5, SalePrice = 10, ID_Product = 13, Init = 30},
                 new Inventory {Amount = 10,ImportDay = Convert.ToDateTime("06-13-2022"), ExpiryDate = Convert.ToDateTime("06-13-2022"), ImportPrices = 8, SalePrice = 10, ID_Product = 17, Init = 10},
                new Inventory {Amount = 30,ImportDay = Convert.ToDateTime("06-13-2022"), ExpiryDate = Convert.ToDateTime("06-13-2022"), ImportPrices = 5, SalePrice = 10, ID_Product = 7 , Init = 30},
                new Inventory {Amount = 10,ImportDay = Convert.ToDateTime("06-13-2022"), ExpiryDate = Convert.ToDateTime("06-13-2022"), ImportPrices = 8, SalePrice = 10, ID_Product = 8, Init = 10},
                new Inventory {Amount = 30,ImportDay = Convert.ToDateTime("06-13-2022"), ExpiryDate = Convert.ToDateTime("06-13-2022"), ImportPrices = 5, SalePrice = 10, ID_Product = 9, Init = 30}
            });
            context.SaveChanges();

        }
    }
}
