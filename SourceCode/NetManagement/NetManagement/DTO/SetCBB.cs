using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetManagement.Model
{
    public class SetCBB
    {
        public int id { get; set; }
        public string name { get; set; }
        public override string ToString()
        {
            return id + " - "+name;
        }
    }
}
