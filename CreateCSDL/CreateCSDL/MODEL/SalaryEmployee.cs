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
        public SalaryEmployee()
        {
            Employees = new HashSet<Employee>();
        }
        [Key]
        [Required]
        public int ID_SalaryEmployee { get; set; }
        public float Salary { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
