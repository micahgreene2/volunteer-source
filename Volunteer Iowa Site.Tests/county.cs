//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Volunteer_Iowa_Site
{
    using System;
    using System.Collections.Generic;
    
    public partial class county
    {
        public county()
        {
            this.Cities = new HashSet<City>();
        }
    
        public int Id { get; set; }
        public string name { get; set; }
    
        public virtual ICollection<City> Cities { get; set; }
    }
}