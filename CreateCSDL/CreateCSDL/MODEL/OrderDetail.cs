using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCSDL.MODEL
{
    public class OrderDetail
    {

		public OrderDetail()
        {
			_Services = new HashSet<_Service>();

		}

		[Key]
		[StringLength(50)]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Required(ErrorMessage = "Bạn cần điền ID_OrderDetail")]
		public int ID_OrderDetail { get; set; }
		[StringLength(50)]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Required(ErrorMessage = "Bạn cần điền ID_Service")]
		public int ID_Service { get; set; }
		[Required(ErrorMessage = "Bạn cần điền ID_Order")]
		[StringLength(50)]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ID_Order { get; set; }
		[ForeignKey("ID_Order")]
		public virtual _Order _Order { get; set; }
		public string _Description { get; set; }
		public int Quality { get; set; }
		public virtual ICollection<_Service> _Services { get; set; }

	}
}
