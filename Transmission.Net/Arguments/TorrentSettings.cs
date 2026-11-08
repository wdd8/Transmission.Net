using Transmission.Net.Api;
using Transmission.Net.Core.Entity;
using Transmission.Net.Core.Enums;

namespace Transmission.Net.Arguments;

/// <summary>
/// Torrent settings
/// </summary>
public class TorrentSettings : ArgumentsBase, ITorrentData
{
    public Priority? BandwidthPriority { get => GetValue<Priority?>("bandwidth_priority"); set => this["bandwidth_priority"] = value; }
    public int? DownloadLimit { get => GetValue<int?>("download_limit"); set => this["download_limit"] = value; }
    public bool? DownloadLimited { get => GetValue<bool?>("download_limited"); set => this["download_limited"] = value; }
    public bool? HonorsSessionLimits { get => GetValue<bool?>("honors_session_limits"); set => this["honors_session_limits"] = value; }
    public int? PeerLimit { get => GetValue<int?>("peer_limit"); set => this["peer_limit"] = value; }

    /// <summary>
    /// Torrent id array, which specifies which torrents to use. All torrents are used if the ids argument is omitted.
    /// </summary>
    public object? IDs { get => GetValue<object?>("ids"); set => this["ids"] = value; }


    /// <summary>
    /// Indices of file(s) to not download
    /// </summary>
    public int[]? FilesUnwanted { get => GetValue<int[]?>("files_unwanted"); set => this["files_unwanted"] = value; }

    /// <summary>
    /// Indices of file(s) to download
    /// </summary>
    public int[]? FilesWanted { get => GetValue<int[]?>("files_wanted"); set => this["files_wanted"] = value; }

    /// <summary>
    /// New location of the torrent's content
    /// </summary>
    public string? Location { get => GetValue<string?>("location"); set => this["location"] = value; }

    /// <summary>
    /// Indices of high-priority file(s)
    /// </summary>
    public int[]? PriorityHigh { get => GetValue<int[]?>("priority_high"); set => this["priority_high"] = value; }

    /// <summary>
    /// Indices of low-priority file(s)
    /// </summary>
    public int[]? PriorityLow { get => GetValue<int[]?>("priority_low"); set => this["priority_low"] = value; }

    /// <summary>
    /// Indices of normal-priority file(s)
    /// </summary>
    public int[]? PriorityNormal { get => GetValue<int[]?>("priority_normal"); set => this["priority_normal"] = value; }
    public int? QueuePosition { get => GetValue<int?>("queue_position"); set => this["queue_position"] = value; }
    public int? SeedIdleLimit { get => GetValue<int?>("seed_idle_limit"); set => this["seed_idle_limit"] = value; }
    public int? SeedIdleMode { get => GetValue<int?>("seed_idle_mode"); set => this["seed_idle_mode"] = value; }
    public double? SeedRatioLimit { get => GetValue<double?>("seed_ratio_limit"); set => this["seed_ratio_limit"] = value; }
    public int? SeedRatioMode { get => GetValue<int?>("seed_ratio_mode"); set => this["seed_ratio_mode"] = value; }
    public bool? SequentialDownload { get => GetValue<bool?>("sequential_download"); set => this["sequential_download"] = value; }
    public int? UploadLimit { get => GetValue<int?>("upload_limit"); set => this["upload_limit"] = value; }
    public bool? UploadLimited { get => GetValue<bool?>("upload_limited"); set => this["upload_limited"] = value; }

    /// <summary>
    /// Strings of announce URLs to add
    /// </summary>
    [Obsolete("TrackerAdd is obsolete since Transmission 4.0.0, use TrackerList instead.")]
    public string? TrackerAdd { get => GetValue<string?>("tracker_add"); set => this["tracker_add"] = value; }

    /// <summary>
    /// Ids of trackers to remove
    /// </summary>
    [Obsolete("TrackerRemove is obsolete since Transmission 4.0.0, use TrackerList instead.")]
    public int[]? TrackerRemove { get => GetValue<int[]?>("tracker_remove"); set => this["tracker_remove"] = value; }

    //TODO: Add and test
    //"tracker_replace"     | array      pairs of <trackerId/new announce URLs>
    //public [] trackerReplace;

    public string? TrackerList { get => GetValue<string?>("tracker_list"); set => this["tracker_list"] = value; }
    public string[]? Labels { get => GetValue<string[]?>("labels"); set => this["labels"] = value; }
}
