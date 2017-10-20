using Lobster.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lobster.Services
{
    public interface ICrabService
    {
        Task<IEnumerable<Crab>> GetCrabs();
    }
}
