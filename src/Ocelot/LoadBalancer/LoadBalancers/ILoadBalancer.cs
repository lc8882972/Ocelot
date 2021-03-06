using System;
using System.Threading.Tasks;
using Ocelot.Responses;
using Ocelot.Values;

namespace Ocelot.LoadBalancer.LoadBalancers
{
    public interface ILoadBalancer
    {
        Task<Response<HostAndPort>> Lease();
        void Release(HostAndPort hostAndPort);
    }
}