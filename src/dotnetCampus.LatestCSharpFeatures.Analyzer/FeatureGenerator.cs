using dotnetCampus.LatestCSharpFeatures.Analyzer;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Text;

using System.Text;

/// <summary>
/// 为 IPC 接口生成对应的代理（Proxy）和对接（Joint）。
/// </summary>
[Generator(LanguageNames.CSharp)]
public class FeatureGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        context.RegisterSourceOutput(context.AnalyzerConfigOptionsProvider, OnExecute);
    }

    private void OnExecute(SourceProductionContext context, AnalyzerConfigOptionsProvider provider)
    {
        GenerateFeatureSource(context, provider, "IsExternalInit");
        GenerateFeatureSource(context, provider, "Nullable");
        GenerateFeatureSource(context, provider, "Required");
    }

    private void GenerateFeatureSource(SourceProductionContext context, AnalyzerConfigOptionsProvider provider, string featureName)
    {
        //if (provider.GlobalOptions.TryGetValue($"build_property._dotnetCampusUse{featureName}", out var useFeature)
        //    && useFeature.Equals(featureName, StringComparison.OrdinalIgnoreCase))
        {
            foreach (var source in EmbededSourceFiles.Enumerate($"Features.{featureName}"))
            {
                var name = source.GuessFileNameWithoutExtension().ToString();
                context.AddSource($"{name}.g.cs", SourceText.From(source.Content, Encoding.UTF8));
            }
        }
    }
}
