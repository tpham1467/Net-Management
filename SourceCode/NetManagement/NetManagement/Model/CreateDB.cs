using System;
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
        //CreateDatabaseIfNotExists<NetManagemetnContext> //CSDL chưa tồn tại sẽ tạo ra CSDL mới, nếu tồn tại rồi sẽ không khưởi tạo
                                        //DropCreateDatabaseIfModelChanges<CSDL> // chỉ thay đổi Record thfi sẽ không tahy đổi, nếu thay đổi liên kết sẽ xóa đi cái cũ đê rkhwoir tạo cái mới
                                        DropCreateDatabaseAlways<NetManagemetnContext> // Mỗi lần chạy lại thì sẽ xóa cái cũ và tahy cái mới
    {
        protected override void Seed(NetManagemetnContext context)
        {
            context.Units.AddRange(new Unit[]{
                new Unit{ NameUnit = "Cai"},
                new Unit{ NameUnit = "Chai"},
                new Unit{NameUnit = "Goi"}
            });
            context.SalaryEmployees.AddRange(new SalaryEmployee[]
            {
                new SalaryEmployee{  Salary = 123},
                new SalaryEmployee{ Salary = 1234},
                new SalaryEmployee{ Salary = 1235}
            });
            context.Computers.AddRange(new Computer[]
            {
                new Computer{Name_PC = "May 1", ID_Customer=0, Status = true},
                new Computer{Name_PC = "May 2", ID_Customer=0, Status = false},
                new Computer{Name_PC = "May 3", ID_Customer=0, Status = true},
            });
            context.Categories.AddRange(new Category[]{
                new Category{ CategoryName = "Do An", Description = "Emdeplam"},
                new Category{ CategoryName = "Nuoc Uong", Description = "Emxinhlam"},
                new Category{ CategoryName = "Iteam", Description = "EmAnComChua"},
            });
            context.Users.AddRange(new User[]{
                new Employee{ FirstName = "Nguyen Van ", LastName = "Vien", DateOfBirth  = DateTime.Now, Phone = "0914142562", Email = "abc@gmail.com",Day_Create = DateTime.Now, Gender = true , ID_SalaryEmployee =1,Identify = "12345678"},
                new Employee{ FirstName = "Pham Van Tien ", LastName = "Truong", DateOfBirth  = DateTime.Now, Phone = "0914142563", Email = "abd@gmail.com",Day_Create = DateTime.Now, Gender = false , ID_SalaryEmployee =2,Identify = "12345679"},
                new Employee{ FirstName = "Pham Cong", LastName = "Huy1", DateOfBirth  = DateTime.Now, Phone = "0914142564", Email = "abe@gmail.com",Day_Create = DateTime.Now, Gender = true , ID_SalaryEmployee =3,Identify = "12345670"},
            });
            context.StatusShifts.AddRange(new StatusShift[]{
                new StatusShift{ Description = "Chua lam"},
                new StatusShift{ Description = "Da Lam"},
                new StatusShift{ Description = "Xin Phep Nghi"},
                new StatusShift{ Description = "Da Tra Luong"},
            });
            context.Roles.AddRange(new Role[]{
                new Role { NameRole = "Admin", Description = "Quản Lí Nhân Viên"},
                new Role { NameRole = "Employee", Description = "Quản Lí Khách Hàng"},
                new Role { NameRole = "Customer", Description = "Sử dụng dịch vụ"}
            });
            context.SaveChanges();
            List<User> data = context.Users.ToList();
            context.Users.AddRange(new User[]{
                new Customer{ FirstName = "Nguyen Van ", LastName = " Phong", DateOfBirth  = DateTime.Now, Phone = "0914142562", Email = "abc@gmail.com",Day_Create = DateTime.Now, Gender = true ,Money = 1234, ID_Employee =1 },
                new Customer{ FirstName = "Pham Van Tien ", LastName = "Hai", DateOfBirth  = DateTime.Now, Phone = "0914142563", Email = "abd@gmail.com",Day_Create = DateTime.Now, Gender = false , Money = 5000, ID_Employee =2 },
               new Customer{ FirstName = "Pham Cong", LastName = "Vu1", DateOfBirth  = DateTime.Now, Phone = "0914142564", Email = "abe@gmail.com",Day_Create = DateTime.Now, Gender = true , Money = 1234, ID_Employee =3 }
            });
          
            context.SaveChanges();
            context.UseComputerHistorys.AddRange(new UseComputerHistory[]
            {
                new UseComputerHistory{ ID_Customer = 4, ID_Computer =1,_LogIn = DateTime.Now, _LogOut = DateTime.Now, HourUsed = 1},
                new UseComputerHistory{ ID_Customer = 5, ID_Computer =2,_LogIn = DateTime.Now, _LogOut = DateTime.Now, HourUsed = 2},
                new UseComputerHistory{ ID_Customer = 6, ID_Computer =3,_LogIn = DateTime.Now, _LogOut = DateTime.Now, HourUsed = 3},
            });
            context.Shifts.AddRange(new Shift[]{
                new Shift{ID_Employee = 2, WorkedDate = DateTime.Now, WorkedHour = 1, ShiftStartTime = new SqlDateTime(2022,6,18,22,0 ,0).Value , ShiftEndTime =  new SqlDateTime(2022,6,18,23,0 ,0).Value,  ID_StatusShift = 1},
                new Shift{ ID_Employee = 3, WorkedDate = DateTime.Now, WorkedHour = 3,ShiftEndTime = DateTime.Now , ShiftStartTime = DateTime.Now, ID_StatusShift = 1},
                 new Shift{ID_Employee = 2, WorkedDate = DateTime.Now, WorkedHour = 1,ShiftEndTime = DateTime.Now , ShiftStartTime = DateTime.Now, ID_StatusShift = 1},
                new Shift{ ID_Employee = 3, WorkedDate = DateTime.Now, WorkedHour = 2,ShiftEndTime = DateTime.Now , ShiftStartTime = DateTime.Now, ID_StatusShift = 1},
                new Shift{ ID_Employee = 1, WorkedDate = DateTime.Now, WorkedHour = 3,ShiftEndTime = DateTime.Now , ShiftStartTime = DateTime.Now, ID_StatusShift = 1},
                 new Shift{ID_Employee = 2, WorkedDate = DateTime.Now, WorkedHour = 1,ShiftEndTime = DateTime.Now , ShiftStartTime = DateTime.Now, ID_StatusShift = 1},
                new Shift{ ID_Employee = 3, WorkedDate = DateTime.Now, WorkedHour = 2,ShiftEndTime = DateTime.Now , ShiftStartTime = DateTime.Now, ID_StatusShift = 1},
                new Shift{ ID_Employee = 1, WorkedDate = DateTime.Now, WorkedHour = 3,ShiftEndTime = DateTime.Now , ShiftStartTime = DateTime.Now, ID_StatusShift = 1},
            });
            context.SaveChanges();
            context.Products.AddRange(new Product[] {
                new Product { ID_Category = 1, NameProduct = "Mì Tôm", ID_Unit = 1},
                new Product {ID_Category = 2, NameProduct = "Bia", ID_Unit = 1 },
                new Product { ID_Category = 2, NameProduct = "Pepsi", ID_Unit = 1 },
                new Product {ID_Category = 3, NameProduct = "Coca Cola", ID_Unit = 1},
                new Product {ID_Category = 1, NameProduct = "Bánh Mì", ID_Unit = 1}
            });
            context.Orders.AddRange(new Order[]{
                new Order{ID_Customer = 5, DateOfOrder = DateTime.Now , status  = true},
                new Order{ID_Customer = 6, DateOfOrder = DateTime.Now , status = false} ,
                new Order{ID_Customer = 4, DateOfOrder = DateTime.Now , status = true}
            });
            
            context.SaveChanges();
            context.OrderDetails.AddRange(new OrderDetail[]{
                new OrderDetail {ID_Product = 2, ID_Order = 1, Description = "Ok", Quality =1, status = true},
                new OrderDetail { ID_Product = 1, ID_Order = 1, Description = "Ok", Quality =2 ,status = true},
                new OrderDetail { ID_Product = 3, ID_Order = 2, Description = "Ok", Quality =3 , status = true},
                 new OrderDetail { ID_Product = 2, ID_Order = 2, Description = "Het Hang", Quality =3 , status = false},
                new OrderDetail { ID_Product = 3, ID_Order = 3, Description = "abcd", Quality =3 , status = true},
            });

           
            context.Accounts.AddRange(new Account[]{
                new Account{ UserName_Acc = "HphamE", Password_Acc = "Hpham321" , ID_Role = 2 , Id_User = 3 , status = 0 , IsErase = 0},
                new Account{ UserName_Acc = "TphamE", Password_Acc = "Tpham321" , ID_Role = 2 , Id_User = 2 , status = 0 , IsErase = 0},
                new Account{ UserName_Acc = "VVienE", Password_Acc = "VVien321",  ID_Role = 2 , Id_User = 1  , status = 0 , IsErase = 0} ,
                 new Account{ UserName_Acc = "HphamC", Password_Acc = "Hpham321" , ID_Role = 1 , Id_User = 4  , status = 0  , IsErase = 0},
                new Account{ UserName_Acc = "TphamC", Password_Acc = "Tpham321" , ID_Role = 1 , Id_User = 5 ,  status = 0 , IsErase =0},
                new Account{ UserName_Acc = "VVienC", Password_Acc = "VVien321",  ID_Role = 1 , Id_User = 6 , status = 0 ,IsErase =0 }
            });

            context.HistoryAccountUsers.AddRange(new HistoryAccountUser[]{
                new HistoryAccountUser{ ID_Customer = 4, ID_Employee = 1, ID_Computer =1, Direct = true, Money = 12321, Description = "egwjeh", Date = DateTime.Now },
                new HistoryAccountUser{ ID_Customer = 5, ID_Employee = 2, ID_Computer =2, Direct = false, Money = 13541, Description = "egwdgh", Date = DateTime.Now},
                new HistoryAccountUser{ ID_Customer = 6, ID_Employee = 3, ID_Computer =3, Direct = true, Money = 14321, Description = "egwdfgh", Date = DateTime.Now}
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

            context.SaveChanges();

        }
    }
}
