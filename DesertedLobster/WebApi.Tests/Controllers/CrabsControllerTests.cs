using Core;
using FakeItEasy;
using Shouldly;
using System;
using WebApi.Controllers;
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
    }
}
