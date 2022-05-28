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
        [Required(ErrorMessage = "User {0} is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Tên từ 3 đến  100 ký tự")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "User {0} is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Tên từ 3 đến  100 ký tự")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DateOfBirth { get; set; }
        [Phone(ErrorMessage ="Số điện thoại không hợp lệ !")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Bạn cần điền Email !")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Email không hợp lệ !")]
        public string Email { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Day_Create { get; set; }
        public bool Gender { get; set; }
        public virtual ICollection<Account> Accounts {get; set;}
    }
}