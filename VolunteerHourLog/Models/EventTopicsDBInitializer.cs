using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace VolunteerHourLog.Models
{
    public class EventTopicsDBInitializer:DropCreateDatabaseAlways<VolunteerEventContext>
    {
        protected override void Seed(VolunteerEventContext context)
        {

            string[] lines = System.IO.File.ReadAllLines(HostingEnvironment.ApplicationPhysicalPath + "App_Data\\volunteerTopics.txt");
            foreach (string line in lines)
            {
                context.VolunteerTopics.Add(new VolunteerTopic { VolunteerTopicName = line });
                //System.Diagnostics.Debug.Write(line);
            }
        }

    }
}