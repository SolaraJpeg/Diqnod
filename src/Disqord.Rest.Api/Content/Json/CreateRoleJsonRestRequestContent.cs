using Disqord.Serialization.Json;

namespace Disqord.Rest.Api
{
    public class CreateRoleJsonRestRequestContent : JsonModelRestRequestContent
    {
        [JsonProperty("name")]
        public Optional<string> Name;

        [JsonProperty("permissions")]
        public Optional<ulong> Permissions;

        [JsonProperty("color")]
        public Optional<int> Color;

        [JsonProperty("hoist")]
        public Optional<bool> Hoist;

        [JsonProperty("mentionable")]
        public Optional<bool> Mentionable;
    }
}
