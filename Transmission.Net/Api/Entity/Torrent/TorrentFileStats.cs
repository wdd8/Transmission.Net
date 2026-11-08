using System.Text.Json.Serialization;
using Transmission.Net.Core.Entity.Torrent;
using Transmission.Net.Core.Enums;

namespace Transmission.Net.Api.Entity.Torrent;

public class TorrentFileStats : ITorrentFileStats
{
    [JsonPropertyName("bytes_completed")]
    public double BytesCompleted { get; set; }

    [JsonPropertyName("wanted")]
    public bool Wanted { get; set; }

    [JsonPropertyName("priority")]
    public Priority Priority { get; set; }
}
