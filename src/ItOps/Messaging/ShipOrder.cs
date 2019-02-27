using System;
using NServiceBus;

namespace ItOps.Messaging
{
    public class ShipOrder : ICommand
    {
        public Guid OrderId { get; set; } 
    }
}