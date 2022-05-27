using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetManagement.Model
{
    public class OrderDetail
    {

		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Required(ErrorMessage = "Bạn cần điền ID_OrderDetail")]
		public int ID_OrderDetail { get; set; }
		[Required]
		public int ID_Product { get; set; }
		[Required]
		public int ID_Order { get; set; }
		[ForeignKey("ID_Order")]
		public virtual _Order _Order { get; set; }
		public string _Description { get; set; }
		public int Quality { get; set; }
		[ForeignKey("ID_Product")]
		public virtual Product Product { get; set; }

	}
}
