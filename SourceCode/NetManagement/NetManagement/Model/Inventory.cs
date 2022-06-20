using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetManagement.Model
{
    public class Inventory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Inventory { get; set; }
        [Required]
        public int Amount { get; set; }
        public DateTime ImportDay { get; set; }
        public int Init { get; set; }
        [Required]
        public DateTime ExpiryDate { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public int ImportPrices { get; set; }
        [DataType(DataType.Currency)]
        public int SalePrice { get; set; }
        public int ID_Product { get; set; }
        [ForeignKey("ID_Product")]

        public virtual Product Product { get; set; }

    }
}
