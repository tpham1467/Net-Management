using System.Net.Http.Headers;
using System.Data;
 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetManagement.Model
{
    [Table("Customer")]
    public class Customer : User
    {

       public Customer()
       {
           Orders = new HashSet<Order>();
           HistoryAccountUsers = new HashSet<HistoryAccountUser>();
            UseComputerHistories = new HashSet<UseComputerHistory>();
       }
      
        [Column("_Money")]
        public int Money { get; set; }
        [Required]
        public int ID_Employee { get; set; }
        [ForeignKey("ID_Employee")]
        public virtual Employee Employee { get; set; }
        public virtual ICollection<HistoryAccountUser> HistoryAccountUsers {get; set;}
        public virtual ICollection<UseComputerHistory> UseComputerHistories {get; set;}
        public virtual ICollection<Order> Orders { get; set;}


    }
}
