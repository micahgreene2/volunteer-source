using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Volunteer_Iowa_Site.Models
{
    public class LogDataContext : DbContext
    {
        public DbSet<Log> Logs { get; set; }
    }
}