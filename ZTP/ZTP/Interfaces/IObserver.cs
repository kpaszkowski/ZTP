using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTP.Interfaces
{
    interface IObserver
    {
        void Update(Nullable<DateTime> date);
    }
}
