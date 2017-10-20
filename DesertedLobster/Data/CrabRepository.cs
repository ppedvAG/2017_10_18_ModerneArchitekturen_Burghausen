using System.Collections.Generic;
using Core;
using Core.Models;

namespace Data
{
    public class CrabRepository : ICrabRepository
    {
        public IEnumerable<Crab> GetAll() => new[]
        {
             new Crab { Id = 1, Name = "Procambarus clarkii", Weight = 735.2980536 },
             new Crab { Id = 2, Name = "Common Yabby", Weight = 567.09732 },
             new Crab { Id = 3, Name = "Norway Lobster", Weight = 457.6856},
             new Crab { Id = 4, Name = "Signal Crayfish", Weight = 457.35765 },
        };
    }
}
