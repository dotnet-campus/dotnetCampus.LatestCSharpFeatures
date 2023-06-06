namespace dotnetCampus.LatestCSharpFeatures.Analyzer;
/// <summary>
/// 嵌入的文本资源的数据。
/// </summary>
/// <param name="EmbededName">文件在嵌入的资源中的名称。</param>
/// <param name="Content">文件的文本内容。</param>
internal readonly record struct EmbededSourceFile(string EmbededName, string Content)
{
    /// <summary>
    /// 根据资源名称猜测文件的无扩展名的名称。
    /// </summary>
    /// <returns>无扩展名的文件名。</returns>
    public ReadOnlySpan<char> GuessFileNameWithoutExtension()
    {
        var span = EmbededName.AsSpan();
        var secondLastDotIndex = 0;
        var lastDotIndex = 0;
        for (var i = 0; i < span.Length; i++)
        {
            var c = span[i];
            if (c is '.')
            {
                secondLastDotIndex = lastDotIndex;
                lastDotIndex = i;
            }
        }
        return lastDotIndex is 0
            ? span
            : span.Slice(secondLastDotIndex + 1, lastDotIndex - secondLastDotIndex - 1);
    }
}
