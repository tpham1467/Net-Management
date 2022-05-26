using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetManagement.Model
{
    [Table("Computer")]
    public class Computer
    {
        public Computer()
        {
            UseComputerHistories = new HashSet<UseComputerHistory>();
            HistoryAccountUsers =new HashSet<HistoryAccountUser>();
        }
        [Key]
        public int ID_Computer { get; set; }
        public string Name_PC { get; set; }
        public int ID_Customer { get; set; }
        public bool Status { get; set; }
        public virtual ICollection<UseComputerHistory> UseComputerHistories {get; set;}
        public virtual ICollection<HistoryAccountUser> HistoryAccountUsers {get; set;}
    }
}
