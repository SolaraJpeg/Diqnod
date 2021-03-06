using System.Threading.Tasks;
using Disqord.Gateway.Api;
using Disqord.Gateway.Api.Models;

namespace Disqord.Gateway.Default.Dispatcher
{
    public class GuildIntegrationsUpdateHandler : Handler<GuildIntegrationsUpdateJsonModel, IntegrationsUpdatedEventArgs>
    {
        public override ValueTask<IntegrationsUpdatedEventArgs> HandleDispatchAsync(IGatewayApiClient shard, GuildIntegrationsUpdateJsonModel model)
        {
            var e = new IntegrationsUpdatedEventArgs(model.GuildId);
            return new(e);
        }
    }
}
