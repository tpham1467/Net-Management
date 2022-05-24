using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCSDL.MODEL
{
    [Table("SalaryEmployee")]
    public class SalaryEmployee
    {
        [Key]
        [Required(ErrorMessage = "Bạn cần điền ID_SalaryEmployee")]
        public int ID_SalaryEmployee { get; set; }
        public float Salary { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
