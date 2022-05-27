using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetManagement.Model
{
    [Table("Inventory")]
    public class Inventory
    {
        public Inventory()
        {
            Products = new HashSet<Product>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Product { get; set; }
        [Required]
        public int Amount { get; set; }
        [ForeignKey("ID_Product")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
