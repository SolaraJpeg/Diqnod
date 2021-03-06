namespace Disqord.Gateway
{
    /// <summary>
    ///     Represents a gateway Discord entity with a unique id.
    /// </summary>
    public abstract class CachedSnowflakeEntity : CachedEntity, ISnowflakeEntity
    {
        /// <inheritdoc/>
        public Snowflake Id { get; }

        protected CachedSnowflakeEntity(IGatewayClient client, Snowflake id)
            : base(client)
        {
            Id = id;
        }
    }
}
