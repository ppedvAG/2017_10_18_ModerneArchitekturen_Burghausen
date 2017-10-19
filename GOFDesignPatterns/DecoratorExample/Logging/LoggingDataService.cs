using DecoratorExample.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DecoratorExample.Logging
{
    internal class LoggingDataService : IDataService
    {
        private readonly IDataService baseDataService;
        private readonly ILogger logger;

        public LoggingDataService(IDataService baseDataService, ILogger logger)
        {
            this.baseDataService = baseDataService;
            this.logger = logger;
        }

        public IEnumerable<string> GetCustomers()
        {
            logger.Log($"{DateTime.Now.ToString("HH:mm:ss.fff")} | Customers laden gestartet.");

            var customers = baseDataService.GetCustomers();

            logger.Log($"{DateTime.Now.ToString("HH:mm:ss.fff")} | {customers.Count()} Customers wurden geladen.");

            return customers;
        }
    }
}
