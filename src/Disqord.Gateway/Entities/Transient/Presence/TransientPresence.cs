using System.Collections.Generic;
using Disqord.Collections;
using Disqord.Gateway.Api.Models;

namespace Disqord.Gateway
{
    public class TransientPresence : TransientEntity<PresenceJsonModel>, IPresence
    {
        /// <inheritdoc/>
        public Snowflake MemberId => Model.User.Id;

        /// <inheritdoc/>
        public Snowflake GuildId => Model.GuildId;

        /// <inheritdoc/>
        public IReadOnlyList<IActivity> Activities => _activities ??= Model.Activities.ToReadOnlyList(Client, (x, client) => TransientActivity.Create(client, x));

        private IReadOnlyList<IActivity> _activities;

        /// <inheritdoc/>
        public UserStatus Status => Model.Status;

        /// <inheritdoc/>
        public IReadOnlyDictionary<UserClient, UserStatus> Statuses => Model.ClientStatus;

        public TransientPresence(IClient client, PresenceJsonModel model)
            : base(client, model)
        { }
    }
}
