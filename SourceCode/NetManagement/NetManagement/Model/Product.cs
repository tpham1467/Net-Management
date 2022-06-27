using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetManagement.Model
{
    [Table("Product")]
    public class Product
    {
        public Product()
        {
            Inventories = new HashSet<Inventory>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Product { get; set; }
        [Required]
        public int ID_Category { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Từ 3 đến  100 ký tự")]
        public string NameProduct { get; set; }
        [Required]
        public int ID_Unit { get; set; }
        [ForeignKey("ID_Unit")]
        public virtual Unit Unit { get; set; }
        [ForeignKey("ID_Category")]
        public virtual Category Category { get; set; }
        public virtual ICollection<Inventory> Inventories { get; set; }

    }
}
