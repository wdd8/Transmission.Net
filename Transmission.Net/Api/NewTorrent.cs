﻿namespace Transmission.Net.Api;

/// <summary>
/// Information about the torrent file, that will be added
/// </summary>
public class NewTorrent : ArgumentsBase
{
    /// <summary>
    /// Pointer to a string of one or more cookies.
    /// </summary>
    public string? Cookies { get => GetValue<string?>("cookies"); set => this["cookies"] = value; }

    /// <summary>
    /// Path to download the torrent to
    /// </summary>
    public string? DownloadDirectory { get => GetValue<string?>("download-dir"); set => this["download-dir"] = value; }

    /// <summary>
    /// filename (relative to the server) or URL of the .torrent file (Priority than the metadata)
    /// </summary>
    public string? Filename { get => GetValue<string?>("filename"); set => this["filename"] = value; }

    /// <summary>
    /// base64-encoded .torrent content
    /// </summary>
    public string? Metainfo { get => GetValue<string?>("metainfo"); set => this["metainfo"] = value; }

    /// <summary>
    /// if true, don't start the torrent
    /// </summary>
    public bool? Paused { get => GetValue<bool?>("paused"); set => this["paused"] = value; }

    /// <summary>
    /// maximum number of peers
    /// </summary>
    public int? PeerLimit { get => GetValue<int?>("peer-limit"); set => this["peer-limit"] = value; }

    /// <summary>
    /// Torrent's bandwidth priority
    /// </summary>
    public int? BandwidthPriority { get => GetValue<int?>("bandwidthPriority"); set => this["bandwidthPriority"] = value; }

    /// <summary>
    /// Indices of file(s) to download
    /// </summary>
    public int? FilesWanted { get => GetValue<int?>("files-wanted"); set => this["files-wanted"] = value; }

    /// <summary>
    /// Indices of file(s) to download
    /// </summary>
    public int? FilesUnwanted { get => GetValue<int?>("files-unwanted"); set => this["files-unwanted"] = value; }

    /// <summary>
    /// Indices of high-priority file(s)
    /// </summary>
    public int? PriorityHigh { get => GetValue<int?>("priority-high"); set => this["priority-high"] = value; }

    /// <summary>
    /// Indices of low-priority file(s)
    /// </summary>
    public int? PriorityLow { get => GetValue<int?>("priority-low"); set => this["priority-low"] = value; }

    /// <summary>
    /// Indices of normal-priority file(s)
    /// </summary>
    public int? PriorityNormal { get => GetValue<int?>("priority-normal"); set => this["priority-normal"] = value; }
}
