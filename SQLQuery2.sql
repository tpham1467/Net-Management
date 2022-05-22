CREATE TABLE Role (
	ID_Role char(50) primary key ,
	NameRole nvarchar(100) UNIQUE,
	Desciption nvarchar(200 ) 
)
go
CREATE TABLE Account (
	ID_Account char(50) primary key ,
	UserName_Acc char(50) Not null UNIQUE,
	Password_Acc char(50) not null ,
	ID_Role char(50) ,
	StatusAcc bit;
	constraint fk_ID_AccountRole foreign key (ID_Role) references  Role(ID_Role),
)
go
CREATE TABLE SalaryEmployee (
	ID_SalaryEmployee char(50) primary key,
	Salary float 
)
go
CREATE TABLE Employee (
	ID_Employee char(50)   primary key ,
	ID_Account char(50)  UNIQUE  ,
	ID_SalaryEmployee char(50) ,
	constraint fk_ID_SalaryEmployee_Employee foreign key (ID_SalaryEmployee) references  SalaryEmployee(ID_SalaryEmployee),
	Name_Employee nvarchar(100),
	Date_Of_Birth Datetime,
	Phone  char(30),
	Email Char(30),
	Date_Create Datetime ,
    Gender bit ,
	ID char(50)
	
)
go

CREATE TABLE Customer (
	ID_Customer char(50)   primary key ,
	ID_Account char(50) UNIQUE  ,
	First_Name nvarchar(50),
	Last_Name nvarchar(50) , 
	Date_Of_Birth Datetime,
	Phone  char(30),
	Email Char(30),
	Date_Create Datetime ,
         Gender bit ,
      _Money int ,
	ID_Employee char(50) ,
	constraint fk_ID_Employee foreign key (ID_Employee) references  Employee(ID_Employee)
	
)
go
CREATE TABLE Computer  (
	ID_Computer char(50) primary key ,
	_Status bit ,
	ID_Customer char(50) DEFAULT NULL,
	constraint fk_ID_Customer_Computer foreign key (ID_Customer) references  Customer(ID_Customer)
)
go
CREATE TABLE UseComputerHistory (
	ID_HistoryUseComputer char(50) primary key  ,
	ID_Customer char(50) DEFAULT null,
	ID_Computer char(50) DEFAULT null,
	constraint fk_ID_Computer foreign key (ID_Computer) references  Computer(ID_Computer),
	constraint fk_ID_Customer foreign key (ID_Customer) references  Customer(ID_Customer),
	_LogIn Datetime ,
	_logOut DateTime  ,
	Hour_Used float 
)
go
CREATE TABLE Category  (
	ID_Category char(50) primary key,
	CategoryName nvarchar(50) ,
	Desciption nvarchar(200 ) ,
)
CREATE TABLE Unit (
	ID_Unit char(50) primary key ,
	NameUnit nvarchar(100) not null UNIQUE,


)
go
CREATE TABLE Product (
    ID_Product char(50) primary key ,
	ID_Category char(50) ,
	constraint fk_ID_ID_Category_Service foreign key (ID_Category) references  Category(ID_Category),
	Name_Product  nvarchar(100),
	ID_Unit char(50) ,
	constraint fk_Product_Unit foreign key (ID_Unit) references  Unit(ID_Unit),
	Price float 
)
go
CREATE TABLE Inventory (
	ID_Product char(50) ,
	Amount int ,
	constraint fk_ID_Product foreign key (ID_Product) references  Product(ID_Product),
	
)
go
CREATE TABLE _Order (
	ID_Order char(50) primary key,
	ID_Customer char(50) ,
	constraint fk_ID_Customer_Order foreign key (ID_Customer) references  Customer(ID_Customer),
	DateOfOrder  Datetime 

)
go
CREATE TABLE ServiceProduct (
	ID_ServiceProduct char(50);
	ID_Product char(50) ,
	ID_Service char(50),
	constraint fk_ID_Product_ServiceProduct foreign key (ID_Product) references  Product(ID_Product)  ,
	constraint fk_ID_ServiceServiceProduct foreign key (ID_Service) references  _Service(ID_Service)
)

CREATE TABLE _Service (
	ID_Service char(50) primary key ,
	ID_Category char(50) ,
	constraint fk_ID_Category_Service foreign key (ID_Category) references  Category(ID_Category),
	Name_Service nvarchar(100),
	ID_Unit char(50) ,
		ID_Product char(50)  ,
		constraint fk_ID_Product_OrderDetail foreign key (ID_Product) references  Product(ID_Product)  ,
	constraint fk_Service_Unit foreign key (ID_Unit) references  Unit(ID_Unit),
	Price float ,
)
go
CREATE TABLE OrderDetail (
	ID_OrderDetail char(50) primary key,
	ID_Service char(50)  ,
	ID_Order char(50) ,
	constraint fk_ID_Order_OrderDetail foreign key (ID_Order) references  _Order(ID_Order)  ,
	constraint fk_ID_Service_OrderDetail foreign key (ID_Service) references  _Service(ID_Service),
	_Description text ,
	Quality int
)

go
CREATE TABLE StatusShift(
	ID_StatusShift char(50) primary key,
	Description text 
)
go
CREATE TABLE _Shift  (
	ID_Shift char(50) primary key,
	ID_Employee char(50) ,
	constraint fk_ID_Employee_Shift foreign key (ID_Employee) references  Employee(ID_Employee) ,
	Date_Work Datetime ,
	ID_StatusShift char(50) ,
	constraint fk_ID_StatusShift_Shift foreign key (ID_StatusShift) references  StatusShift(ID_StatusShift) ,
	_Hour int  
)

go
CREATE TABLE History_Account_User  (
	ID_History_Account_User char(50) primary key ,
	ID_Customer char(50) ,
	ID_Employee char(50)  ,
	ID_Computer char(50) ,
	constraint fk_ID_Customer_History_Account_User foreign key (ID_Customer) references  Customer(ID_Customer),
	constraint fk_ID_Employee_History_Account_User foreign key (ID_Employee) references  Employee(ID_Employee),
	constraint fk_ID_Computer_History_Account_User foreign key (ID_Computer) references  Computer(ID_Computer),
	direct bit , 
	_Money  int ,
	_Description text ,
	_Date Datetime 
)



