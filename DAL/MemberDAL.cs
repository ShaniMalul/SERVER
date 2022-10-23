using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MemberDAL
    {
        CovidDAL c = new CovidDAL();
        public  void AddMember(HMOmember m)
        {
            using (HMOdbEntities db = new HMOdbEntities())
            {
                db.HMOmembers.Add(m);
                db.SaveChanges();
            }
        }

        public  List<HMOmember> GetMembers()
        {
 
            using (HMOdbEntities db = new HMOdbEntities())
            {
                return db.HMOmembers.ToList();
            }
  
        }

        public void DeleteMemberById(int i)
        {
            using (HMOdbEntities db = new HMOdbEntities())
            {
                HMOmember dm = db.HMOmembers.Find(i);
                if (dm == null)
                    return;
                else
                {
                    db.HMOmembers.Remove(dm);
                    c.DeleteDetailsById(i);
                    db.SaveChanges();
                    
                }
                    
            }
            
        }

        public void UpdateMember(HMOmember m)
        {

            using (HMOdbEntities db = new HMOdbEntities())
            {
                db.HMOmembers.Find(m.id).memberName = m.memberName;
                db.HMOmembers.Find(m.id).address = m.address;
                db.HMOmembers.Find(m.id).telephone = m.telephone;
                db.HMOmembers.Find(m.id).cellphone = m.cellphone;
                db.HMOmembers.Find(m.id).positiveDate = m.positiveDate;
                db.HMOmembers.Find(m.id).negativeDate = m.negativeDate;
                db.SaveChanges();
            }
        }

    }
}
