using System.Diagnostics.CodeAnalysis;

namespace dotnetCampus.LatestCSharpFeatures.Tests;

[TestClass]
public class IsExternalInitTest
{
    [TestMethod]
    public void CanBeCompiled()
    {
    }

    public record Foo(string Bar);
}
