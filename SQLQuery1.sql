CREATE TABLE Account (
	ID_Account char(50) primary key ,
	UserName_Acc char(50) Not null UNIQUE,
	Password_Acc char(50) not null ,
	IsAdmin bit ,
	IsEmployee bit
)
CREATE TABLE SalaryEmployee (
	ID_SalaryEmployee char(50) primary key,
	Salary float , 
)
CREATE TABLE Employee (
	ID_Employee char(50)   primary key ,
	ID_Account char(50) ,
	constraint fk_ID_Account foreign key (ID_Account) references  Account(ID_Account),
	ID_SalaryEmployee char(50) ,
	constraint fk_ID_SalaryEmployee_Employee foreign key (ID_SalaryEmployee) references  SalaryEmployee(ID_SalaryEmployee),
	Name_Employee nvarchar(100),
	Date_Of_Birth Datetime,
	Phone  char(30),
	Email Char(30),
	Status_Acc bit ,
	Date_Create Datetime ,
    Gender bit ,
	ID char(50)
	
)
CREATE TABLE Account_Customer(
	ID_Account_Customer Char(50) primary key ,
	_Money int 
)
CREATE TABLE Customer (
	ID_Customer char(50)   primary key ,
	ID_Account char(50) ,
	constraint fk_ID_Account_1 foreign key (ID_Account) references  Account(ID_Account),
	ID_Account_Customer Char(50) ,
	constraint ID_Account_Customer_2 foreign key (ID_Account_Customer) references  Account_Customer(ID_Account_Customer),
	Name_Customer nvarchar(100),
	Date_Of_Birth Datetime,
	Phone  char(30),
	Email Char(30),
	Status_Acc bit ,
	Date_Create Datetime ,
    Gender bit ,
	ID_Employee char(50) ,
	constraint fk_ID_Employee foreign key (ID_Employee) references  Employee(ID_Employee)
	
)
CREATE TABLE Computer  (
	ID_Computer char(50) primary key ,
	_Status bit ,
	ID_Account char(50) DEFAULT NULL,
	constraint fk_ID_Account_Computer foreign key (ID_Account) references  Account(ID_Account)
)
CREATE TABLE UseComputerHistory (
	ID_HistoryUseComputer char(50) primary key  ,
	ID_Customer char(50) ,
	ID_Computer char(50) ,
	constraint fk_ID_Computer foreign key (ID_Computer) references  Computer(ID_Computer),
	constraint fk_ID_Customer foreign key (ID_Customer) references  Customer(ID_Customer),
	Hour_Used float 
)
CREATE TABLE Product (
    ID_Product char(50) primary key ,
	ID_Category char(50) ,
	constraint fk_ID_ID_Category_Service foreign key (ID_Category) references  Category(ID_Category),
	Name_Product  nvarchar(100),
	Unit  nvarchar(100),
	Price float 
)
CREATE TABLE Inventory (
	ID_Product char(50) ,
	_Expiry_Date Datetime ,
	Amount int ,
	constraint fk_ID_Product foreign key (ID_Product) references  Product(ID_Product),
	
)
CREATE TABLE TransactionProductHistory (
	ID_TransactionProductHistory char(50) ,
	ID_Product char(50)  ,
	ID_Customer char(50) ,
	constraint fk_ID_Customer_TransactionHistory foreign key (ID_Customer) references  Customer(ID_Customer),
	constraint fk_ID_Product_TransactionHistory foreign key (ID_Product) references  Product(ID_Product),
	TransactionDate Datetime ,
	_Description text ,
	Quality int
)
CREATE TABLE _Service (
	ID_Service char(50) primary key ,
	ID_Category char(50) ,
	constraint fk_ID_Category_Service foreign key (ID_Category) references  Category(ID_Category),
	Name_Service nvarchar(100),
	Price float ,
)
CREATE TABLE TransactionServiceHistory (
	TransactionServiceHistory char(50) ,
	ID_Service char(50)  ,
	ID_Customer char(50) ,
	constraint fk_ID_Customer_TransactionServiceHistory foreign key (ID_Customer) references  Customer(ID_Customer),
	constraint fk_ID_Service_TransactionServiceHistory foreign key (ID_Service) references  _Service(ID_Service),
	TransactionDate Datetime ,
	_Description text ,
	Quality int
)
CREATE TABLE StatusShift(
	ID_StatusShift char(50) primary key,
	Description text 
)
CREATE TABLE _Shift  (
	ID_Shift char(50) primary key,
	ID_Employee char(50) ,
	constraint fk_ID_Employee_Shift foreign key (ID_Employee) references  Employee(ID_Employee) ,
	Date_Work Datetime ,
	ID_StatusShift char(50) ,
	constraint fk_ID_StatusShift_Shift foreign key (ID_StatusShift) references  StatusShift(ID_StatusShift) ,
	_Hour int  
)
CREATE TABLE Category  (
	ID_Category char(50) primary key,
	CategoryName nvarchar(50) ,
	Desciption nvarchar(200 ) ,
)
CREATE TABLE History_Account_User  (
	ID_History_Account_User char(50) primary key ,
	ID_Customer char(50) ,
	ID_Employee char(50)  ,
	ID_Computer char(50) ,
	constraint fk_ID_Customer_History_Account_User foreign key (ID_Customer) references  Customer(ID_Customer),
	constraint fk_ID_Employee_History_Account_User foreign key (ID_Employee) references  Employee(ID_Employee),
	constraint fk_ID_Computer_History_Account_User foreign key (ID_Computer) references  Computer(ID_Computer),
	_Money  float ,
	_Description text ,
	_Date Datetime 
)



