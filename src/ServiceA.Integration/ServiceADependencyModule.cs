using System;
using Autofac;

namespace ServiceA
{
    public class ServiceADependencyModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ServiceADataProvider>()
                .AsImplementedInterfaces();
        }
    }
}
