namespace Cnblogs.DashScope.Core;

/// <summary>
/// An empty object for speech synthesizer api json serialization.
/// </summary>
public record SpeechSynthesizerEmptyInput()
{
    /// <summary>
    /// An static instance represents for empty object.
    /// </summary>
    public static readonly SpeechSynthesizerEmptyInput Instance = new();
}
