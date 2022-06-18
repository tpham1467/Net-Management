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
    public class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
        [Key][Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Order { get; set; }
        [Required]
        public int ID_Customer { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DateOfOrder { get; set; }
        public bool status { get; set; }
        public int Total { get; set; }
        [ForeignKey("ID_Customer")]
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
