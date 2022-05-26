using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NetManagement.Model
{
    public class StatusShift
    {
        public StatusShift()
        {
            this.Shifts = new HashSet<Shift>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int  ID_StatusShift { get; set; }
        [Column("_Description")]
        public string Description { get; set; }
        public virtual ICollection<Shift> Shifts { get; set; }
    }
}
