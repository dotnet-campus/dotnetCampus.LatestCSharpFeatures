﻿#if NET5_0_OR_GREATER
// .NET 5.0 开始已包含 IsExternalInit。
#else
// 旧框架需要包含 IsExternalInit。
using System.ComponentModel;

namespace System.Runtime.CompilerServices
{
    /// <summary>
    /// Reserved to be used by the compiler for tracking metadata.
    /// This class should not be used by developers in source code.
    /// This dummy class is required to compile records when targeting .NET Standard
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
#if USE_PUBLIC_LATEST_CSHARP_FEATURES
    public
#else
    internal
#endif
    static class IsExternalInit
    {
    }
}
#endif