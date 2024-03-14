﻿using Cnblogs.DashScope.Core;
using Json.Schema;

namespace Cnblogs.DashScope.Sdk;

/// <summary>
/// Definition of function that can be called by model.
/// </summary>
public record FunctionDefinition : IFunctionDefinition
{
    /// <summary>
    /// Create a new function definition.
    /// </summary>
    /// <param name="name">The name of the function.</param>
    /// <param name="description">Descriptions about this function for model to reference on.</param>
    /// <param name="parameters">Parameter maps of this function.</param>
    public FunctionDefinition(string name, string description, JsonSchema? parameters)
    {
        Name = name;
        Description = description;
        Parameters = parameters;
    }

    /// <inheritdoc />
    public string Name { get; }

    /// <inheritdoc />
    public string Description { get; }

    /// <inheritdoc />
    public object? Parameters { get; }
}
