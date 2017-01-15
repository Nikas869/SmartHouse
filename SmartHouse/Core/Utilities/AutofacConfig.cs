using Autofac;
using Core.Services;
using DataAccess;
using DataAccess.Interfaces;
using DataAccess.Repositories;

namespace Core.Utilities
{
    public static class AutofacConfig
    {
        public static void Configure(ref ContainerBuilder builder)
        {
            // Data access config
            builder.Register(db => new DatabaseContext("DatabaseContext")).InstancePerRequest();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            // Services config
            builder.RegisterType<ComponentService>().InstancePerRequest();
            builder.RegisterType<FacilitiesService>().InstancePerRequest();
        }
    }
}