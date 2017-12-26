using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class StadiumService
    {
        public void AddStadium(Stadium stadium)
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    context.Stadium.Add(stadium);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void RemoveStadium(string name,string city,string country)
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    Stadium stadium = context.Stadium.FirstOrDefault(x => x.name == name && x.city == city && x.country == country);
                    if (stadium!=null)
                    {
                        context.Stadium.Remove(stadium);
                        context.SaveChanges();
                    }
                    else
                    {
                        //brak rekordu
                    }
                }
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        internal List<Stadium> GetAllStadium()
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    List<Stadium> stadium = context.Stadium.ToList();
                    return stadium;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
