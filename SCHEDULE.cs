//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HealthClinic
{
    using System;
    using System.Collections.Generic;
    
    public partial class SCHEDULE
    {
        public int ID_SCHEDULE { get; set; }
        public string USERNAME { get; set; }
        public int ID_SHIFT { get; set; }
        public string CHANGED_BY { get; set; }
        public System.DateTime DATE { get; set; }
    
        public virtual SHIFT SHIFT { get; set; }
        public virtual USER USER { get; set; }
        public virtual USER USER1 { get; set; }
    }
}
