using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NetManagement.Model
{
    public class User
    {
        public User()
        {
            Accounts = new HashSet<Account>();
        }
        [Key] [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_User { get; set; }
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
        public virtual ICollection<Account> Accounts {get; set;}
    }
}