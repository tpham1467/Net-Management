using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetManagement.Model
{
    [Table("SalaryEmployee")]
    public class SalaryEmployee
    {
        public SalaryEmployee()
        {
            Employees = new HashSet<Employee>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_SalaryEmployee { get; set; }
        [Required]
        public float Salary { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
