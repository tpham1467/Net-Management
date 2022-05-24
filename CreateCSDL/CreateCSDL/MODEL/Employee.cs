using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCSDL.MODEL
{
    [Table("Employee")]
    public class Employee
    {
        public Employee()
        {
            Customers = new HashSet<Customer>();
    }
        [Key]
        [Required(ErrorMessage = "Bạn cần điền ID_Employee")]   
        public string ID_Employee { get; set; }
        [Required(ErrorMessage = "Bạn cần điền ID_Account")]
        [Index(IsUnique = true)]
        public int ID_Account { get; set; }
        public int ID_SalaryEmployee { get; set; }
        [ForeignKey("ID_SalaryEmployee")]


        //Khai bao thuộc tính quan hệ
        public virtual SalaryEmployee SalaryEmployees { get; set; }

        [Required(ErrorMessage = "Bạn cần điền họ")]
        [StringLength(200)]
        public string FirstNameE { get; set; }
        [Required(ErrorMessage = "Bạn cần điền tên")]
        [StringLength(200)]
        public string LastNameE { get; set; }
        public DateTime DateOfBirthE { get; set; }
        public string PhoneE { get; set; }
        [Required(ErrorMessage = "Bạn cần điền Email")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string EmailE { get; set; }
        public DateTime Day_Create { get; set; }
        public bool Gender { get; set; }

        [Required(ErrorMessage = "Bạn cần điền số CMND/ CCCD ")]
        public string Indentify { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
