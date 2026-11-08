using Transmission.Net.Core.Enums;

namespace Transmission.Net.Core.Entity;

/// <summary>
/// Common torrent attributes used as both for the <c>torrent-set</c>
/// method and from the <c>torrent-get</c> method
/// </summary>
public interface ITorrentData
{
    /// <summary>
    /// This torrent's bandwidth priority
    /// </summary>
    Priority? BandwidthPriority { get; set; }

    /// <summary>
    /// Maximum download speed (KBps)
    /// </summary>
    int? DownloadLimit { get; set; }

    /// <summary>
    /// <see langword="true"/> if downloadLimit is honored
    /// </summary>
    bool? DownloadLimited { get; set; }

    /// <summary>
    /// <see langword="true"/> if session upload limits are honored
    /// </summary>
    bool? HonorsSessionLimits { get; set; }

    /// <summary>
    /// Labels
    /// </summary>
    string[]? Labels { get; set; }

    /// <summary>
    /// Maximum number of peers
    /// </summary>
    int? PeerLimit { get; set; }

    /// <summary>
    /// <see langword="true"/> if the torrent downloads its pieces sequentially
    /// </summary>
    bool? SequentialDownload { get; set; }

    /// <summary>
    /// Queue position
    /// </summary>
    int? QueuePosition { get; set; }

    /// <summary>
    /// Torrent-level number of minutes of seeding inactivity
    /// </summary>
    int? SeedIdleLimit { get; set; }

    /// <summary>
    /// Which seeding inactivity to use. See tr_idlelimit
    /// TODO: Add tr_idlelimit enum
    /// </summary>
    int? SeedIdleMode { get; set; }

    /// <summary>
    /// Torrent-level seeding ratio limit
    /// </summary>
    double? SeedRatioLimit { get; set; }

    /// <summary>
    /// Which ratio to use. See tr_ratiolimit
    /// TODO: Add tr_ratiolimit enum
    /// </summary>
    int? SeedRatioMode { get; set; }

    /// <summary>
    /// A string of announce URLs, one per line, with a blank
    /// line between tiers
    /// </summary>
    string? TrackerList { get; set; }

    /// <summary>
    /// Maximum upload speed (KBps)
    /// </summary>
    int? UploadLimit { get; set; }

    /// <summary>
    /// <see langword="true"/> if <see cref="UploadLimit"/> is honored
    /// </summary>
    bool? UploadLimited { get; set; }
}
