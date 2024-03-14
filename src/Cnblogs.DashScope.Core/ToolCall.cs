﻿namespace Cnblogs.DashScope.Core;

/// <summary>
/// Represents a call to tool.
/// </summary>
/// <param name="Id">Id of this tool call.</param>
/// <param name="Type">Type of the tool.</param>
/// <param name="Function">Not null if type is function.</param>
public record ToolCall(string? Id, string Type, FunctionCall? Function);
