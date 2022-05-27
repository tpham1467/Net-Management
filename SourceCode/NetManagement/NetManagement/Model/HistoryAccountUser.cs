using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NetManagement.Model
{
    public class HistoryAccountUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_HistoryAccountUser { get; set; }
        [Required]
        public int ID_Customer { get; set; }
        [Required]
        public int ID_Employee { get; set; }
        [Required]
        public int ID_Computer { get; set; }
        [Required]
        public bool Direct {get; set;}
        [Required] [DataType(DataType.Currency)] [Column("_Money")]
        public decimal Money { get; set; }
        [Column("_Description")]
        public string Description { get; set; }
        [DataType(DataType.DateTime)] [Column("_Date")]
        public DateTime Date { get; set; }
        [ForeignKey("ID_Customer")]
        public virtual Customer customer { get; set; }
        [ForeignKey("ID_Employee")]
        public virtual Employee employee { get; set; }
        [ForeignKey("ID_Computer")]
        public virtual Computer computer { get; set; }



    }
}
