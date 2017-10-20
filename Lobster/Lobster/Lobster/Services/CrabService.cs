using System.Collections.Generic;
using System.Threading.Tasks;
using Lobster.Models;

namespace Lobster.Services
{
    public class CrabService : ICrabService
    {
        public async Task<IEnumerable<Crab>> GetCrabs()
        {
            return await Task.FromResult(new[]
            {
                new Crab { Id = 1, Name = "From Service" }
            });
        }
    }
}
