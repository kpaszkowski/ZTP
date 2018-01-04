using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZTP.ViewModel;

namespace ZTP.Class
{
    class TechnicalReferee : Referee
    {
        public override void TakePart(RefereeType refereeType,Match match)
        {
            if (!IsBusy)
            {
                if (refereeType == RefereeType.Technical)
                {
                    match.TechnicalReffere = this.LastName;
                    this.IsBusy = true;
                }
                else if (next != null)
                {
                    next.TakePart(refereeType,match);
                }
            }
            else if (next != null)
            {
                next.TakePart(refereeType,match);
            }
        }
    }
}
