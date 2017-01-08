using System.Data.Entity;
using Web.Models.Components;
using Web.Models.Facilities;

namespace Web.DataAccess
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DatabaseContext")
        {
            Database.SetInitializer(new DatabaseContextInitializer());
        }

        public DbSet<Facility> Facilities { get; set; }

        public DbSet<SmoothSlider> SmoothSliders { get; set; }

        public DbSet<StepSlider> StepSliders { get; set; }

        public DbSet<Switch> Switches { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SmoothSlider>().ToTable("SmoothSliders");
            modelBuilder.Entity<StepSlider>().ToTable("StepSliders");
            modelBuilder.Entity<Switch>().ToTable("Switches");
            base.OnModelCreating(modelBuilder);
        }
    }
}