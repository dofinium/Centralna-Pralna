//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PralnaDemo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Organization
    {
        public Organization()
        {
            this.Divisions = new HashSet<Division>();
            this.ViolationTypes = new HashSet<ViolationType>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CityId { get; set; }
    
        public virtual City City { get; set; }
        public virtual ICollection<Division> Divisions { get; set; }
        public virtual ICollection<ViolationType> ViolationTypes { get; set; }
    }
}
