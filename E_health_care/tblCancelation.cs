//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E_health_care
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCancelation
    {
        public int intCancelationID { get; set; }
        public Nullable<int> intAppointmentID { get; set; }
        public Nullable<int> intCancelByLoginID { get; set; }
        public string strReason { get; set; }
        public Nullable<System.DateTime> dtmCancelDateTime { get; set; }
    }
}