using DecoratorExample.Core;
using System.Collections.Generic;

namespace DecoratorExample.Data
{
    internal class DataService : IDataService
    {
        public IEnumerable<string> GetCustomers() =>
            // select * from Customers
            new List<string>
            {
                "Hans",
                "Peter",
                "Stanislaus"
            };
    }
}
