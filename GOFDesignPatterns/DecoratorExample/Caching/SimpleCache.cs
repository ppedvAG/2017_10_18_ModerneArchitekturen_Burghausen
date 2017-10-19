using System.Collections.Generic;

namespace DecoratorExample.Caching
{
    internal class SimpleCache : ICache
    {
        private Dictionary<string, object> dictionary = new Dictionary<string, object>();

        public void Add<T>(string key, T value) => dictionary[key] = value;
        public bool Contains(string key) => dictionary.ContainsKey(key);
        public T Get<T>(string key) => (T)dictionary[key];
    }
}
