using System;
using System.Data.Entity;
using Web.Models.Components;
using Web.Models.Facilities;

namespace Web.DataAccess
{
    public class DatabaseContextInitializer : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            var fac1 = new Facility(Guid.NewGuid(), "fac1");
            var sw = new Switch("sw1", false);
            var sl = new SmoothSlider("sl1", 10, 20);
            fac1.AddComponent(sw);
            fac1.AddComponent(sl);
            context.Switches.Add(sw);
            context.SmoothSliders.Add(sl);
            context.Facilities.Add(fac1);
            base.Seed(context);
        }
    }
}