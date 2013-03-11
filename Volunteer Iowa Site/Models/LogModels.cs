using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Volunteer_Iowa_Site.Models
{
    public class LogModels
    {
        public int logID { get; set; }
        public int userID { get; set; }
        public int orgID { get; set; }
        public int eventID { get; set; }
        public int hoursLogged { get; set; }
    }
    public class EventModul
    {
        public int eventID { get; set; }
        public string Name { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int addressID { get; set; }
    }
    public class OrgModul
    {

    }

}