using Newtonsoft.Json;

namespace Transmission.Net.Api.Entity.Session;

/// <summary>
/// Units
/// </summary>
public class Units
{
    /// <summary>
    /// Speed units
    /// </summary>
    [JsonProperty("speed_units")]
    public string[]? SpeedUnits { get; set; }

    /// <summary>
    /// Speed bytes
    /// </summary>
    [JsonProperty("speed_bytes")]
    public int? SpeedBytes { get; set; }

    /// <summary>
    /// Size units
    /// </summary>
    [JsonProperty("size_units")]
    public string[]? SizeUnits { get; set; }

    /// <summary>
    /// Size bytes
    /// </summary>
    [JsonProperty("size_bytes")]
    public int? SizeBytes { get; set; }

    /// <summary>
    /// Memory units
    /// </summary>
    [JsonProperty("memory_units")]
    public string[]? MemoryUnits { get; set; }

    /// <summary>
    /// Memory bytes
    /// </summary>
    [JsonProperty("memory_bytes")]
    public int? MemoryBytes { get; set; }
}
