using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetManagement.Model
{
    [Table("Employee")]
    public class Employee : User
    {
        public Employee()
        {
            Customers = new HashSet<Customer>();
            HistoryAccountUsers = new HashSet<HistoryAccountUser>();
            Shifts = new HashSet<Shift>();
            Orders = new HashSet<_Order>();
        }
        [Key]   
        public int ID_Employee { get; set; }

        public int ID_SalaryEmployee { get; set; }
        [ForeignKey("ID_SalaryEmployee")]
        public virtual SalaryEmployee SalaryEmployee { get; set; }

        [Required(ErrorMessage = "Employee {0} is Indentify")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Từ 3 đến  100 ký tự")]
        [DataType(DataType.Text)]
        public string Identify { get; set; }
         public virtual ICollection<HistoryAccountUser> HistoryAccountUsers { get; set; }
          public virtual ICollection<Shift> Shifts { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<_Order> Orders {get; set;}
    }
}
