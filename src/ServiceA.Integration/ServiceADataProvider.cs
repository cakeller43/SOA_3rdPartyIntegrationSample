using System;
using ItOps.Integration.Interfaces;
using ItOps.Integration.Models;

namespace ServiceA
{
    public class ServiceADataProvider : INeedServiceAData
    {
        public ServiceAData Get(Guid OrderId)
        {
            // Query DB
            return new ServiceAData { ShippingAddress = "123 address street" };
        }
    }
}
