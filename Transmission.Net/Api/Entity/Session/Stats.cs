using Newtonsoft.Json;

namespace Transmission.Net.Api.Entity.Session;

/// <summary>
/// Statistic
/// </summary>
public class Stats
{
    /// <summary>
    /// Active torrent count
    /// </summary>
    [JsonProperty("active_torrent_count")]
    public int? ActiveTorrentCount { get; set; }

    /// <summary>
    /// Download speed
    /// </summary>
    [JsonProperty("download_speed")]
    public int? DownloadSpeed { get; set; }

    /// <summary>
    /// Paused torrent count
    /// </summary>
    [JsonProperty("paused_torrent_count")]
    public int? PausedTorrentCount { get; set; }

    /// <summary>
    /// Torrent count
    /// </summary>
    [JsonProperty("torrent_count")]
    public int? TorrentCount { get; set; }

    /// <summary>
    /// Upload speed
    /// </summary>
    [JsonProperty("upload_speed")]
    public int? UploadSpeed { get; set; }

    /// <summary>
    /// Cumulative stats
    /// </summary>
    [JsonProperty("cumulative_stats")]
    public CommonStats? CumulativeStats { get; set; }

    /// <summary>
    /// Current stats
    /// </summary>
    [JsonProperty("current_stats")]
    public CommonStats? CurrentStats { get; set; }
}

/// <summary>
/// Common statistic
/// </summary>
public class CommonStats
{
    /// <summary>
    /// Uploaded bytes
    /// </summary>
    [JsonProperty("uploaded_bytes")]
    public double? UploadedBytes { get; set; }

    /// <summary>
    /// Downloaded bytes
    /// </summary>
    [JsonProperty("downloaded_bytes")]
    public double? DownloadedBytes { get; set; }

    /// <summary>
    /// Files added
    /// </summary>
    [JsonProperty("files_added")]
    public int? FilesAdded { get; set; }

    /// <summary>
    /// Session count
    /// </summary>
    [JsonProperty("session_count")]
    public int? SessionCount { get; set; }

    /// <summary>
    /// Seconds active
    /// </summary>
    [JsonProperty("seconds_active")]
    public int? SecondsActive { get; set; }
}
