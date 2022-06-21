using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetManagement.Model
{
    public class Message
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int Id_Customer { get; set; }

        public bool FromEmployee { get; set; }
        public string _Message { get; set; }
        public DateTime time { get; set; }

        public int id_computer { get; set; }

    }
}
