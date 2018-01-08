using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZTP.ViewModel;

namespace ZTP.Class
{
    class LinearReferee : Referee
    {
        public override void TakePart(RefereeType refereeType,Match match, ref int count)
        {
            if (!IsBusy)
            {
                if (refereeType == RefereeType.Linear)
                {
                    match.LinearReffere = this.LastName;
                    this.IsBusy = true;
                    this.MatchID = match.ID;
                    count++;
                }
                else if (refereeType == RefereeType.Observer)
                {
                    match.ObserverReffere = this.LastName;
                    this.IsBusy = true;
                    this.MatchID = match.ID;
                    count++;
                }
                else if (next != null)
                {
                    next.TakePart(refereeType,match, ref count);
                }
            }
            else if (next != null)
            {
                next.TakePart(refereeType,match, ref count);
            }
        }
    }
}
