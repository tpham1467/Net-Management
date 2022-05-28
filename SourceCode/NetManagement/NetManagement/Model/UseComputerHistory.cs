using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetManagement.Model
{
	[Table("UseComputerHistory")]
	public class UseComputerHistory
    {
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ID_HistoryUseComputer { get; set; }
		[Required]
		public int ID_Customer { get; set; }
		[ForeignKey("ID_Customer")]
		public virtual Customer Customer { get; set; }
		[Required]
		public int ID_Computer { get; set; }
		[ForeignKey("ID_Computer")]
		public virtual Computer Computer { get; set; }

		public DateTime _LogIn { get; set; }
		public DateTime _LogOut { get; set; }
		public float HourUsed { get; set; }
	}
}
