using Core;
using Core.Models;
using FakeItEasy;
using Microsoft.AspNetCore.Mvc;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Controllers;
using WebApi.Dtos;
using Xunit;

namespace WebApi.Tests.Controllers
{
    public class CrabsControllerTests
    {
        [Fact]
        public void Constructor_when_crabRepository_is_null_should_throw_ArgumentNullException()
            => Should.Throw<ArgumentNullException>(() => new CrabsController(null));

        [Fact]
        public void Can_create_instance()
        {
            var repository = A.Fake<ICrabRepository>();
            var controller = new CrabsController(repository);

            controller.ShouldNotBeNull();
        }

        [Fact]
        public void GetCrabs_should_return_IActionResult_with_content_of_type_IEnumerable_of_CrabDto()
        {
            var repository = A.Fake<ICrabRepository>();
            var controller = new CrabsController(repository);

            var response = controller.GetCrabs();
            
            var result = response.ShouldBeOfType<OkObjectResult>();
            result.Value.ShouldBeAssignableTo<IEnumerable<CrabDto>>();
        }

        [Fact]
        public void GetCrabs_should_return_data_from_repository()
        {
            var repository = A.Fake<ICrabRepository>();
            A.CallTo(() => repository.GetAll()).Returns(new[]
            {
                new Crab { Id = 39854, Name = "Crab1_alsökdfhlashg", Weight = 735.2980536 },
                new Crab { Id = 23643, Name = "Crab2_kljsdfhgsfgas", Weight = 567.09732 },
                new Crab { Id = 36653, Name = "Crab3_iozgasljtönas", Weight = 457.6856},
                new Crab { Id = 84834, Name = "Crab4_oishgjtbaskas", Weight = 457.35765 },
            });

            var controller = new CrabsController(repository);

            var response = controller.GetCrabs();

            var result = response.ShouldBeOfType<OkObjectResult>();
            var crabDtos = result.Value.ShouldBeAssignableTo<IEnumerable<CrabDto>>();
            crabDtos.Count().ShouldBe(4);
            crabDtos.ShouldContain(c => c.Id == 23643);
            crabDtos.ShouldContain(c => c.Name == "Crab3_iozgasljtönas" && c.Weight == 457.6856);

            A.CallTo(() => repository.GetAll()).MustHaveHappened();
        }
    }
}
