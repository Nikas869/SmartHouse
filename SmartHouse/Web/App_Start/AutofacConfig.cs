﻿using System.Reflection;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;

namespace Web
{
    public static class AutofacConfig
    {
        public static void Configure()
        {
            var builder = new ContainerBuilder();

            // Register Web Api controllers
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            // Configuring from BL
            Core.Utilities.AutofacConfig.Configure(ref builder);

            var container = builder.Build();

            // Setting the dependency resolver for MVC
            var mvcResolver = new AutofacDependencyResolver(container);
            DependencyResolver.SetResolver(mvcResolver);
        }
    }
}