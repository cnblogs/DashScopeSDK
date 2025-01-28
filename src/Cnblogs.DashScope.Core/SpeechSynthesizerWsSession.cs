using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using Cnblogs.DashScope.Core.Internals;

namespace Cnblogs.DashScope.Core;

/// <summary>
/// Ws session for SpeechSynthesizer
/// </summary>
/// <param name="socket">The underlying socket.</param>
public class SpeechSynthesizerWsSession(ClientWebSocket socket)
{
    /// <summary>
    /// Start the SpeechSynthesizer session.
    /// </summary>
    public async Task StartAsync()
    {
        await socket.ConnectAsync(new Uri(ApiLinks.WsLink), CancellationToken.None);
    }

    /// <summary>
    /// Finish the SpeechSynthesizer session.
    /// </summary>
    public async Task FinishAsync()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    ///     Send message by json.
    /// </summary>
    /// <param name="message"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="T">The </typeparam>
    private async Task SendAsync<T>(T message, CancellationToken cancellationToken = default)
    {
        var json = JsonSerializer.Serialize(message, JsonSerializerOptions.Default);
        await socket.SendAsync(
            new ArraySegment<byte>(Encoding.UTF8.GetBytes(json)),
            WebSocketMessageType.Text,
            true,
            cancellationToken);
    }
}
