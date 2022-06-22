using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetManagement.Model
{
    [Table("HistoryPayroll")]
    public class HistoryPayroll
    {
        public HistoryPayroll()
        {
            Shifts = new HashSet<Shift>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_HistoryPayroll { get; set; }
        //[DataType(DataType.Currency)]
        public int Salary { get; set; }
        public string PayrollDate { get; set; }
        public int ID_User { get; set; }
        [ForeignKey("ID_User")]
        public virtual Employee Employee { get; set; }
        public virtual ICollection<Shift> Shifts { get; set; }
    }
}
