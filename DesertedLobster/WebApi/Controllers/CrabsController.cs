using Core;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

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
            return Ok(new[] { "Crab1", "Crab2", "Crab3", "Crab4" });
        }
    }
}
