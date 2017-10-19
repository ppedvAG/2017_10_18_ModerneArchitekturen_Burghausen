using Shouldly;
using WebApi.Dtos;
using Xunit;

namespace WebApi.Tests.Dtos
{
    public class CrabDtoTests
    {
        [Fact]
        public void New_crabDto_should_be_assigned_with_default_property_values()
        {
            var crab = new CrabDto();

            crab.Id.ShouldBe(default(int));
            crab.Name.ShouldBeNull();
            crab.Weight.ShouldBe(default(double));
        }
    }
}
