using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CovidDetailsDTO
    {
        public int code { get; set; }
        public Nullable<int> idMember { get; set; }
        public Nullable<int> numOfVaccination { get; set; }
        public string manufacturerVaccination { get; set; }
        public Nullable<System.DateTime> vaccinationDate { get; set; }

    }
}
