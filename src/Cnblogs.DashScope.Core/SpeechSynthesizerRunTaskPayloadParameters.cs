namespace Cnblogs.DashScope.Core;

public record SpeechSynthesizerRunTaskPayloadParameters(
    string TextType,
    string Voice,
    string Format,
    int SampleRate,
    int? Volume = null,
    float? Rate = null,
    float? Pitch = null);
