using Newtonsoft.Json;

namespace Transmission.Net.Core.Entity.Torrent;

/// <summary>
/// Torrent peers from
/// </summary>
public interface ITorrentPeersFrom
{
    /// <summary>
    /// From DHT
    /// </summary>
    [JsonProperty("from_dht")]
    int FromDHT { get; set; }

    /// <summary>
    /// From incoming
    /// </summary>
    [JsonProperty("from_incoming")]
    int FromIncoming { get; set; }

    /// <summary>
    /// From LPD
    /// </summary>
    [JsonProperty("from_lpd")]
    int FromLPD { get; set; }

    /// <summary>
    /// From LTEP
    /// </summary>
    [JsonProperty("from_ltep")]
    int FromLTEP { get; set; }

    /// <summary>
    /// From PEX
    /// </summary>
    [JsonProperty("from_pex")]
    int FromPEX { get; set; }

    /// <summary>
    /// From tracker
    /// </summary>
    [JsonProperty("from_tracker")]
    int FromTracker { get; set; }
}
