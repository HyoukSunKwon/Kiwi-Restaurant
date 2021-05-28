using Autofac;
using Autofac.Integration.Mvc;
using KiwiRestaurant.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KiwiRestaurant.Web
{
    public class ContainerConfig
    {
        internal static void registerContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<InMemoryFoodData>()
                   .As<IFoodData>()
                   .SingleInstance();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}