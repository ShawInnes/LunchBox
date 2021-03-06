﻿using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using WebSite.Models;

namespace WebSite
{
    public class AutofacConfig
    {
        public static void Register()
        {
            var builder = new ContainerBuilder();
            var assembly = Assembly.GetExecutingAssembly();

            builder.RegisterModelBinders(assembly);
            builder.RegisterModelBinderProvider();
            builder.RegisterControllers(assembly).PropertiesAutowired();
            builder.RegisterModule<AutofacWebTypesModule>();

            //builder.RegisterType<LoggingService>().As<ILoggingService>();
            builder.RegisterType<LunchBoxDbContext>().As<ILunchBoxDbContext>();

            IContainer container = builder.Build();
            container.ActivateGlimpse();

            // MVC dependency resolver
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            // WebAPI dependency resolver
            //GlobalConfiguration.Configuration.DependencyResolver = new Autofac.Integration.WebApi.AutofacWebApiDependencyResolver(container);

            // SignalR dependency resolver
            //GlobalHost.DependencyResolver = new Autofac.Integration.SignalR.AutofacDependencyResolver(container);
        }
    }
}