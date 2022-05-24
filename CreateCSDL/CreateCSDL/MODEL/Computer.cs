using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCSDL.MODEL
{
    [Table("Computer")]
    public class Computer
    {
        [Key]
        //[Required(ErrorMessage = "Bạn cần điền ID_Computer")]
        public int ID_Computer { get; set; }
        public string Name_PC { get; set; }
        [Required(ErrorMessage = "Bạn cần điền ID_Customer")]
        [Index(IsUnique = true)]
        public int ID_Customer { get; set; }

        [ForeignKey("ID_Customer")]

        public virtual Customer Customer { get; set; }
        public bool Status { get; set; }


    }
}
