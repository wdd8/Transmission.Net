namespace Transmission.Net.Core.Entity.Torrent;

/// <summary>
/// Torrent peers from
/// </summary>
public interface ITorrentPeersFrom
{
    /// <summary>
    /// From DHT
    /// </summary>
    int FromDHT { get; set; }

    /// <summary>
    /// From incoming
    /// </summary>
    int FromIncoming { get; set; }

    /// <summary>
    /// From LPD
    /// </summary>
    int FromLPD { get; set; }

    /// <summary>
    /// From LTEP
    /// </summary>
    int FromLTEP { get; set; }

    /// <summary>
    /// From PEX
    /// </summary>
    int FromPEX { get; set; }

    /// <summary>
    /// From tracker
    /// </summary>
    int FromTracker { get; set; }
}
