using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Transmission.Net.Api;

/// <summary>
/// Transmission response
/// </summary>
public class TransmissionResponse : CommunicateBase
{
    /// <summary>
    /// Data, on success
    /// </summary>
    [JsonPropertyName("result"), JsonInclude]
    public JsonNode? Result;

    /// <summary>
    /// Error, on failure
    /// </summary>
    [JsonPropertyName("error"), JsonInclude]
    public TransmissionError? Error;

    /// <summary>
    /// Deserialize to class
    /// </summary>
    /// <returns></returns>
    public T? Deserialize<T>(JsonTypeInfo<T> typeInfo)
    {
        return Result == null ? default : Result.Deserialize(typeInfo);
    }
}

/// <summary>
/// Transmission error
/// </summary>
public class TransmissionError
{
    /// <summary>
    /// JSON-RPC error code
    /// </summary>
    [JsonPropertyName("code")]
    public int Code { get; set; }

    /// <summary>
    /// Error message
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// Additional information
    /// </summary>
    [JsonPropertyName("data")]
    public TransmissionErrorData? Data { get; set; }
}

/// <summary>
/// Additional information about a Transmission error
/// </summary>
public class TransmissionErrorData
{
    /// <summary>
    /// Error details not included in <see cref="TransmissionError.Message"/>
    /// </summary>
    [JsonPropertyName("error_string")]
    public string? ErrorString { get; set; }
}
