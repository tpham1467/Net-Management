using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetManagement.DTO
{
    public class ForgetPassword
    {
        public string email { get; set; }
        public string phone { get; set; }
        public string  NewPassword { get; set; }
    }
}
