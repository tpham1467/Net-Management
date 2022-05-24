using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCSDL.MODEL
{
	[Table("_Service")]
	public class _Service
    {
		
		public _Service()
        {
			ServiceProducts = new List<ServiceProduct>();
		}

		[Key]
		[Required(ErrorMessage = "Ban phai nhap ID_Service")]
		[StringLength(50)]
		public int ID_Service { get; set; }
		[Required(ErrorMessage = "Ban phai nhap ID_Category")]
		[StringLength(50)]
		public int ID_Category { get; set; }
		[ForeignKey("ID_Category")]
		public virtual Category Category { get; set; }
		[StringLength(100)]
		public string Name_Service { get; set; }
		[Required(ErrorMessage = "Ban phai nhap ID_Unit")]
		[StringLength(50)]
		public int ID_Unit { get; set; }
		[ForeignKey("ID_Unit")]
		public virtual Unit Unit { get; set; }
		[Required(ErrorMessage = "Ban phai nhap ID_Product")]
		[StringLength(50)]
		public int ID_Product { get; set; }
		[ForeignKey("ID_Product")]
		public virtual Product Product { get; set; }

		public float Price { get; set; }
		public virtual ICollection<ServiceProduct> ServiceProducts { get; set; }
	}
}
