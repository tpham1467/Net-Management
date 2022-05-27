using System.Net.Http.Headers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetManagement.Model
{
    [Table("Account")]
    public class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Account { get; set; }
         [Required]
        public string UserName_Acc { get; set; }
         [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Mật khẩu không chứa kí tự đặc biệt")]
        [StringLength(32, MinimumLength = 8, ErrorMessage = "Mật khẩu có độ dài từ 8 - 32")]
        public string Password_Acc { get; set; }
        public int ID_Role { get; set; }
        [ForeignKey("ID_Role")]
        public virtual Role Role { get; set; }
        [Required]
        public int Id_User {get; set;}
     [ForeignKey("Id_User")]
     public virtual User User {get; set;}

    }
}
