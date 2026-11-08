namespace Transmission.Net.Core.Entity;

/// <summary>
/// Torrent trackers
/// </summary>
public interface ITorrentTracker
{
    /// <summary>
    /// Full announce URL
    /// </summary>
    string Announce { get; set; }

    /// <summary>
    /// Full scrape URL
    /// </summary>
    string Scrape { get; set; }

    /// <summary>
    /// Unique transmission-generated ID for use in libtransmission API
    /// </summary>
    int Id { get; set; }

    /// <summary>
    /// Which tier this tracker is in
    /// </summary>
    int Tier { get; set; }
}
