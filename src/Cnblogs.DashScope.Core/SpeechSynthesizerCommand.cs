namespace Cnblogs.DashScope.Core;

/// <summary>
///     Speech synthesizer command.
/// </summary>
/// <typeparam name="T">The payload type.</typeparam>
public record SpeechSynthesizerCommand<T>(SpeechSynthesizerHeader Header, T Payload);
