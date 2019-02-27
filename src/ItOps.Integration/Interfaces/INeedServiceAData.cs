
using System;
using ItOps.Integration.Models;

namespace ItOps.Integration.Interfaces
{
    public interface INeedServiceAData
    {
        ServiceAData Get(Guid OrderId);
    }
}