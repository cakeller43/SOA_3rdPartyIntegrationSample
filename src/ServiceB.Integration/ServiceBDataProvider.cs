using System;
using System.Collections.Generic;
using ItOps.Integration.Interfaces;
using ItOps.Integration.Models;

namespace ServiceB
{
    public class ServiceBDataProvider : INeedServiceBData
    {
        public ServiceBData Get(Guid OrderId)
        {
            // Query DB
            return new ServiceBData { ItemsToShip = new List<Guid> {Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid()} };
        }
    }
}
