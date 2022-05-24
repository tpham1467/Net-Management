using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCSDL.MODEL
{
    [Table("Category")]
    public class Category
    {
        [Key]
        [Required(ErrorMessage = "Bạn cần điền ID_Category")]
        [StringLength(50)]
        public int ID_Category { get; set; }
        [StringLength(50)]
        [ForeignKey("ID_Category")]

        public virtual Category Category { get; set; }
        public string CategoryName { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
    }
}
