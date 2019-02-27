using Autofac;
using System;
using System.Threading.Tasks;
using NServiceBus;
using ServiceA;
using ServiceB;
using ServiceC;
using ItOps.Messaging;

namespace ItOps
{
    class Program
    {
        static void Main()
        {
            AsyncMain().GetAwaiter().GetResult();
        }
        static async Task AsyncMain()
        {
            Console.Title = "ItOps.ShippingIntegration";
            var endpointConfig = new EndpointConfiguration("ItOps.ShippingIntegration");
            var transport = endpointConfig.UseTransport<LearningTransport>();
            
            ConfigureContainer(endpointConfig);
            var endpointInstance = await Endpoint.Start(endpointConfig);

            await endpointInstance.SendLocal(new ShipOrder { OrderId = Guid.NewGuid() });
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();

            await endpointInstance.Stop();
        }

        private static void ConfigureContainer(EndpointConfiguration endpointConfig)
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new ServiceADependencyModule());
            builder.RegisterModule(new ServiceBDependencyModule());
            builder.RegisterModule(new ServiceCDependencyModule());

            var container = builder.Build();
            endpointConfig.UseContainer<AutofacBuilder>(c => c.ExistingLifetimeScope(container));
        }
    }
}
