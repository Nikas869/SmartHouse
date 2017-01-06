using System;
using System.Data.Entity;
using DataAccess.Entities.Components;
using DataAccess.Entities.Facilities;

namespace DataAccess
{
    public class DatabaseContextInitializer : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            var fac1 = new BaseFacility(Guid.NewGuid(), "fac1");
            var sw = new Switch(Guid.NewGuid(), "sw1", false);
            var sl = new SmoothSlider(Guid.NewGuid(), "sl1", 10, 20);
            fac1.AddComponent(sw);
            fac1.AddComponent(sl);
            context.Switches.Add(sw);
            context.SmoothSliders.Add(sl);
            context.Facilities.Add(fac1);
            base.Seed(context);
        }
    }
}