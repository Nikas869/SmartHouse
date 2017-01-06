using System.Data.Entity;
using DataAccess.Entities.Components;
using DataAccess.Entities.Facilities;

namespace DataAccess
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(string connectionString) : base(connectionString)
        {
            Database.SetInitializer(new DatabaseContextInitializer());
        }

        public DbSet<BaseFacility> Facilities { get; set; }

        public DbSet<SmoothSlider> SmoothSliders { get; set; }

        public DbSet<StepSlider> StepSliders { get; set; }

        public DbSet<Switch> Switches { get; set; }
    }
}