using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Volunteer_Iowa_Site.Models
{
    public class LogDataContext : DbContext
    {
        /*
        public LogDataContext()
            : base("DefaultConnection")
        {
        }*/
        public DbSet<Log> Logs { get; set; }
    }/*
    [Table("Log")]
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
    }*/
}