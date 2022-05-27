using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetManagement.Model
{
    [Table("Role")]
    public class Role
    {
        public Role()
        {
            Accounts = new HashSet<Account>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Role { get; set; }
        [Required]
        public string NameRole { get; set; }
        public string Desciption { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
