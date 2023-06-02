# 最新的 CSharp 特性

| Language |
| --- |
| [简体中文](/docs/README.zh-CHS.md) |
| [繁體中文](/docs/README.zh-CHT.md) |
| [English](/README.md) |
| [日本語](/docs/README.jp.md) |

此開源項目提供一系列 NuGet 包，讓您可以在舊版本的 .NET（包括舊的 .NET Framework、.NET Standard，以及舊的 .NET Core App、.NET）中，使用最新的 C# 語言特性。

## NuGet 包

我們目前提供 8 個 NuGet 包，您可以根據需要選擇安裝。

|包名|功能|連結|
|---|---|---|
|dotnetCampus.LatestCSharpFeatures|全功能包，包含所有 C# 新功能|[![NuGet](https://img.shields.io/nuget/v/dotnetCampus.LatestCSharpFeatures.svg)](https://www.nuget.org/packages/dotnetCampus.LatestCSharpFeatures)|
|dotnetCampus.LatestCSharpFeatures.Source|全功能包的源碼版本|[![NuGet](https://img.shields.io/nuget/v/dotnetCampus.LatestCSharpFeatures.Source.svg)](https://www.nuget.org/packages/dotnetCampus.LatestCSharpFeatures.Source)|
|dotnetCampus.IsExternalInit|支援使用 init 語法|[![NuGet](https://img.shields.io/nuget/v/dotnetCampus.IsExternalInit.svg)](https://www.nuget.org/packages/dotnetCampus.IsExternalInit)|
|dotnetCampus.IsExternalInit.Source|支援使用 init 語法的源碼版本|[![NuGet](https://img.shields.io/nuget/v/dotnetCampus.IsExternalInit.Source.svg)](https://www.nuget.org/packages/dotnetCampus.IsExternalInit.Source)|
|dotnetCampus.Nullable|支援使用豐富的可空支援|[![NuGet](https://img.shields.io/nuget/v/dotnetCampus.Nullable.svg)](https://www.nuget.org/packages/dotnetCampus.Nullable)|
|dotnetCampus.Nullable.Source|支援使用豐富的可空支援的源碼版本|[![NuGet](https://img.shields.io/nuget/v/dotnetCampus.Nullable.Source.svg)](https://www.nuget.org/packages/dotnetCampus.Nullable.Source)|
|dotnetCampus.Required|增加了 required 語法的支援*|[![NuGet](https://img.shields.io/nuget/v/dotnetCampus.Required.svg)](https://www.nuget.org/packages/dotnet```markdown
Campus.Required)|
|dotnetCampus.Required.Source|增加了 required 語法支援的源碼版本*|[![NuGet](https://img.shields.io/nuget/v/dotnetCampus.Required.Source.svg)](https://www.nuget.org/packages/dotnetCampus.Required.Source)|

\* 對於 required 語法的介紹，您可以參考這裡的[說明](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/required)【7†source】【9†source】。

## 使用方法

無論是全功能包還是單一功能包，我們都提供了兩種版本。不帶 .Source 後綴的包會生成一個 dll，這樣所有引用了這個項目的項目都能使用到這些新功能。而帶有 .Source 後綴的包則只對安裝此包的項目有效，最終生成的項目中沒有額外的 dll。

如果您希望 .Source 包對其他引用了此項目的項目也生效，可以在 csproj 文件中增加一個條件編譯符：

```xml
<!-- 預設情況下，安裝 .Source 後綴的包會將 C# 新特性以 internal 修飾符引入當前項目。
     使用此條件編譯符，可以將這些類型設為 public，使得引用此項目的其他項目也能使用這些新特性。 -->
<DefineConstants>$(DefineConstants);USE_PUBLIC_LATEST_CSHARP_FEATURES</DefineConstants>
```

## 反饋與貢獻

我們歡迎所有用戶的反饋和貢獻。如果你在使用過程中發現任何問題，或者有任何改進建議，都可以通過 GitHub Issues 提交。

如果你希望參與到項目的開發中，也非常歡迎！你可以 Fork 本倉庫，然後提交 Pull Request。

感謝你對 dotnetCampus.LatestCSharpFeatures 的支援和幫助！
