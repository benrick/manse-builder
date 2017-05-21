using FluentAssertions;
using Xunit;

namespace ManseBuilder.UnitTests
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
