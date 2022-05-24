using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp111.Model
{
    [Table("Role")]
    public class Role
    {
        public Role()
        {
            Accounts = new HashSet<Account>();
        }
        [Key]
        [Required]
        public int ID_Role { get; set; }
        public string NameRole { get; set; }
        public string Desciption { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
