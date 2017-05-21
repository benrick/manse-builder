using FluentAssertions;
using Xunit;

namespace ManseBuilder.IntegrationTests
{
    public class TrueShould
    {
        [Fact]
        public void BeTrue()
        {
            true.Should().BeTrue();
        }
    }
}
