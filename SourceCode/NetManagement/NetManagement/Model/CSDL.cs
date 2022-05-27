using System;
using System.Data.Entity;
using System.Linq;
using Microsoft.Extensions.Logging;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Threading.Tasks;
namespace NetManagement.Model
{
    public class CSDL : DbContext
    {
        // Your context has been configured to use a 'CSDL' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CreateCSDL.MODEL.CSDL' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CSDL' 
        // connection string in the application configuration file.
        public CSDL()
            : base("name=CSDL")
        {
           // Database.SetI//nitializer<CSDL>(new CreateDB());
        }

        //Thay đổi được cấu trúc CS dữ liệu
       // Có thể cắt quan hệ giữa c
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);

        //    // Tạo ILoggerFactory
        //    ILoggerFactory loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());

        //    optionsBuilder   // thiết lập làm việc với SqlServer
        //                  .UseLoggerFactory(loggerFactory);     // thiết lập logging

        //}
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Computer> Computers { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<SalaryEmployee> SalaryEmployees { get; set; }
        public virtual DbSet<UseComputerHistory> UseComputerHistorys { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<HistoryAccountUser> HistoryAccountUsers { get; set; }

        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Shift> Shifts { get; set; }
        public virtual DbSet<StatusShift> StatusShifts { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        
        public virtual DbSet<_Order> Orders { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}