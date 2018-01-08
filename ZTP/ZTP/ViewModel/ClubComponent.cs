using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTP.ViewModel
{
    public abstract class ClubComponent
    {
        protected long _ID;
        protected string _Name;
        public string sClubDisplay;
        public void Display(string s) { }
    }
}
