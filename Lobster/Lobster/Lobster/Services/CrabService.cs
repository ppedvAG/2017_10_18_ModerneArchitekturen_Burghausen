using Lobster.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Lobster.Services
{
    public class CrabService : ICrabService
    {
        public async Task<IEnumerable<Crab>> GetCrabs()
        {
            var client = new HttpClient();

            var response = await client.GetAsync(new Uri("http://crabs.azurewebsites.net/api/crabs"));
            var json = await response.Content.ReadAsStringAsync();

            var crabs = JsonConvert.DeserializeObject<IEnumerable<Crab>>(json);

            return crabs;
        }
    }
}