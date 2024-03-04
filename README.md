English | [简体中文](https://github.com/cnblogs/dashscope-sdk/blob/main/README.zh-Hans.md)

![NuGet Version](https://img.shields.io/nuget/v/Cnblogs.DashScope.Sdk?style=flat&logo=nuget&label=Cnblogs.DashScope.Sdk)

![NuGet Version](https://img.shields.io/nuget/v/Cnblogs.DashScope.AspNetCore?style=flat&logo=nuget&label=Cnblogs.DashScope.AspNetCore)

# Cnblogs.DashScopeSDK

An unofficial DashScope SDK maintained by Cnblogs.

# Usage

## Console App

Install Cnblogs.DashScope.Sdk package.

```csharp
var client = new DashScopeClient("your-api-key");
var completion = await client.GetQWenCompletionAsync(QWenLlm.QWenMax, prompt);
Console.WriteLine(completion.Output.Text);
```

## ASP.NET Core

Install the Cnblogs.DashScope.AspNetCore package.

`Program.cs`
```csharp
builder.AddDashScopeClient(builder.Configuration);
```

`appsettings.json`
```json
{
    "DashScope": {
        "ApiKey": "your-api-key"
    }
}
```

`Usage`
```csharp
public class YourService(IDashScopeClient client)
{
    public async Task<string> CompletePromptAsync(string prompt)
    {
       var completion = await client.GetQWenCompletionAsync(QWenLlm.QWenMax, prompt);
       return completion.Output.Text;
    }
}
```

# Supported APIs

- Text Embedding API - `dashScopeClient.GetTextEmbeddingsAsync()`
- Text Generation API(qwen-turbo, qwen-max, etc.) - `dashScopeClient.GetQwenCompletionAsync()` and `dashScopeClient.GetQWenCompletionStreamAsync()`
- BaiChuan Models - Use `dashScopeClient.GetBaiChuanTextCompletionAsync()`
- LLaMa2 Models - `dashScopeClient.GetLlama2TextCompletionAsync()`
- Multimodal Generation API(qwen-vl-max, etc.) - `dashScopeClient.GetQWenMultimodalCompletionAsync` and `dashScopeClient.GetQWenMultimodalCompletionStreamAsync`
- Wanx Models(Image generation, background generation, etc)
  - Image Synthesis - `CreateWanxImageSynthesisTaskAsync()` and `GetWanxImageSynthesisTaskAsync()`
  - Image Generation - `CreateWanxImageGenerationTaskAsync` and `GetWanxImageGenerationTaskAsync()`
  - Background Image Generation - `CreateWanxBackgroundGenerationTaskAsync` and `GetWanxBackgroundGenerationTaskAsync`
