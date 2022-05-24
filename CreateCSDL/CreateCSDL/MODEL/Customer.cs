using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCSDL.MODEL
{
    [Table("Customer")]
    public class Customer
    {

        public Customer()
        {
            Computers = new HashSet<Computer>();
        }
        [Key]
        [Required(ErrorMessage = "Bạn cần điền ID_Customer")]
        public int ID_Customer { get; set; }
        [Required(ErrorMessage = "Bạn cần điền ID_Account")]
        [Index(IsUnique = true)]
        public int ID_Account { get; set; }

        [Required(ErrorMessage = "Bạn cần điền họ")]
        [StringLength(200)]
        public string FirstNameC { get; set; }
        [Required(ErrorMessage = "Bạn cần điền tên")]
        [StringLength(200)]
        public string LastNameC { get; set; }
        public DateTime DateOfBirthC { get; set; }
        public string PhoneC { get; set; }
        [Required(ErrorMessage = "Bạn cần điền Email")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string EmailC { get; set; }
        public DateTime Day_CreateC { get; set; }
        public bool GenderC { get; set; }
        public int _MoneyC { get; set; }
        [StringLength(200)]
        public string ID_Employee { get; set; }
        [ForeignKey("ID_Employee")]

        public virtual Employee Employee { get; set; }


        public virtual ICollection<Computer> Computers { get; set; }
    }
}
