using System.Diagnostics.CodeAnalysis;

namespace dotnetCampus.LatestCSharpFeatures.Tests;

[TestClass]
public class NullableTest
{
    [TestMethod]
    public void CanBeCompiled()
    {
        MemberNotNull();
        TryDo("");
    }

    public string? Foo { get; set; }

    private bool TryDo([NotNullWhen(true)] string? text)
    {
        return false;
    }

    [MemberNotNull(nameof(Foo))]
    private void MemberNotNull()
    {
        Foo = "";
    }
}
