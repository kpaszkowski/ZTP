//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Football
{
    using System;
    using System.Collections.Generic;
    
    public partial class Player
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int clubID { get; set; }
        public Nullable<int> recordID { get; set; }
    
        public virtual Club Club { get; set; }
        public virtual Record Record { get; set; }
    }
}
