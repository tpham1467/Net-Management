using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetManagement.Model
{
    [Table("Category")]
    public class Category
    {
        public Category()
        {
            this.Products = new HashSet<Product>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Category { get; set; }
        [ForeignKey("ID_Category")]

        public virtual ICollection<Product> Products { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "Từ 3 đến  100 ký tự")]
        [DataType(DataType.Text)]
        public string CategoryName { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
    }
}
