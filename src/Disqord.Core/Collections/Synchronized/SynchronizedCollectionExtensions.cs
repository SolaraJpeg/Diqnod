using System.Collections.Generic;

namespace Disqord.Collections.Synchronized
{
    public static class SynchronizedCollectionExtensions
    {
        public static ISynchronizedDictionary<TKey, TValue> Synchronized<TKey, TValue>(this IDictionary<TKey, TValue> dictionary)
            => new SynchronizedDictionary<TKey, TValue>(dictionary);
    }
}
