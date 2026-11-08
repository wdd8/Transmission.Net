using System.Text.Json.Serialization;
using Transmission.Net.Core.Entity.Torrent;

namespace Transmission.Net.Api.Entity.Torrent;

public class TorrentFile : ITorrentFile
{
    [JsonPropertyName("bytes_completed")]
    public long? BytesCompleted { get; set; }

    [JsonPropertyName("length")]
    public long? Length { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("begin_piece")]
    public long? BeginPiece { get; set; }

    [JsonPropertyName("end_piece")]
    public long? EndPiece { get; set; }
}
