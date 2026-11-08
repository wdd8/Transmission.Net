using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Transmission.Net.Api;

/// <summary>
/// Transmission response
/// </summary>
public class TransmissionResponse : CommunicateBase
{
    /// <summary>
    /// Data, on success
    /// </summary>
    [JsonProperty("result")]
    public JToken? Result;

    /// <summary>
    /// Error, on failure
    /// </summary>
    [JsonProperty("error")]
    public TransmissionError? Error;

    /// <summary>
    /// Deserialize to class
    /// </summary>
    /// <returns></returns>
    public T? Deserialize<T>()
    {
        return Result == null ? default : Result.ToObject<T>();
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
    [JsonProperty("code")]
    public int Code { get; set; }

    /// <summary>
    /// Error message
    /// </summary>
    [JsonProperty("message")]
    public string? Message { get; set; }

    /// <summary>
    /// Additional information
    /// </summary>
    [JsonProperty("data")]
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
    [JsonProperty("error_string")]
    public string? ErrorString { get; set; }
}
