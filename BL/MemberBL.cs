using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
  public  class MemberBL
    {
        MemberDAL memDAL = new MemberDAL();
        public  void AddMember(HMOmemberDTO m )
        {
            memDAL.AddMember(CONVERTERS.MemberConverter.ConvertMemberToDAL(m));
        }

        public  List<HMOmemberDTO> GetMembers()
        {
            List<HMOmemberDTO> members = new List<HMOmemberDTO>();
            List<HMOmember> membersDal = memDAL.GetMembers();
            foreach (var item in membersDal)
            {
                members.Add(CONVERTERS.MemberConverter.ConvertMemberToDTO(item));
            }
            return members;
        }

         public void DeleteMember(int i)
        {
            memDAL.DeleteMemberById(i);
        }

        public void UpdateMember(HMOmemberDTO m)
        {
            memDAL.UpdateMember(CONVERTERS.MemberConverter.ConvertMemberToDAL(m));
        }
    }
}
