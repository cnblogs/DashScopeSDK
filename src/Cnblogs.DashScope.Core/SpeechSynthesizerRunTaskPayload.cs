namespace Cnblogs.DashScope.Core;

/// <summary>
/// Payloads of speech synthesizer run task command.
/// </summary>
/// <param name="TaskGroup">Group of the task.</param>
/// <param name="Task">Name of the task.</param>
/// <param name="Function">Function name.</param>
/// <param name="Model">Model name.</param>
/// <param name="Parameters">Parameters when calling the function.</param>
/// <param name="Input">Inputs of the function.</param>
public record SpeechSynthesizerRunTaskPayload(
    string TaskGroup,
    string Task,
    string Function,
    string Model,
    SpeechSynthesizerRunTaskPayloadParameters Parameters,
    SpeechSynthesizerEmptyInput Input);
