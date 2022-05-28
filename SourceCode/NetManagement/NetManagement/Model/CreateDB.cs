using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetManagement.Model
{
    public class CreateDB :
       // CreateDatabaseIfNotExists<CSDL> //CSDL chưa tồn tại sẽ tạo ra CSDL mới, nếu tồn tại rồi sẽ không khưởi tạo
                                        //DropCreateDatabaseIfModelChanges<CSDL> // chỉ thay đổi Record thfi sẽ không tahy đổi, nếu thay đổi liên kết sẽ xóa đi cái cũ đê rkhwoir tạo cái mới
                                        DropCreateDatabaseAlways<CSDL> // Mỗi lần chạy lại thì sẽ xóa cái cũ và tahy cái mới
    {
        protected override void Seed(CSDL context)
        {
            context.Users.AddRange(new User[]{
                new User{ID_User = 1, FirstName = "Nguyen Van ", LastName = "Vien", DateOfBirth  = DateTime.Now, Phone = "0914142562", Email = "abc@gmail.com",Day_Create = DateTime.Now, Gender = true},
                new User{ID_User = 2, FirstName = "Pham Van Tien ", LastName = "Truong", DateOfBirth  = DateTime.Now, Phone = "0914142563", Email = "abd@gmail.com",Day_Create = DateTime.Now, Gender = false},
                new User{ID_User = 3, FirstName = "Pham Cong", LastName = "Huy", DateOfBirth  = DateTime.Now, Phone = "0914142564", Email = "abe@gmail.com",Day_Create = DateTime.Now, Gender = true},
            });
            context.Employees.AddRange(new Employee[]
            {
                new Employee{ID_Employee = 1, ID_SalaryEmployee =1,Identify = "12345678"},
                new Employee{ID_Employee = 2, ID_SalaryEmployee =2,Identify = "12345679"},
                new Employee{ID_Employee = 3, ID_SalaryEmployee =3,Identify = "12345670"},
            });
            context.SalaryEmployees.AddRange(new SalaryEmployee[]
            {
                new SalaryEmployee{ ID_SalaryEmployee  =1, Salary = 123},
                new SalaryEmployee{ ID_SalaryEmployee  =2, Salary = 1234},
                new SalaryEmployee{ ID_SalaryEmployee  =3, Salary = 1235}
            });
            context.Customers.AddRange(new Customer[]
            {
                new Customer{ID_Customer = 1, Money = 1234, ID_Employee =1},
                new Customer{ID_Customer = 2, Money = 123, ID_Employee =2},
                new Customer{ID_Customer = 3, Money = 1235, ID_Employee =3},
            });
            context.Computers.AddRange(new Computer[]
            {
                new Computer{ID_Computer = 1,Name_PC = "May 1", ID_Customer=1, Status = true},
                new Computer{ID_Computer = 2,Name_PC = "May 2", ID_Customer=2, Status = false},
                new Computer{ID_Computer = 3,Name_PC = "May 3", ID_Customer=3, Status = true},
            });
            context.UseComputerHistorys.AddRange(new UseComputerHistory[]
            {
                new UseComputerHistory{ID_HistoryUseComputer = 1, ID_Customer = 1, ID_Computer =1,_LogIn = DateTime.Now, _LogOut = DateTime.Now, HourUsed = 1},
                new UseComputerHistory{ID_HistoryUseComputer = 2, ID_Customer = 2, ID_Computer =2,_LogIn = DateTime.Now, _LogOut = DateTime.Now, HourUsed = 2},
                new UseComputerHistory{ID_HistoryUseComputer = 3, ID_Customer = 3, ID_Computer =3,_LogIn = DateTime.Now, _LogOut = DateTime.Now, HourUsed = 3},
            });
            context.Shifts.AddRange(new Shift[]{
                new Shift{ID_Shift = 1, ID_Employee = 2, Date_Work = DateTime.Now, Hour = 1, ID_StatusShift = 2},
                new Shift{ID_Shift = 2, ID_Employee = 3, Date_Work = DateTime.Now, Hour = 2, ID_StatusShift = 1},
                new Shift{ID_Shift = 3, ID_Employee = 1, Date_Work = DateTime.Now, Hour = 3, ID_StatusShift = 3},
            });
            context.Roles.AddRange(new Role[]{
                new Role {ID_Role = 1, NameRole = "Admin", Description = "Quản Lí Nhân Viên"},
                new Role {ID_Role = 2, NameRole = "Employee", Description = "Quản Lí Khách Hàng"},
                new Role {ID_Role = 3, NameRole = "Customer", Description = "Sử dụng dịch vụ"}
            });
            context.Products.AddRange(new Product[] {
                new Product {ID_Product = 1, ID_Category = 1, NameProduct = "Mì Tôm", ID_Unit = 1, Price = 15},
                new Product {ID_Product = 2, ID_Category = 2, NameProduct = "Bia", ID_Unit = 1, Price = 10},
                new Product {ID_Product = 3, ID_Category = 2, NameProduct = "Pepsi", ID_Unit = 1, Price = 8},
                new Product {ID_Product = 4, ID_Category = 3, NameProduct = "Coca Cola", ID_Unit = 1, Price = 8},
                new Product {ID_Product = 5, ID_Category = 1, NameProduct = "Bánh Mì", ID_Unit = 1, Price = 10}
            });
            context.OrderDetails.AddRange(new OrderDetail[]{
                new OrderDetail {ID_OrderDetail = 1, ID_Product = 2, ID_Order = 1, _Description = "abc", Quality =1},
                new OrderDetail {ID_OrderDetail = 2, ID_Product = 1, ID_Order = 2, _Description = "abcd", Quality =2},
                new OrderDetail {ID_OrderDetail = 3, ID_Product = 3, ID_Order = 3, _Description = "abcd", Quality =3},
            });
            context.StatusShifts.AddRange(new StatusShift[]{
                new StatusShift{ID_StatusShift =1, Description = "ads"},
                new StatusShift{ID_StatusShift =2, Description = "anahga"},
                new StatusShift{ID_StatusShift =3, Description = "ahah"}
            });
            context.Orders.AddRange(new Order[]{
                new Order{ID_Order =1, ID_Customer = 2, DateOfOrder = DateTime.Now},
                new Order{ID_Order =2, ID_Customer = 3, DateOfOrder = DateTime.Now},
                new Order{ID_Order =3, ID_Customer = 1, DateOfOrder = DateTime.Now}
            });
            context.Accounts.AddRange(new Account[]{
                new Account{ID_Account =01, UserName_Acc = "Hpham123", Password_Acc = "Hpham321" , ID_Role = 1 , Id_User = 3 },
                new Account{ID_Account =02, UserName_Acc = "Tpham123", Password_Acc = "Tpham321" , ID_Role = 2 , Id_User = 2 },
                new Account{ID_Account =03, UserName_Acc = "VVien123", Password_Acc = "VVien321",  ID_Role = 3 , Id_User = 1 }
            });
            context.Categories.AddRange(new Category[]{
                new Category{ID_Category = 1, CategoryName = "Do An", Description = "Emdeplam"},
                new Category{ID_Category = 2, CategoryName = "Nuoc Uong", Description = "Emxinhlam"},
                new Category{ID_Category = 3, CategoryName = "Iteam", Description = "EmAnComChua"},
            });
            context.HistoryAccountUsers.AddRange(new HistoryAccountUser[]{
                new HistoryAccountUser{Id_HistoryAccountUser = 1, ID_Customer = 1, ID_Employee = 1, ID_Computer =1, Direct = true, Money = 12321, Description = "egwjeh", Date = DateTime.Now},
                new HistoryAccountUser{Id_HistoryAccountUser = 2, ID_Customer = 2, ID_Employee = 2, ID_Computer =2, Direct = false, Money = 13541, Description = "egwdgh", Date = DateTime.Now},
                new HistoryAccountUser{Id_HistoryAccountUser = 3, ID_Customer = 3, ID_Employee = 3, ID_Computer =3, Direct = true, Money = 14321, Description = "egwdfgh", Date = DateTime.Now}
            });
            context.Inventories.AddRange(new Inventory[]{
                new Inventory{ID_Product = 1, Amount = 13},
                new Inventory{ID_Product = 2, Amount = 43},
                new Inventory{ID_Product = 3, Amount = 23},
                new Inventory{ID_Product = 4, Amount = 33},
                new Inventory{ID_Product = 5, Amount = 53}
            });
            context.Units.AddRange(new Unit[]{
                new Unit{ID_Unit = 1, NameUnit = "Cai"},
                new Unit{ID_Unit = 2, NameUnit = "Chai"},
                new Unit{ID_Unit = 3, NameUnit = "Goi"}
            });
        }
    }
}
