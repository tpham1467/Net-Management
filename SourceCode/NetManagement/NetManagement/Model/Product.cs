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
    [Table("Product")]
    public class Product
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
     
        public int ID_Product { get; set; }
        [Required]
        public int ID_Category { get; set; }
        
        [StringLength(100)]
        public string NameProduct { get; set; }
        [Required]
        public int ID_Unit { get; set; }
        public float Price { get; set; }
        [ForeignKey("ID_Unit")]
        public virtual Unit Unit { get; set; }
       [ForeignKey("ID_Category")]
        public virtual Category Category { get; set; }
    }
}
