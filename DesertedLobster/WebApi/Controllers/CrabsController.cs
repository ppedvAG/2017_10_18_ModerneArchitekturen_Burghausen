using Core;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using WebApi.Dtos;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class CrabsController : Controller
    {
        private readonly ICrabRepository crabRepository;

        public CrabsController(ICrabRepository crabRepository) 
            => this.crabRepository = crabRepository ?? throw new ArgumentNullException(nameof(crabRepository));

        [HttpGet]
        public IActionResult GetCrabs()
        {
            var crabs = crabRepository.GetAll();

            var crabDtos = crabs.Select(c => new CrabDto
            {
                Id = c.Id,
                Name = c.Name,
                Weight = c.Weight
            });

            return Ok(crabDtos);
        }
    }
}
