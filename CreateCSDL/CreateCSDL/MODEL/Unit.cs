using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCSDL.MODEL
{
    [Table("Unit")]
    public class Unit
    {

        [Key]
        [Required(ErrorMessage = "Ban phai nhap ID_Unit")]
        [StringLength(50)]
        public int ID_Unit { get; set; }
        [ForeignKey("ID_Unit")]

        public virtual Product Product { get; set; }
        [Required]
        [Index(IsUnique = true)]
        [StringLength(100)]
        public string NameUnit { get; set; }
    }
}
