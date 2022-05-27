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
           Orders = new HashSet<_Order>();
           HistoryAccountUsers = new HashSet<HistoryAccountUser>();
       }
        [Key]
        public int ID_Customer { get; set; }
        public int _MoneyC { get; set; }
        [Required]
        public int ID_Employee { get; set; }
        [ForeignKey("ID_Employee")]
        public virtual Employee Employee { get; set; }
        public virtual ICollection<HistoryAccountUser> HistoryAccountUsers {get; set;}
        public virtual ICollection<UseComputerHistory> UseComputerHistories {get; set;}
        public virtual ICollection<_Order> Orders { get; set;}


    }
}
