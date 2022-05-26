using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCSDL.MODEL
{
    [Table("Inventory")]
    public class Inventory
    {
        [Key][Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string ID_Product { get; set; }
        public int Amount { get; set; }
        [ForeignKey("ID_Product")]
        public virtual Product Product { get; set; }
    }
}
