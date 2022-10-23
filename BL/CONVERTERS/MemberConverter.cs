using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.CONVERTERS
{
    public class MemberConverter
    {
       public static HMOmember  ConvertMemberToDAL(HMOmemberDTO m)
        {
            return new HMOmember
            {
                id = m.id,
                memberName = m.memberName,
                address = m.address,
                birthDate = m.birthDate,
                cellphone = m.cellphone,
                telephone = m.telephone,
                positiveDate = m.positiveDate,
                negativeDate = m.negativeDate
            };
        }

        public static HMOmemberDTO ConvertMemberToDTO(HMOmember m)
        {
            return new HMOmemberDTO
            {
                id = m.id,
                memberName = m.memberName,
                address = m.address,
                birthDate = m.birthDate,
                cellphone = m.cellphone,
                telephone = m.telephone,
                positiveDate = m.positiveDate,
                negativeDate = m.negativeDate
            };
        }
    }
}
