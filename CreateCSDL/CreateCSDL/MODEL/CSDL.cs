using System;
using System.Data.Entity;
using System.Linq;

namespace CreateCSDL.MODEL
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
            Database.SetInitializer<CSDL>(new CreateDB());
        }

        //Thay đổi được cấu trúc CS dữ liệu
        //Có thể cắt quan hệ giữa c
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Computer> Computers { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<SalaryEmployee> SalaryEmployees { get; set; }
        public virtual DbSet<UseComputerHistory> UseComputerHistorys { get; set; }

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