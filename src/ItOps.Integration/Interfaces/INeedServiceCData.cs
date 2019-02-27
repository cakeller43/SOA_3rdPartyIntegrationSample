using System;
using ItOps.Integration.Models;

namespace ItOps.Integration.Interfaces
{
    public interface INeedServiceCData
    {
        ServiceCData Get(Guid OrderId);
    }
}