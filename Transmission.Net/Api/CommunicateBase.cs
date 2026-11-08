using System.Text.Json;
using System.Text.Json.Serialization;

namespace Transmission.Net.Api;

/// <summary>
/// Base class for request/response
/// </summary>
public abstract class CommunicateBase
{
    /// <summary>
    /// JSON-RPC version
    /// </summary>
    [JsonPropertyName("jsonrpc"), JsonInclude]
    public string JsonRpc = "2.0";

    /// <summary>
    /// Number (id)
    /// </summary>
    [JsonPropertyName("id"), JsonInclude]
    public int? Id;

    /// <summary>
    /// Convert to JSON string
    /// </summary>
    /// <returns></returns>
    public virtual string? ToJson()
    {
        return JsonSerializer.Serialize(this, GetType(), TransmissionJsonContext.Default);
    }
}
