using DecoratorExample.Core;
using StructureMap;
using System;
using System.Collections.Generic;

namespace DecoratorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //var logger = new Logging.ConsoleLogger();
            //var cache = new Caching.SimpleCache();

            //IDataService dataService = new Data.DataService();
            //dataService = new Logging.LoggingDataService(dataService, logger);
            //dataService = new Caching.CachingDataService(dataService, cache);
            //var vm = new ViewModel(dataService);

            var container = new Container();

            container.Configure(c => c.AddRegistry<CommonRegistry>());


            var vm = container.GetInstance<ViewModel>();

            do
            {
                vm.Initialize();

                foreach (var c in vm.Customers)
                    Console.WriteLine(c);

                Console.WriteLine();
            }
            while (Console.ReadKey().Key != ConsoleKey.Q);
        }
    }

    internal class ViewModel
    {
        private readonly IDataService dataService;

        public ViewModel(IDataService dataService) => this.dataService = dataService;

        public IEnumerable<string> Customers { get; internal set; }

        internal void Initialize() => Customers = dataService.GetCustomers();
    }

    internal class CommonRegistry : Registry
    {
        public CommonRegistry()
        {
            For<Logging.ILogger>().Use<Logging.ConsoleLogger>().Singleton();
            For<Caching.ICache>().Use<Caching.SimpleCache>().Singleton();

            For<IDataService>().Use<Data.DataService>();

            For<IDataService>().DecorateAllWith<Logging.LoggingDataService>();
            For<IDataService>().DecorateAllWith<Caching.CachingDataService>();
        }
    }
}
