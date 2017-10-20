using AutoMapper;
using Core;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.Dtos;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class CrabsController : Controller
    {
        private readonly ICrabRepository crabRepository;
        private readonly IMapper mapper;

        public CrabsController(ICrabRepository crabRepository, IMapper mapper)
        {
            this.crabRepository = crabRepository ?? throw new ArgumentNullException(nameof(crabRepository));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public IActionResult GetCrabs()
        {
            var crabs = crabRepository.GetAll();

            var crabDtos = mapper.Map<IEnumerable<CrabDto>>(crabs);

            return Ok(crabDtos);
        }
    }
}
