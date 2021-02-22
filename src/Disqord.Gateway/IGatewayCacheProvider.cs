﻿using Disqord.Collections.Synchronized;
using Disqord.Utilities.Binding;

namespace Disqord.Gateway
{
    /// <summary>
    ///     Represents a cache provider responsible for individual cache management for various entity types.
    /// </summary>
    public interface IGatewayCacheProvider : IBindable<IGatewayClient>
    {
        /// <summary>
        ///     Attempts to retrieve a top-level cache for the <typeparamref name="TEntity"/> type.
        /// </summary>
        /// <typeparam name="TEntity"> The type of the entities. </typeparam>
        /// <param name="cache"> The cache if the provider supports it. </param>
        /// <returns>
        ///     <see langword="true"/>, if the provider supports caching the type.
        /// </returns>
        bool TryGetCache<TEntity>(out ISynchronizedDictionary<Snowflake, TEntity> cache)
            where TEntity : CachedSnowflakeEntity;

        /// <summary>
        ///     Attempts to retrieve a nested cache for the <typeparamref name="TEntity"/> type.
        /// </summary>
        /// <typeparam name="TEntity"> The type of the entities. </typeparam>
        /// <param name="parentId"> The ID of the parent entity. E.g. a guild ID. </param>
        /// <param name="cache"> The cache if the provider supports it. </param>
        /// <returns>
        ///     <see langword="true"/>, if the provider supports caching the type.
        /// </returns>
        bool TryGetCache<TEntity>(Snowflake parentId, out ISynchronizedDictionary<Snowflake, TEntity> cache)
            where TEntity : CachedSnowflakeEntity;

        /// <summary>
        ///     Attempts to remove a nested cache for the <typeparamref name="TEntity"/> type.
        ///     This is called most often to notify the provider a parent entity
        ///     was destroyed so the allocated memory of the nested cache can be freed up.
        /// </summary>
        /// <typeparam name="TEntity"> The type of the entities. </typeparam>
        /// <param name="parentId"> The ID of the parent entity. </param>
        /// <param name="cache"> The cache if the provider supports it and had it allocated. </param>
        /// <returns>
        ///     <see langword="true"/>, if the provider supports caching the type and had the cache allocated.
        /// </returns>
        bool TryRemoveCache<TEntity>(Snowflake parentId, out ISynchronizedDictionary<Snowflake, TEntity> cache)
            where TEntity : CachedSnowflakeEntity;

        /// <summary>
        ///     Resets this cache provider.
        ///     This is called on new gateway sessions as the old cache has become stale.
        /// </summary>
        void Reset();
    }
}
