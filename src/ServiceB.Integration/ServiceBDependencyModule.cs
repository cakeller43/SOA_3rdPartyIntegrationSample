using System;
using Autofac;

namespace ServiceB
{
    public class ServiceBDependencyModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ServiceBDataProvider>()
                .AsImplementedInterfaces();
        }
    }
}
