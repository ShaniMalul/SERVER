using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class CovidBL
    {
        CovidDAL cdDAL = new CovidDAL();

        public void AddDetails(CovidDetailsDTO c)
        {
            cdDAL.AddDetails(CONVERTERS.CovidDetailsConverter.ConvertCovidToDAL(c));
        }
        public List<CovidDetailsDTO> GetDetails()
        {
            List<CovidDetailsDTO> details = new List<CovidDetailsDTO>();
            List<covidDetail> detailsDal = cdDAL.GetDetails();
            foreach (var item in detailsDal)
            {
                details.Add(CONVERTERS.CovidDetailsConverter.ConvertCovidToDTO(item));
            }
            return details;
        }
        
      
    }
}
