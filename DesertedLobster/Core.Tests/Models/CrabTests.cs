using Core.Models;
using Shouldly;
using Xunit;

namespace Core.Tests.Models
{
    public class CrabTests
    {
        [Fact]
        public void New_crab_should_be_assigned_with_default_property_values()
        {
            var crab = new Crab();

            crab.Id.ShouldBe(default(int));
            crab.Name.ShouldBeNull();
            crab.Weight.ShouldBe(default(double));
        }
    }
}
