using Newtonsoft.Json;

namespace Transmission.Net.Core.Entity.Torrent;

public interface ITorrentPeers
{
    /// <summary>
    /// Address
    /// </summary>
    [JsonProperty("address")]
    string? Address { get; set; }

    /// <summary>
    /// Client name
    /// </summary>
    [JsonProperty("client_name")]
    string? ClientName { get; set; }

    /// <summary>
    /// Client is choked
    /// </summary>
    [JsonProperty("client_is_choked")]
    bool? ClientIsChoked { get; set; }

    /// <summary>
    /// Client is interested
    /// </summary>
    [JsonProperty("client_is_interested")]
    bool? ClientIsInterested { get; set; }

    /// <summary>
    /// Flag string
    /// </summary>
    [JsonProperty("flag_str")]
    string? FlagStr { get; set; }

    /// <summary>
    /// Is downloading from
    /// </summary>
    [JsonProperty("is_downloading_from")]
    bool? IsDownloadingFrom { get; set; }

    /// <summary>
    /// Is encrypted
    /// </summary>
    [JsonProperty("is_encrypted")]
    bool? IsEncrypted { get; set; }

    /// <summary>
    /// Is uploading to
    /// </summary>
    [JsonProperty("is_uploading_to")]
    bool? IsUploadingTo { get; set; }

    /// <summary>
    /// Is UTP
    /// </summary>
    [JsonProperty("is_utp")]
    bool? IsUTP { get; set; }

    /// <summary>
    /// Peer is choked
    /// </summary>
    [JsonProperty("peer_is_choked")]
    bool? PeerIsChoked { get; set; }

    /// <summary>
    /// Peer is interested
    /// </summary>
    [JsonProperty("peer_is_interested")]
    bool? PeerIsInterested { get; set; }

    /// <summary>
    /// Port
    /// </summary>
    [JsonProperty("port")]
    int? Port { get; set; }

    /// <summary>
    /// Progress
    /// </summary>
    [JsonProperty("progress")]
    double? Progress { get; set; }

    /// <summary>
    /// Rate to client
    /// </summary>
    [JsonProperty("rate_to_client")]
    int? RateToClient { get; set; }

    /// <summary>
    /// Rate to peer
    /// </summary>
    [JsonProperty("rate_to_peer")]
    int? RateToPeer { get; set; }
}
