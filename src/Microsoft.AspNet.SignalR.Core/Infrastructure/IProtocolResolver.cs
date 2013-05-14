using System;
using Microsoft.AspNet.SignalR.Hosting;

namespace Microsoft.AspNet.SignalR.Infrastructure
{
    internal interface IProtocolResolver
    {
        Version Resolve(IRequest request);
    }
}
