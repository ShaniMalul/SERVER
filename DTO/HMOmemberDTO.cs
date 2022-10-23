using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HMOmemberDTO
    {
        public int id { get; set; }
        public string memberName { get; set; }
        public string address { get; set; }
        public Nullable<System.DateTime> birthDate { get; set; }
        public string telephone { get; set; }
        public string cellphone { get; set; }
        public Nullable<System.DateTime> positiveDate { get; set; }
        public Nullable<System.DateTime> negativeDate { get; set; }

    }
}
