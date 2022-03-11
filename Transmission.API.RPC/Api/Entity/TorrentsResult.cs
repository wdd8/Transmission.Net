using Newtonsoft.Json;

namespace Transmission.API.RPC.Api.Entity;

/// <summary>
/// Contains arrays of torrents and removed torrents
/// </summary>
public class TorrentsResult
{
    /// <summary>
    /// Array of torrents
    /// </summary>
    [JsonProperty("torrents")]
    public TorrentView[] Torrents { get; set; }

    /// <summary>
    /// Array of torrent-id numbers of recently-removed torrents
    /// </summary>
    [JsonProperty("removed")]
    public TorrentView[] Removed { get; set; }
}
