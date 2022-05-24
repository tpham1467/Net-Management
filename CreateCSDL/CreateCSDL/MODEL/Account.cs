using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp111.Model
{
    [Table("Account")]
    public class Account
    {
        [Key]
        [Required]
        public int ID_Account { get; set; }
        public string UserName_Acc { get; set; }
        public string Password_Acc { get; set; }
        public int ID_Role { get; set; }
        [ForeignKey("ID_Role")]
        public virtual Role Role { get; set; }
    }
}
