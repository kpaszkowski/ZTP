using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class ClubService
    {
        public void AddClub(string name, Stadium stadium)
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    Club club = new Club
                    {
                        name = name,
                        Stadium = stadium,
                    };

                    context.Club.Add(club);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
