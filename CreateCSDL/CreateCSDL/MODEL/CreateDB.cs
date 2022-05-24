using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCSDL.MODEL
{
    public class CreateDB: 
        CreateDatabaseIfNotExists<CSDL> //CSDL chưa tồn tại sẽ tạo ra CSDL mới, nếu tồn tại rồi sẽ không khưởi tạo
                                        //DropCreateDatabaseIfModelChanges<CSDL> // chỉ thay đổi Record thfi sẽ không tahy đổi, nếu thay đổi liên kết sẽ xóa đi cái cũ đê rkhwoir tạo cái mới
                                        //DropCreateDatabaseAlways<CSDL> // Mỗi lần chạy lại thì sẽ xóa cái cũ và tahy cái mới
    {
        protected override void Seed(CSDL context)
        {
            context.Employees.AddRange(new Employee[]
            {
                new Employee{ID_Employee = "1", ID_Account = 1, ID_SalaryEmployee =1, FirstNameE = "Nguyen Van", LastNameE = "Vien1",DateOfBirthE = DateTime.Now,PhoneE = "0123", EmailE = "abc@gmail.com",Day_Create = DateTime.Now, Gender = true, Indentify = "123"},
                new Employee{ID_Employee = "2", ID_Account = 2, ID_SalaryEmployee =2, FirstNameE = "Nguyen Van", LastNameE = "Vien2",DateOfBirthE = DateTime.Now,PhoneE = "0124", EmailE = "abcd@gmail.com",Day_Create = DateTime.Now, Gender = true, Indentify = "1234"},
                new Employee{ID_Employee = "3", ID_Account = 3, ID_SalaryEmployee =3, FirstNameE = "Nguyen Van", LastNameE = "Vien3",DateOfBirthE = DateTime.Now,PhoneE = "0125", EmailE = "abce@gmail.com",Day_Create = DateTime.Now, Gender = true, Indentify = "1235"},
            });
            context.SalaryEmployees.AddRange(new SalaryEmployee[]
            {
                new SalaryEmployee{ ID_SalaryEmployee  =1, Salary = 123},
                new SalaryEmployee{ ID_SalaryEmployee  =2, Salary = 1234},
                new SalaryEmployee{ ID_SalaryEmployee  =3, Salary = 1235}
            }) ;
            context.Customers.AddRange(new Customer[]
            {
                new Customer{ID_Customer = 1, ID_Account = 1, FirstNameC = "Nguyen Van", LastNameC = "Vien1",DateOfBirthC = DateTime.Now,PhoneC = "0123", EmailC = "abc@gmail.com",Day_CreateC = DateTime.Now, GenderC = true, _MoneyC = 1234, ID_Employee ="1"},
                new Customer{ID_Customer = 2, ID_Account = 2, FirstNameC = "Nguyen Van", LastNameC = "Vien2",DateOfBirthC = DateTime.Now,PhoneC = "01234", EmailC = "abcd@gmail.com",Day_CreateC = DateTime.Now, GenderC = false, _MoneyC = 123, ID_Employee ="2"},
                new Customer{ID_Customer = 3, ID_Account = 3, FirstNameC = "Nguyen Van", LastNameC = "Vien3",DateOfBirthC = DateTime.Now,PhoneC = "01235", EmailC = "abce@gmail.com",Day_CreateC = DateTime.Now, GenderC = true, _MoneyC = 1235, ID_Employee ="3"},
            });
            context.Computers.AddRange(new Computer[]
            {
                new Computer{ID_Computer = 1,Name_PC = "May 1", Status = true, ID_Customer=1},
                new Computer{ID_Computer = 2,Name_PC = "May 2", Status = false, ID_Customer=2},
                new Computer{ID_Computer = 3,Name_PC = "May 3", Status = true, ID_Customer=3},
            });
            context.UseComputerHistorys.AddRange(new UseComputerHistory[]
            {
                new UseComputerHistory{ID_HistoryUseComputer = 1, ID_Customer = 1, ID_Computer =1,_LogIn = DateTime.Now, _LogOut = DateTime.Now, HourUsed = 1},
                new UseComputerHistory{ID_HistoryUseComputer = 2, ID_Customer = 2, ID_Computer =2,_LogIn = DateTime.Now, _LogOut = DateTime.Now, HourUsed = 2},
                new UseComputerHistory{ID_HistoryUseComputer = 3, ID_Customer = 3, ID_Computer =3,_LogIn = DateTime.Now, _LogOut = DateTime.Now, HourUsed = 3},
            });
        }
    }
}
