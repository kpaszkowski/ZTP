using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZTP.ViewModel;

namespace ZTP.Class
{
    class MainReferee : Referee
    {
        public override void TakePart(RefereeType refereeType , Match match,ref int count)
        {
            if (!IsBusy)
            {
                if (refereeType == RefereeType.Main)
                {
                    match.MainReffere = this.LastName;
                    this.IsBusy = true;
                    this.MatchID = match.ID;
                    count++;
                }
                else if (refereeType == RefereeType.Technical)
                {
                    match.TechnicalReffere = this.LastName;
                    this.IsBusy = true;
                    this.MatchID = match.ID;
                    count++;
                }
                else if (refereeType == RefereeType.Linear)
                {
                    match.LinearReffere = this.LastName;
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
