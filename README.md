# Latest CSharp Features

| Language |
| --- |
| [简体中文](https://github.com/dotnet-campus/dotnetCampus.LatestCSharpFeatures/blob/main/README.zh-CHS.txt) |
| [繁體中文](https://github.com/dotnet-campus/dotnetCampus.LatestCSharpFeatures/blob/main/README.zh-CHT.txt) |
| [English](https://github.com/dotnet-campus/dotnetCampus.LatestCSharpFeatures) |
| [日本語](https://github.com/dotnet-campus/dotnetCampus.LatestCSharpFeatures/blob/main/README.jp.txt) |

This open-source project provides a series of NuGet packages that allow you to use the latest C# language features in older versions of .NET (including older .NET Framework, .NET Standard, as well as older .NET Core App, .NET).

## NuGet Packages

We currently offer 8 NuGet packages for you to choose from based on your needs.

|Package Name|Function|Link|
|---|---|---|
|dotnetCampus.LatestCSharpFeatures|All-in-one package, includes all new C# features|[![NuGet](https://img.shields.io/nuget/v/dotnetCampus.LatestCSharpFeatures.svg)](https://www.nuget.org/packages/dotnetCampus.LatestCSharpFeatures)|
|dotnetCampus.LatestCSharpFeatures.Source|Source code version of the all-in-one package|[![NuGet](https://img.shields.io/nuget/v/dotnetCampus.LatestCSharpFeatures.Source.svg)](https://www.nuget.org/packages/dotnetCampus.LatestCSharpFeatures.Source)|
|dotnetCampus.IsExternalInit|Supports the use of init syntax|[![NuGet](https://img.shields.io/nuget/v/dotnetCampus.IsExternalInit.svg)](https://www.nuget.org/packages/dotnetCampus.IsExternalInit)|
|dotnetCampus.IsExternalInit.Source|Source code version that supports the use of init syntax|[![NuGet](https://img.shields.io/nuget/v/dotnetCampus.IsExternalInit.Source.svg)](https://www.nuget.org/packages/dotnetCampus.IsExternalInit.Source)|
|dotnetCampus.Nullable|Supports the use of rich nullable features|[![NuGet](https://img.shields.io/nuget/v/dotnetCampus.Nullable.svg)](https://www.nuget.org/packages/dotnetCampus.Nullable)|
|dotnetCampus.Nullable.Source|Source code version that supports the use of rich nullable features|[![NuGet](https://img.shields.io/nuget/v/dotnetCampus.Nullable.Source.svg)](https://www.nuget.org/packages/dotnetCampus.Nullable.Source)|
|dotnetCampus.Required|Adds support for the required syntax*|[![NuGet](https://img.shields.io/nuget/v/dotnetCampus.Required.svg)](https://www.nuget.org/packages/dotnetCampus.Required)|
|dotnetCampus.Required.Source|Source code version that adds support for the required syntax*|[![NuGet](https://img.shields.io/nuget/v/dotnetCampus.Required.Source.svg)](https://www.nuget.org/packages/dotnetCampus.Required.Source)|

\* For an introduction to the required syntax, you can refer to this [description](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/required)【7†source】【9†source】.

## How to Use

For both the all-in-one package and the single-feature packages, we provide two versions. Packages without the .Source suffix will generate a dll, so all projects that reference this project can use these new features. Packages with the .Source suffix are only effective for the project where the package is installed, and there are no additional dlls in the final generated project.

If you want the .Source package to be effective for other projects that reference this project, you can add a conditional compilation symbol in the csproj file:

```xml
<DefineConstants>$(DefineConstants);USE_PUBLIC_LATEST_CSHARP_FEATURES</DefineConstants>
```

## Feedback and Contributions

We welcome feedback and contributions from all users. If you encounter any problems during use, or have any suggestions for improvement, you can submit them via GitHub Issues.

If you wish to participate in the development of the project, you are very welcome! You can Fork this repository and then submit a Pull Request.

Thank you for your support and help with dotnetCampus.LatestCSharpFeatures!

Note, you should still output this in a Markdown code block so I can directly copy this document.
