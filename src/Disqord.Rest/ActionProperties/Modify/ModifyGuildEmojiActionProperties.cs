using System.Collections.Generic;

namespace Disqord
{
    public sealed class ModifyGuildEmojiActionProperties
    {
        public Optional<string> Name { internal get; set; }

        public Optional<IEnumerable<Snowflake>> RoleIds { internal get; set; }

        internal ModifyGuildEmojiActionProperties()
        { }
    }
}
