using System;
using System.Collections.Generic;
using ItOps.Integration.Interfaces;
using ItOps.Integration.Models;

namespace ServiceC
{
    public class ServiceCDataProvider : INeedServiceCData
    {
        public ServiceCData Get(Guid OrderId)
        {
            // Query DB
            return new ServiceCData { ShippingMethod = "Priority" };
        }
    }
}
