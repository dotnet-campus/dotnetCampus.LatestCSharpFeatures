# Latest CSharp Features

| Language                           |
| ---------------------------------- |
| [简体中文](/docs/README.zh-CHS.md) |
| [繁體中文](/docs/README.zh-CHT.md) |
| [English](/README.md)              |

[![NuGet](https://img.shields.io/nuget/v/dotnetCampus.LatestCSharpFeatures.svg)](https://www.nuget.org/packages/dotnetCampus.LatestCSharpFeatures)

This open-source project provides a NuGet package, dotnetCampus.LatestCSharpFeatures, which allows you to use the latest C# language features in older versions of .NET, including the old .NET Framework, .NET Standard, and older versions of .NET Core App and .NET.

## How to Use

Simply install the dotnetCampus.LatestCSharpFeatures NuGet package.

If you want these new language features to also be effective for other projects that reference this project, you can add a conditional compilation symbol in the csproj file:

```xml
<!-- By default, dotnetCampus.LatestCSharpFeatures introduces C# new features as internal modifiers into the current project.
     Using this conditional compilation symbol, you can set these types as public, so that other projects referencing this project can also use these new features. -->
<DefineConstants>$(DefineConstants);USE_PUBLIC_LATEST_CSHARP_FEATURES</DefineConstants>
```

## Feedback and Contributions

We welcome feedback and contributions from all users. If you encounter any problems during use, or have any suggestions for improvements, you can submit them via GitHub Issues.

If you wish to participate in the development of the project, you are also very welcome! You can Fork this repository and then submit a Pull Request.

Thank you for your support and help with dotnetCampus.LatestCSharpFeatures!
