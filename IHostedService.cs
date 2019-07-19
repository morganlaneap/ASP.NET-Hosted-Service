using System.Threading;
using System.Threading.Tasks;

namespace HostedServiceLibrary
{
    public interface IHostedService
    {
        Task StartAsync(CancellationToken cancellationToken);        
        Task StopAsync(CancellationToken cancellationToken);
    }
}