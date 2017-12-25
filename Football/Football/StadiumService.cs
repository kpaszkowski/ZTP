using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class StadiumService
    {
        public void AddStadium(string name,string city,string country)
        {
            try
            {
                using (dbEntities context = new dbEntities())
                {
                    Stadium stadium = new Stadium
                    {
                        name = name,
                        city = city,
                        country = country
                    };

                    context.Stadia.Add(stadium);
                    context.SaveChanges();
                }

            }catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting
                        // the current instance as InnerException
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
        }

        public void RemoveStadium(string name, string city, string country)
        {
            using (dbEntities context = new dbEntities())
            {
                Stadium stadium = context.Stadia.FirstOrDefault(x => x.name == name && x.city == city && x.country == country);
                context.Stadia.Remove(stadium);
                context.SaveChanges();
            }
        }
    }
}
