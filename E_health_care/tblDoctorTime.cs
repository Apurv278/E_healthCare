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
    
    public partial class tblDoctorTime
    {
        public int intTimeID { get; set; }
        public Nullable<int> intDoctorID { get; set; }
        public Nullable<int> intClinicID { get; set; }
        public Nullable<int> intDayNo { get; set; }
        public Nullable<System.DateTime> dtmFromTime { get; set; }
        public Nullable<System.DateTime> dtmToTime { get; set; }
        public Nullable<decimal> decCharges { get; set; }
    }
}