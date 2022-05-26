using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCSDL.MODEL
{
    [Table("_Order")]
    public class _Order
    {
        [Key][Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Order { get; set; }
        public int ID_Customer { get; set; }
        public DateTime DateOfOrder { get; set; }
        [ForeignKey("ID_Customer")]
        public virtual Customer Customer { get; set; }
    }
}
