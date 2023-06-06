namespace dotnetCampus.LatestCSharpFeatures.Tests;

[TestClass]
public class RequiredTest
{
    [TestMethod]
    public void CanBeCompiled()
    {
    }

    public record Foo(string Bar)
    {
        public required string R { get; init; }
    }
}
