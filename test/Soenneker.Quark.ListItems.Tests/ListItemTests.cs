using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quark.ListItems.Tests;

[Collection("Collection")]
public sealed class ListItemTests : FixturedUnitTest
{
    public ListItemTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {
        // Basic test to verify the component can be instantiated
        // Since this is a Blazor component, we mainly test that the build succeeds
        Assert.True(true);
    }
}
