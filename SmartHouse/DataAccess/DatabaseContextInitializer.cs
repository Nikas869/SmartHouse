using System;
using System.Data.Entity;
using DataAccess.Models.Components;
using DataAccess.Models.Facilities;

namespace DataAccess
{
    public class DatabaseContextInitializer : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            var fac1 = new Facility(Guid.NewGuid(), "facility1");
            var sw = new Switch(Guid.NewGuid(), "switch1", false);
            var sl = new SmoothSlider(Guid.NewGuid(), "slider1", 10, 20);
            fac1.AddComponent(sw);
            fac1.AddComponent(sl);
            context.Switches.Add(sw);
            context.SmoothSliders.Add(sl);
            context.Facilities.Add(fac1);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}