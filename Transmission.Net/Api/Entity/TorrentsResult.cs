using System.Text.Json.Serialization;

namespace Transmission.Net.Api.Entity;

/// <summary>
/// Contains arrays of torrents and removed torrents
/// </summary>
public class TorrentsResult
{
    public TorrentsResult(TorrentView[] torrents)
    {
        Torrents = torrents;
    }

    /// <summary>
    /// Array of torrents
    /// </summary>
    [JsonPropertyName("torrents")]
    public TorrentView[] Torrents { get; set; }

    /// <summary>
    /// Array of torrent-id numbers of recently-removed torrents
    /// </summary>
    [JsonPropertyName("removed")]
    public int[]? Removed { get; set; }

    public static implicit operator TorrentView[](TorrentsResult torrentsResult) { return torrentsResult.Torrents; }
}
