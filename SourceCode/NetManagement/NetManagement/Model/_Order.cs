using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetManagement.Model
{
    [Table("_Order")]
    public class _Order
    {
        public _Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
        [Key][Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Order { get; set; }
        public int ID_Customer { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DateOfOrder { get; set; }
        [ForeignKey("ID_Customer")]
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
