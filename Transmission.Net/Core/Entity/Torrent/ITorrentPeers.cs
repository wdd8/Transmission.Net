namespace Transmission.Net.Core.Entity.Torrent;

public interface ITorrentPeers
{
    /// <summary>
    /// Address
    /// </summary>
    string? Address { get; set; }

    /// <summary>
    /// Client name
    /// </summary>
    string? ClientName { get; set; }

    /// <summary>
    /// Client is choked
    /// </summary>
    bool? ClientIsChoked { get; set; }

    /// <summary>
    /// Client is interested
    /// </summary>
    bool? ClientIsInterested { get; set; }

    /// <summary>
    /// Flag string
    /// </summary>
    string? FlagStr { get; set; }

    /// <summary>
    /// Is downloading from
    /// </summary>
    bool? IsDownloadingFrom { get; set; }

    /// <summary>
    /// Is encrypted
    /// </summary>
    bool? IsEncrypted { get; set; }

    /// <summary>
    /// Is uploading to
    /// </summary>
    bool? IsUploadingTo { get; set; }

    /// <summary>
    /// Is UTP
    /// </summary>
    bool? IsUTP { get; set; }

    /// <summary>
    /// Peer is choked
    /// </summary>
    bool? PeerIsChoked { get; set; }

    /// <summary>
    /// Peer is interested
    /// </summary>
    bool? PeerIsInterested { get; set; }

    /// <summary>
    /// Port
    /// </summary>
    int? Port { get; set; }

    /// <summary>
    /// Progress
    /// </summary>
    double? Progress { get; set; }

    /// <summary>
    /// Rate to client
    /// </summary>
    int? RateToClient { get; set; }

    /// <summary>
    /// Rate to peer
    /// </summary>
    int? RateToPeer { get; set; }

    /// <summary>
    /// Bytes received from the peer (Transmission 4.1.0+)
    /// </summary>
    long? BytesToClient { get; set; }

    /// <summary>
    /// Bytes sent to the peer (Transmission 4.1.0+)
    /// </summary>
    long? BytesToPeer { get; set; }
}
