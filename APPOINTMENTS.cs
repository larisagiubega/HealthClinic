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
    
    public partial class APPOINTMENTS
    {
        public int APPOINTMENT_ID { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public System.DateTime APPOINTMENT_DATE { get; set; }
        public string PHONE_NUMBER { get; set; }
        public string DOCTOR_USERNAME { get; set; }
    
        public virtual USER USER { get; set; }
    }
}
