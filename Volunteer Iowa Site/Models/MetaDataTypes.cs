using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Volunteer_Iowa_Site.Models
{
    [MetadataType(typeof(LogMetaData))]
    public partial class Log{}
    [MetadataType(typeof(EventMetaData))]
    public partial class Event {}
    [MetadataType(typeof(AddressMetaData))]
    public partial class Address {}
    [MetadataType(typeof(CityMetaData))]
    public partial class City {}
    [MetadataType(typeof(CountyMetaData))]
    public partial class County {}
    [MetadataType(typeof(OrgMetaData))]
    public partial class Org {}

    public class EventMetaData
    {
        [DataType(DataType.Text)]
        [Display(Name = "Event ID")]
        public int eventID { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Name")]
        public string eventName { get; set; }

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
    public class AddressMetaData
    {
        [DataType(DataType.Text)]
        [Display(Name = "Address ID")]
        public int Id { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Address Line One")]
        public string lineOne { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Address Line Two")]
        public string lineTwo { get; set; }

        [DataType(DataType.PostalCode)]
        [Display(Name = "Zip")]
        public int zip { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "City ID")]
        public int cityID { get; set; }
    }
    public class CityMetaData
    {
        [DataType(DataType.Text)]
        [Display(Name = "City ID")]
        public int Id { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "City Name")]
        public string name { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "County ID")]
        public int countyID { get; set; }
    }
    public class CountyMetaData
    {
        [DataType(DataType.Text)]
        [Display(Name = "County ID")]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "County Name")]
        public string name { get; set; }
    }
    public class OrgMetaData
    {
        [DataType(DataType.Text)]
        [Display(Name = "Orginization ID")]
        public int orgID { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Orginization Name")]
        public string orgName { get; set; }
    }
    public class LogMetaData
    {
        [DataType(DataType.Text)]
        [Display(Name = "Log ID")]
        public int logID { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "User ID")]
        public int userId { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Org Id")]
        public int orgID { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Event Id")]
        public int eventID { get; set; }

        [DataType(DataType.Duration)]
        [Display(Name = "Hours Logged")]
        public int hoursLogged { get; set; }
    }
}