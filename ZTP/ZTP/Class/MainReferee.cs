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
        public override void TakePart(RefereeType refereeType , Match match)
        {
            if (!IsBusy)
            {
                if (refereeType == RefereeType.Main)
                {
                    match.MainReffere = this.LastName;
                    this.IsBusy = true;
                }
                else if (refereeType == RefereeType.Technical)
                {
                    match.TechnicalReffere = this.LastName;
                    this.IsBusy = true;
                }
                else if (refereeType == RefereeType.Linear)
                {
                    match.LinearReffere = this.LastName;
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
