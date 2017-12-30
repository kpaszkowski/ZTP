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
                    };
                    if (stadium!=null)
                    {
                        club.Stadium = stadium;
                    }
                    context.Club.Add(club);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void AddClub(string name, string stadiumName)
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    Stadium stadium = context.Stadium.FirstOrDefault(x => x.name == stadiumName);
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

        public void RemoveClub(string name)
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    Club club = context.Club.FirstOrDefault(x => x.name == name);
                    if (club!=null)
                    {
                        context.Club.Remove(club);
                        context.SaveChanges();
                    }
                    else
                    {
                        //brak recordu
                    }
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        internal List<Club> GetAllClub()
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    List<Club> stadium = context.Club.ToList();
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
