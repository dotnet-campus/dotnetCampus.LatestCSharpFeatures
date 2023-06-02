# Latest CSharp Features

| Language |
| --- |
| [简体中文](/docs/README.zh-CHS.md) |
| [繁體中文](/docs/README.zh-CHT.md) |
| [English](/README.md) |
| [日本語](/docs/README.jp.md) |

此开源项目提供一系列 NuGet 包，让您可以在旧版本的 .NET（包括旧的 .NET Framework、.NET Standard，以及旧的 .NET Core App、.NET）中，使用最新的 C# 语言特性。

## NuGet 包

我们目前提供 8 个 NuGet 包，您可以根据需要选择安装。

|包名|功能|链接|
|---|---|---|
|dotnetCampus.LatestCSharpFeatures|全功能包，包含所有 C# 新功能|[![NuGet](https://img.shields.io/nuget/v/dotnetCampus.LatestCSharpFeatures.svg)](https://www.nuget.org/packages/dotnetCampus.LatestCSharpFeatures)|
|dotnetCampus.LatestCSharpFeatures.Source|全功能包的源代码版本|[![NuGet](https://img.shields.io/nuget/v/dotnetCampus.LatestCSharpFeatures.Source.svg)](https://www.nuget.org/packages/dotnetCampus.LatestCSharpFeatures.Source)|
|dotnetCampus.IsExternalInit|支持使用 init 语法|[![NuGet](https://img.shields.io/nuget/v/dotnetCampus.IsExternalInit.svg)](https://www.nuget.org/packages/dotnetCampus.IsExternalInit)|
|dotnetCampus.IsExternalInit.Source|支持使用 init 语法的源代码版本|[![NuGet](https://img.shields.io/nuget/v/dotnetCampus.IsExternalInit.Source.svg)](https://www.nuget.org/packages/dotnetCampus.IsExternalInit.Source)|
|dotnetCampus.Nullable|支持使用丰富的可空支持|[![NuGet](https://img.shields.io/nuget/v/dotnetCampus.Nullable.svg)](https://www.nuget.org/packages/dotnetCampus.Nullable)|
|dotnetCampus.Nullable.Source|支持使用丰富的可空支持的源代码版本|[![NuGet](https://img.shields.io/nuget/v/dotnetCampus.Nullable.Source.svg)](https://www.nuget.org/packages/dotnetCampus.Nullable.Source)|
|dotnetCampus.Required|增加了 required 语法的支持*|[![NuGet](https://img.shields.io/nuget/v/dotnetCampus.Required.svg)](https://www.nuget.org/packages/dotnetCampus.Required)|
|dotnetCampus.Required.Source|增加了 required 语法支持的源代码版本*|[![NuGet](https://img.shields.io/nuget/v/dotnetCampus.Required.Source.svg)](https://www.nuget.org/packages/dotnetCampus.Required.Source)|

\* 对于 required 语法的介绍，您可以参考这里的[说明](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/required)【7†source】【9†source】。

## 使用方法

无论是全功能包还是单一功能包，我们都提供了两种版本。不带 .Source 后缀的包会生成一个 dll，这样所有引用了这个项目的项目都能使用到这些新功能。而带有 .Source 后缀的包则只对安装此包的项目有效，最终生成的项目中没有额外的 dll。

如果您希望 .Source 包对其他引用了此项目的项目也生效，可以在 csproj 文件中增加一个条件编译符：

```xml
<!-- 默认情况下，安装 .Source 后缀的包会将 C# 新特性以 internal 修饰符引入当前项目。
     使用此条件编译符，可以将这些类型设为 public，使得引用此项目的其他项目也能使用这些新特性。 -->
<DefineConstants>$(DefineConstants);USE_PUBLIC_LATEST_CSHARP_FEATURES</DefineConstants>
```

## 反馈与贡献

我们欢迎所有用户的反馈和贡献。如果你在使用过程中发现任何问题，或者有任何改进建议，都可以通过 GitHub Issues 提交。

如果你希望参与到项目的开发中，也非常欢迎！你可以 Fork 本仓库，然后提交 Pull Request。

感谢你对 dotnetCampus.LatestCSharpFeatures 的支持和帮助！
