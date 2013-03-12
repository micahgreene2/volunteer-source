using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Volunteer_Iowa_Site.Models
{
    public class EventDataContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
    }
    public class Event
    {
        [Required]
        [Key]
        [DataType(DataType.Text)]
        [Display(Name = "Event ID")]
        public int eventID { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Start Date")]
        public DateTime startDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "End Date")]
        public DateTime endDate { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Address Id")]
        public int addressID { get; set; }
    }
}