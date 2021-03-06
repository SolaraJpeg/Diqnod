using Disqord.Models;
using Disqord.Serialization.Json;

namespace Disqord.Rest.Api
{
    public class ModifyWebhookMessageJsonRestRequestContent : JsonModelRestRequestContent
    {
        [JsonProperty("content")]
        public Optional<string> Content;

        [JsonProperty("embeds")]
        public Optional<EmbedJsonModel[]> Embeds;

        [JsonProperty("allowed_mentions")]
        public Optional<AllowedMentionsJsonModel> AllowedMentions;

        [JsonProperty("attachments")]
        public Optional<AttachmentJsonModel[]> Attachments;

        [JsonProperty("components")]
        public Optional<ComponentJsonModel[]> Components;
    }
}
