using System;

namespace SingletonExample
{
    internal class Configuration : IDisposable
    {
        private Configuration()
        { }

        private static Configuration instance;
        public static Configuration Instance => instance ?? (instance = new Configuration());

        public void Load() { /* Lade die Konfiguration */ }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
