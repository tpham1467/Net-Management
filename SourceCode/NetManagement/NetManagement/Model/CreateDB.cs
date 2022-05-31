using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace NetManagement.Model
{
    public class CreateDB :
       // CreateDatabaseIfNotExists<NetManagemetnContext> //CSDL chưa tồn tại sẽ tạo ra CSDL mới, nếu tồn tại rồi sẽ không khưởi tạo
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
                new StatusShift{ Description = "ads"},
                new StatusShift{ Description = "anahga"},
                new StatusShift{ Description = "ahah"}
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
                new Customer{ FirstName = "Pham Van Tien ", LastName = "Hai", DateOfBirth  = DateTime.Now, Phone = "0914142563", Email = "abd@gmail.com",Day_Create = DateTime.Now, Gender = false , Money = 1234, ID_Employee =2 },
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
                new Shift{ID_Employee = 2, Date_Work = DateTime.Now, Hour = 1, ID_StatusShift = 2},
                new Shift{ ID_Employee = 3, Date_Work = DateTime.Now, Hour = 2, ID_StatusShift = 1},
                new Shift{ ID_Employee = 1, Date_Work = DateTime.Now, Hour = 3, ID_StatusShift = 3},
            });
            context.SaveChanges();
            context.Products.AddRange(new Product[] {
                new Product { ID_Category = 1, NameProduct = "Mì Tôm", ID_Unit = 1, Price = 15 , Amount = 55},
                new Product {ID_Category = 2, NameProduct = "Bia", ID_Unit = 1, Price = 10 , Amount =34 },
                new Product { ID_Category = 2, NameProduct = "Pepsi", ID_Unit = 1, Price = 8 , Amount =88 },
                new Product {ID_Category = 3, NameProduct = "Coca Cola", ID_Unit = 1, Price = 8 , Amount = 883},
                new Product {ID_Category = 1, NameProduct = "Bánh Mì", ID_Unit = 1, Price = 10 , Amount = 11}
            });
            context.Orders.AddRange(new Order[]{
                new Order{ID_Customer = 5, DateOfOrder = DateTime.Now},
                new Order{ID_Customer = 6, DateOfOrder = DateTime.Now},
                new Order{ID_Customer = 4, DateOfOrder = DateTime.Now}
            });
            
            context.SaveChanges();
            context.OrderDetails.AddRange(new OrderDetail[]{
                new OrderDetail {ID_Product = 2, ID_Order = 1, _Description = "abc", Quality =1},
                new OrderDetail { ID_Product = 1, ID_Order = 1, _Description = "abcd", Quality =2},
                new OrderDetail { ID_Product = 3, ID_Order = 2, _Description = "abcd", Quality =3},
                new OrderDetail { ID_Product = 3, ID_Order = 3, _Description = "abcd", Quality =3},
            });

           
            context.Accounts.AddRange(new Account[]{
                new Account{ UserName_Acc = "Hpham123", Password_Acc = "Hpham321" , ID_Role = 3 , Id_User = 3 },
                new Account{ UserName_Acc = "Tpham123", Password_Acc = "Tpham321" , ID_Role = 2 , Id_User = 2 },
                new Account{ UserName_Acc = "VVien123", Password_Acc = "VVien321",  ID_Role = 1 , Id_User = 1 }
            });

            context.HistoryAccountUsers.AddRange(new HistoryAccountUser[]{
                new HistoryAccountUser{ ID_Customer = 4, ID_Employee = 1, ID_Computer =1, Direct = true, Money = 12321, Description = "egwjeh", Date = DateTime.Now},
                new HistoryAccountUser{ ID_Customer = 5, ID_Employee = 2, ID_Computer =2, Direct = false, Money = 13541, Description = "egwdgh", Date = DateTime.Now},
                new HistoryAccountUser{ ID_Customer = 6, ID_Employee = 3, ID_Computer =3, Direct = true, Money = 14321, Description = "egwdfgh", Date = DateTime.Now}
            });
            context.Statuses.AddRange(new Status[]
                {
                    new Status { NameTable ="Account"},
                    new Status { NameTable ="Computer" },
                    new Status { NameTable ="Customer"  },
                    new Status { NameTable ="Employee" },
                    new Status { NameTable ="HistoryAccountUser"  },
                    new Status { NameTable ="Order" },
                    new Status { NameTable ="OrderDetail"  },
                    new Status { NameTable ="Shift"  },
                    new Status { NameTable ="UseComputerHistory"  }
                });

            context.SaveChanges();

        }
    }
}
