using Football.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Service
{
    public class TicketService
    {
        public void AddTicket(string PESEL, long matchID, string date)
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    DateTime myDate = DateTime.Parse(date);
                    Match match = context.Match.FirstOrDefault(x => x.id == matchID);
                    Ticket ticket = new Ticket
                    {
                        Match = match,
                        PESEL = PESEL,
                        date = myDate,
                    };
                    context.Ticket.Add(ticket);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public bool RemoveTicket(int ticketID)
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    Ticket ticket = context.Ticket.FirstOrDefault(x => x.id == ticketID);
                    if (!CanRemoveTicket(ticket))
                    {
                        return false;
                    }
                    context.Ticket.Remove(ticket);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        private bool CanRemoveTicket(Ticket ticket)
        {
            return true;
        }

        public List<TicketViewModel> GetAllTicket()
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    List<Ticket> ticketList = context.Ticket.ToList();

                    List<TicketViewModel> list = new List<TicketViewModel>();

                    foreach (Ticket item in ticketList)
                    {
                        list.Add(new TicketViewModel { ID = item.id,PESEL=item.PESEL,Date=item.date});
                    }

                    return list;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public List<TicketViewModel> GetTicketByMatchIDVieWModel(long matchID)
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    List<Ticket> ticketList = context.Ticket.Where(x=>x.matchID==matchID).ToList();

                    List<TicketViewModel> list = new List<TicketViewModel>();

                    foreach (Ticket item in ticketList)
                    {
                        list.Add(new TicketViewModel { ID = item.id, PESEL = item.PESEL, Date = item.date });
                    }

                    return list;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public bool RemoveTicketByMatchID(long matchID)
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    List<Ticket> ticketList = context.Ticket.Where(x => x.matchID == matchID).ToList();
                    foreach (Ticket item in ticketList)
                    {
                        context.Ticket.Remove(item);
                    }
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public List<Ticket> GetTicketByMatchID(long matchID)
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    List<Ticket> ticketList = context.Ticket.Where(x => x.matchID == matchID).ToList();
                    return ticketList;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
