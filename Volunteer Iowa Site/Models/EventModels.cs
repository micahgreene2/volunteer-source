using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Volunteer_Iowa_Site.Models
{
    public class EventDataContext : DbContext
    {
        public EventDataContext() 
            : base("DefaultConnection")
        {
        }
        public DbSet<Event> Events { get; set; }
        public DbSet<AddressModel> Address { get; set; }
        public DbSet<CityModel> Cities { get; set; }
        public DbSet<CountyModel> Counties { get; set; }
        public DbSet<OrgModel> Orgs { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
    [Table("Event")]
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

        [Required]
        [DataType(DataType.PostalCode)]
        [Display(Name = "Address Id")]
        public int addressID { get; set; }
    }
    public class AddressModel
    {
        [Key]
        [DataType(DataType.Text)]
        [Display(Name = "Address ID")]
        public int addressID { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Address Line One")]
        public string addressLineOne { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Address Line Two")]
        public string addressLineTwo { get; set; }

        [DataType(DataType.PostalCode)]
        [Display(Name = "Zip")]
        public int addressZip { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "City ID")]
        public int cityId { get; set; }
    }
    public class CityModel
    {
        [Key]
        [DataType(DataType.Text)]
        [Display(Name = "City ID")]
        public int cityID { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "City Name")]
        public string cityName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "County ID")]
        public int countyID { get; set; }
    }
    public class CountyModel
    {
        [Key]
        [DataType(DataType.Text)]
        [Display(Name = "County ID")]
        public int countyID { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "County Name")]
        public string countyName { get; set; }
    }
    public class OrgModel
    {
        [Key]
        [DataType(DataType.Text)]
        [Display(Name = "Orginization ID")]
        public int orgID { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Orginization Name")]
        public string orgName { get; set; }
    }
}