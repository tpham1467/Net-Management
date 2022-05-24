using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCSDL.MODEL
{
	[Table("UseComputerHistory")]
	public class UseComputerHistory
    {
		public UseComputerHistory()
        {
			Computers = new HashSet<Computer>();
			Customers = new HashSet<Customer>();
		}
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ID_HistoryUseComputer { get; set; }
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ID_Customer { get; set; }
		[ForeignKey("ID_Customer")]
		public virtual ICollection<Customer> Customers { get; set; }
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ID_Computer { get; set; }
		[ForeignKey("ID_Computer")]
		public virtual ICollection<Computer> Computers { get; set; }

		public DateTime _LogIn { get; set; }
		public DateTime _LogOut { get; set; }
		public float HourUsed { get; set; }
	}
}
