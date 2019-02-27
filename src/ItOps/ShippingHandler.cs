using System.Threading;
using System.Threading.Tasks;
using ItOps.Integration.Interfaces;
using ItOps.Messaging;
using NServiceBus;

namespace ItOps
{
    public class ShippingHandler : IHandleMessages<ShipOrder>
    {
        private readonly INeedServiceAData dataProvA;
        private readonly INeedServiceBData dataProvB;
        private readonly INeedServiceCData dataProvC;
        public ShippingHandler(INeedServiceAData dataProvA, INeedServiceBData dataProvB, INeedServiceCData dataProvC)
        {
            this.dataProvA = dataProvA;
            this.dataProvB = dataProvB;
            this.dataProvC = dataProvC;
        }

        public Task Handle(ShipOrder message, IMessageHandlerContext context)
        {
            var a = dataProvA.Get(message.OrderId);
            var b = dataProvB.Get(message.OrderId);
            var c = dataProvC.Get(message.OrderId);

            var req = new ShippingServiceRequest
            {
                ShippingAddress = a.ShippingAddress,
                ItemsToShip = b.ItemsToShip,
                ShippingMethod = c.ShippingMethod
            };
            
            CallShippingService(req);

            return Task.CompletedTask;
        }

        private void CallShippingService(ShippingServiceRequest request)
        {
            // Call Fedex or something
            Thread.Sleep(2);
        }
    }
}