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
        public bool AddStadium(Stadium stadium)
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    context.Stadium.Add(stadium);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public bool RemoveStadium(long stadiumID)
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    Stadium stadium = context.Stadium.FirstOrDefault(x=>x.id==stadiumID);

                    if (!CanRemoveStadium(stadium))//nie posiada przypisanych klubów
                    {
                        return false;
                    }
                    context.Stadium.Remove(stadium);
                    context.SaveChanges();
                    return true;
                }
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        private bool CanRemoveStadium(Stadium stadium)
        {
            if (stadium.Club.Count != 0)
            {
                return false;
            }
            if (stadium.Match.Count != 0)
            {
                return false;
            }
            return true;
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
