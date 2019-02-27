using System;
using ItOps.Integration.Models;

namespace ItOps.Integration.Interfaces
{
    public interface INeedServiceBData
    {
        ServiceBData Get(Guid OrderId);
    }
}