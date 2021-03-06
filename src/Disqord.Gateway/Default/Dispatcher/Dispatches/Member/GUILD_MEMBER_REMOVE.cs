using System.Threading.Tasks;
using Disqord.Gateway.Api;
using Disqord.Gateway.Api.Models;

namespace Disqord.Gateway.Default.Dispatcher
{
    public class GuildMemberRemoveHandler : Handler<GuildMemberRemoveJsonModel, MemberLeftEventArgs>
    {
        public override ValueTask<MemberLeftEventArgs> HandleDispatchAsync(IGatewayApiClient shard, GuildMemberRemoveJsonModel model)
        {
            IUser user;
            if (CacheProvider.TryGetMembers(model.GuildId, out var cache) && cache.TryRemove(model.User.Id, out var cachedMember))
            {
                user = cachedMember;
            }
            else
            {
                user = new TransientUser(Client, model.User);
            }

            var e = new MemberLeftEventArgs(model.GuildId, user);
            return new(e);
        }
    }
}
