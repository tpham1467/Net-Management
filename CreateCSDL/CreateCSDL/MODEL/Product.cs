using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCSDL.MODEL
{
    [Table("Product")]
    public class Product
    {
        public Product()
        {
            Units = new HashSet<Unit>();
            Categories = new HashSet<Category>();
        }
        [Key]
        [StringLength(50)]
        [Required(ErrorMessage = "Bạn cần điền ID_Product")]
        public int ID_Product { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Bạn cần điền ID_Category")]
        public int ID_Category { get; set; }
        
        [StringLength(100)]
        public string NameProduct { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Bạn cần điền ID_Unit")]
        public int ID_Unit { get; set; }
        public float Price { get; set; }
        public virtual ICollection<Unit> Units { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
    }
}
