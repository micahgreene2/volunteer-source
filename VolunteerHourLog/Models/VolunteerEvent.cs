using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VolunteerHourLog.Models
{
    public class VolunteerEvent
    {
            public int VolunteerEventID { get; set; }   
            public DateTime VolunteerDate { get; set; }
            public int ZIPcode { get; set; }
            public int Hours { get; set; }
            public string Topic { get; set; }

        

    }
}