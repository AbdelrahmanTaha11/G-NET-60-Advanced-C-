
namespace G_NET_60_Advanced_C_
{
    internal class Cache<TKey, TValue>
    {
        private class CacheItem
        {
            public TValue Value { get; set; }
            public DateTime Expiration { get; set; }
        }

        private Dictionary<TKey, CacheItem> cache = new Dictionary<TKey, CacheItem>();

        public void Add(TKey key, TValue value, TimeSpan duration)
        {
            cache[key] = new CacheItem
            {
                Value = value,
                Expiration = DateTime.Now.Add(duration)
            };
        }

        public TValue Get(TKey key)
        {
            if (Contains(key))
                return cache[key].Value;

            return default;
        }

        public bool Contains(TKey key)
        {
            if (!cache.ContainsKey(key))
                return false;

            if (DateTime.Now > cache[key].Expiration)
            {
                cache.Remove(key);
                return false;
            }

            return true;
        }

        public bool Remove(TKey key)
        {
            return cache.Remove(key);
        }

    }
}
