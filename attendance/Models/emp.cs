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
    
    public partial class emp
    {
        public int pin { get; set; }
        [DisplayName ("Employee Name")]
        public string EmployeeName { get; set; }
        [DisplayName("Designation")]
        public string Description { get; set; }
    }
}
