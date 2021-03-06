using System.Threading.Tasks;
using Disqord.Rest.Api;

namespace Disqord.Rest
{
    public static partial class RestClientExtensions
    {
        public static async Task<IInvite> FetchInviteAsync(this IRestClient client, string code, IRestRequestOptions options = null)
        {
            var model = await client.ApiClient.FetchInviteAsync(code, options).ConfigureAwait(false);
            return new TransientInvite(client, model);
        }

        public static Task DeleteInviteAsync(this IRestClient client, string code, IRestRequestOptions options = null)
            => client.ApiClient.DeleteInviteAsync(code, options);
    }
}
