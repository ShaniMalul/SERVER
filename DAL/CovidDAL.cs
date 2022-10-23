using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CovidDAL
    {

        public void AddDetails(covidDetail c)
        {
            using(HMOdbEntities db = new HMOdbEntities())
            {
                db.covidDetails.Add(c);
                db.SaveChanges();
            }
        }
        public List<covidDetail> GetDetails()
        {

            using (HMOdbEntities db = new HMOdbEntities())
            {
                return db.covidDetails.ToList();
            }

        }

        public void DeleteDetailsById(int i)
        {
            using (HMOdbEntities db = new HMOdbEntities())
            {
                
                foreach (var item in db.covidDetails)
                {
                    if (item.idMember == i)
                    {
                        db.covidDetails.Remove(item);
                        
                    }
                }
                db.SaveChanges();
            }
        }
    }
}
