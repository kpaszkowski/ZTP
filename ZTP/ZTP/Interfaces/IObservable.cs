using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZTP.ViewModel;

namespace ZTP.Interfaces
{
    interface IObservable
    {
        void Attach(Ticket ticket);
        void Detach(Ticket ticket);
        void Notify(Nullable<DateTime> dateTime);
    }
}
