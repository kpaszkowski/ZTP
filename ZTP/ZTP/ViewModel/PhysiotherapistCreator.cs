using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTP.ViewModel
{
    class PhysiotherapistCreator : StaffCreator
    {
        override public StaffMember staffMemberFactoryMethod() { return new Physiotherapist(); }
    }
}
