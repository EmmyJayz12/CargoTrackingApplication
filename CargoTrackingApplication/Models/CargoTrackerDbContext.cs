using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CargoTrackingApplication.Models
{
    public class CargoTrackerDbContext:DbContext
    {
        public CargoTrackerDbContext(): base("TrackConn") { }
        public DbSet<TrackContactUs> Contacts { get; set; }
        public DbSet<ClientRegistration> ClientRegistrations { get; set; }
        public DbSet<TrackInfoUpdate> UpdateTrackerInformations { get; set; }
        public DbSet<AdminLogin> AdminLogins { get; set; }
    }
}