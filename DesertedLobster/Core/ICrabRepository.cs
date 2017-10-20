using Core.Models;
using System.Collections.Generic;

namespace Core
{
    public interface ICrabRepository
    {
        IEnumerable<Crab> GetAll();
    }
}
