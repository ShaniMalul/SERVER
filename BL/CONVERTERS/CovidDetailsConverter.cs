using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.CONVERTERS
{
 public  class CovidDetailsConverter
    {
 
        public static covidDetail ConvertCovidToDAL(CovidDetailsDTO c)
        {
            return new covidDetail
            {
                code = c.code,
                idMember = c.idMember,
                manufacturerVaccination = c.manufacturerVaccination,
                numOfVaccination = c.numOfVaccination,
                vaccinationDate=c.vaccinationDate
            };
        }
        public static CovidDetailsDTO ConvertCovidToDTO(covidDetail c)
        {
            return new CovidDetailsDTO
            {
                code = c.code,
                idMember = c.idMember,
                manufacturerVaccination = c.manufacturerVaccination,
                numOfVaccination = c.numOfVaccination,
                vaccinationDate = c.vaccinationDate
            };

        }
    }
}
