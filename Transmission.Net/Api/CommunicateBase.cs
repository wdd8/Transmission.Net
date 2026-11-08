using Newtonsoft.Json;

namespace Transmission.Net.Api;

/// <summary>
/// Base class for request/response
/// </summary>
public abstract class CommunicateBase
{
    /// <summary>
    /// JSON-RPC version
    /// </summary>
    [JsonProperty("jsonrpc")]
    public string JsonRpc = "2.0";

    /// <summary>
    /// Number (id)
    /// </summary>
    [JsonProperty("id")]
    public int? Id;

    /// <summary>
    /// Convert to JSON string
    /// </summary>
    /// <returns></returns>
    public virtual string? ToJson()
    {
        return JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
