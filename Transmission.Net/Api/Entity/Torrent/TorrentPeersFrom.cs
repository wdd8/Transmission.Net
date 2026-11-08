using System.Text.Json.Serialization;
using Transmission.Net.Core.Entity.Torrent;

namespace Transmission.Net.Api.Entity.Torrent;

public class TorrentPeersFrom : ITorrentPeersFrom
{
    [JsonPropertyName("from_dht")]
    public int FromDHT { get; set; }

    [JsonPropertyName("from_incoming")]
    public int FromIncoming { get; set; }

    [JsonPropertyName("from_lpd")]
    public int FromLPD { get; set; }

    [JsonPropertyName("from_ltep")]
    public int FromLTEP { get; set; }

    [JsonPropertyName("from_pex")]
    public int FromPEX { get; set; }

    [JsonPropertyName("from_tracker")]
    public int FromTracker { get; set; }
}
