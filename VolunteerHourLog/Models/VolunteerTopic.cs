using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VolunteerHourLog.Models
{
    public class VolunteerTopic
    {
        public int VolunteerTopicID { get; set; }
        public string VolunteerTopicName { get; set; }
    }
}