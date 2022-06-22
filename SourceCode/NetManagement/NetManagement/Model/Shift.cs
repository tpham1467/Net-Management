using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NetManagement.Model
{
    [Table("_Shift")]
    public class Shift
    {
        public Shift()
        {
            HistoryPayrolls = new HashSet<HistoryPayroll>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Shift { get; set; }
        [Required]
        public int ID_Employee { get; set; }
        [ForeignKey("ID_Employee")]
        public virtual Employee Employee {get; set;}

        public virtual ICollection<HistoryPayroll> HistoryPayrolls { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime WorkedDate { get; set; }
        [DataType(DataType.DateTime)]
        public string ShiftStartTime { get; set; }
        [DataType(DataType.DateTime)]
        public string ShiftEndTime { get; set; }
        [Required] [Column("_Hour ")]
        public int WorkedHour { get; set; }
        [Required]
        public int ID_StatusShift { get; set; }
        [ForeignKey("ID_StatusShift")]
        public virtual StatusShift StatusShift{ get; set; }
    }
}
