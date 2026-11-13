using System.Text.Json.Serialization;
using Transmission.Net.Core.Entity.Torrent;

namespace Transmission.Net.Api.Entity.Torrent;

public class TorrentPeers : ITorrentPeers
{
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    [JsonPropertyName("client_name")]
    public string? ClientName { get; set; }

    [JsonPropertyName("client_is_choked")]
    public bool? ClientIsChoked { get; set; }

    [JsonPropertyName("client_is_interested")]
    public bool? ClientIsInterested { get; set; }

    [JsonPropertyName("flag_str")]
    public string? FlagStr { get; set; }

    [JsonPropertyName("is_downloading_from")]
    public bool? IsDownloadingFrom { get; set; }

    [JsonPropertyName("is_encrypted")]
    public bool? IsEncrypted { get; set; }

    [JsonPropertyName("is_uploading_to")]
    public bool? IsUploadingTo { get; set; }

    [JsonPropertyName("is_utp")]
    public bool? IsUTP { get; set; }

    [JsonPropertyName("peer_is_choked")]
    public bool? PeerIsChoked { get; set; }

    [JsonPropertyName("peer_is_interested")]
    public bool? PeerIsInterested { get; set; }

    [JsonPropertyName("port")]
    public int? Port { get; set; }

    [JsonPropertyName("progress")]
    public double? Progress { get; set; }

    [JsonPropertyName("rate_to_client")]
    public int? RateToClient { get; set; }

    [JsonPropertyName("rate_to_peer")]
    public int? RateToPeer { get; set; }

    [JsonPropertyName("bytes_to_client")]
    public long? BytesToClient { get; set; }

    [JsonPropertyName("bytes_to_peer")]
    public long? BytesToPeer { get; set; }
}
