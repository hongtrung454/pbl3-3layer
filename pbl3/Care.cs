//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pbl3
{
    using System;
    using System.Collections.Generic;
    
    public partial class Care
    {
        public int CareID { get; set; }
        public int PlantingID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> Watering { get; set; }
        public Nullable<int> Fertilizing { get; set; }
    
        public virtual Planting Planting { get; set; }
    }
}
