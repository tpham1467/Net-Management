using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCSDL.MODEL
{
    [Table("ServiceProduct")]
    public class ServiceProduct
    {
        [Key][Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_ID_ServiceProduct { get; set; }
        public int ID_Product { get; set; }
        public int ID_Service { get; set; }
        [ForeignKey("ID_Product")]
        public virtual Product Product { get; set; }
        [ForeignKey("ID_Service")]
        public virtual Product _Service { get; set; }
    }
}
