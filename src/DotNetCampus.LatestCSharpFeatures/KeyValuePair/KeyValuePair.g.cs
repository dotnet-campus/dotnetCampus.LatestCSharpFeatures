#nullable enable
namespace System.Collections.Generic;

#if NETSTANDARD2_1 || NETCOREAPP3_0 || NETCOREAPP3_1 || NET5_0_OR_GREATER
#else
/// <summary>
/// Provide extension methods for <see cref="KeyValuePair{TKey,TValue}"/>.
/// </summary>
#if USE_PUBLIC_LATEST_CSHARP_FEATURES
    public
#else
internal
#endif
    static class DotNetCampusLatestCSharpFeaturesKeyValuePairExtensions
{
    internal static void Deconstruct<TKey, TValue>(this KeyValuePair<TKey, TValue> pair, out TKey key, out TValue value)
    {
        key = pair.Key;
        value = pair.Value;
    }
}
#endif
