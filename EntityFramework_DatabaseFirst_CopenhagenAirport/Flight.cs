//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFramework_DatabaseFirst_CopenhagenAirport
{
    using System;
    using System.Collections.Generic;
    
    public partial class Flight
    {
        public int id { get; set; }
        public int companyId { get; set; }
        public int routeId { get; set; }
        public System.DateTime departure { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual Route Route { get; set; }
    }
}
