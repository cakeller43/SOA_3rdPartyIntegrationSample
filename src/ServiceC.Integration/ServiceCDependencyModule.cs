using System;
using Autofac;

namespace ServiceC
{
    public class ServiceCDependencyModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ServiceCDataProvider>()
                .AsImplementedInterfaces();
        }
    }
}
