namespace DecoratorExample.Caching
{
    internal interface ICache
    {
        void Add<T>(string key, T value);
        bool Contains(string key);
        T Get<T>(string key);
    }
}
