using System.Collections.Generic;
using DecoratorExample.Core;
using System;

namespace DecoratorExample.Caching
{
    internal class CachingDataService : IDataService
    {
        private readonly IDataService dataService;
        private readonly ICache cache;

        public CachingDataService(IDataService dataService, ICache cache)
        {
            this.dataService = dataService;
            this.cache = cache;
        }

        private DateTime lastLoadingTime;

        public IEnumerable<string> GetCustomers()
        {
            var cacheKey = $"{nameof(CachingDataService)}.{nameof(GetCustomers)}";

            var shouldReloadData = (DateTime.Now - lastLoadingTime).TotalSeconds > 10;

            if (shouldReloadData)
            {
                cache.Add(cacheKey, dataService.GetCustomers());
                lastLoadingTime = DateTime.Now;
            }

            return cache.Get<IEnumerable<string>>(cacheKey);
        }
    }
}
