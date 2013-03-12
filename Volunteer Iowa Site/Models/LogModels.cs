using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Volunteer_Iowa_Site.Models
{
    public class Log
    {
        [Required]
        [Key]
        [DataType(DataType.Text)]
        [Display(Name = "Log ID")]
        public int logID { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "User ID")]
        public int userID { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Org Id")]
        public int orgID { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Event Id")]
        public int eventID { get; set; }
    
        [DataType(DataType.Duration)]
        [Display(Name="Hours Logged")]
        public int hoursLogged { get; set; }
    }
    public class Event
    {
        public int eventID { get; set; }
        public string Name { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int addressID { get; set; }
    }
    public class Org
    {

    }

}