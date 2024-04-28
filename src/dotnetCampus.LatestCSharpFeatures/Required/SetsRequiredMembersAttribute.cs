#if NET7_0_OR_GREATER
// .NET 7.0 开始已包含 required。
#else
// 旧框架需要包含 required。
namespace System.Diagnostics.CodeAnalysis
{
    /// <summary>
    /// Specifies that this constructor sets all required members for the current type, and callers
    /// do not need to set any required members themselves.
    /// </summary>
    [AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false, Inherited = false)]
#if USE_PUBLIC_LATEST_CSHARP_FEATURES
    public
#else
    internal
#endif
    sealed class SetsRequiredMembersAttribute : Attribute
    {
    }
}
#endif