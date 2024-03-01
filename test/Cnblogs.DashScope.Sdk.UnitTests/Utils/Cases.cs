﻿namespace Cnblogs.DashScope.Sdk.UnitTests.Utils;

internal class Cases
{
    public const string CustomModelName = "custom-model";
    public const string Prompt = "hello";
    public const string PromptAlter = "world";
    public const string Uuid = "33da8e6b-1309-9a44-be83-352165959608";

    public static readonly List<ChatMessage> TextMessages =
        [new("system", "you are a helpful assistant"), new("user", "hello")];
}
