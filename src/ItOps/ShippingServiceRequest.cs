using System;
using System.Collections.Generic;

namespace ItOps
{
    public class ShippingServiceRequest
    {
        public List<Guid> ItemsToShip { get; set; }
        public string ShippingMethod { get; set; }
        public string ShippingAddress { get; set; }
    }
}