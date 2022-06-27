using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetManagement.Model
{
    [Table("Unit")]
    public class Unit
    {
        public Unit()
        {
            Products = new HashSet<Product>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Unit { get; set; }
        [ForeignKey("ID_Unit")]

        public virtual ICollection<Product> Products { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Tên từ 3 đến  100 ký tự")]

        public string NameUnit { get; set; }
    }
}
