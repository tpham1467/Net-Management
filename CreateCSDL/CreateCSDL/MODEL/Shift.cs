﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CreateCSDL.MODEL
{
    [Table("_Shift")]
    public class Shift
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Shift { get; set; }
        [Required]
        public int ID_Employee { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Date_Work { get; set; }
        [Required] [ Column("_Hour ")]
        public int Hour { get; set; }
        [Required]
        public int ID_StatusShift { get; set; }
        [ForeignKey("ID_StatusShift")]
        public virtual StatusShift statusShift{ get; set; }
    }
}
