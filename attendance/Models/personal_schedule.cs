//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace attendance.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    
    public partial class personal_schedule
    {
        public long PersinalScheduleID { get; set; }
        [DisplayName("Employee ID")]
        public int pin { get; set; }
        [DisplayName("Schedule ID")]
        public int schedule_id { get; set; }
        [DisplayName("Schedule Start")]
        public System.DateTime ScheduleStart { get; set; }
        [DisplayName("Schedule End")]
        public System.DateTime SheduleEnd { get; set; }
    }
}
