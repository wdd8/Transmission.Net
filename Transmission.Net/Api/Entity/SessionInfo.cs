using System.Text.Json.Serialization;
using Transmission.Net.Api.Entity.Session;

namespace Transmission.Net.Api.Entity;

/// <summary>
/// Session information
/// </summary>
public class SessionInfo
{
    /// <summary>
    /// Max global download speed (KBps)
    /// </summary>
    [JsonPropertyName("alt_speed_down")]
    public int? AlternativeSpeedDown { get; set; }

    /// <summary>
    /// True means use the alt speeds
    /// </summary>
    [JsonPropertyName("alt_speed_enabled")]
    public bool? AlternativeSpeedEnabled { get; set; }

    /// <summary>
    /// When to turn on alt speeds (units: minutes after midnight)
    /// </summary>
    [JsonPropertyName("alt_speed_time_begin")]
    public int? AlternativeSpeedTimeBegin { get; set; }

    /// <summary>
    /// True means the scheduled on/off times are used
    /// </summary>
    [JsonPropertyName("alt_speed_time_enabled")]
    public bool? AlternativeSpeedTimeEnabled { get; set; }

    /// <summary>
    /// When to turn off alt speeds
    /// </summary>
    [JsonPropertyName("alt_speed_time_end")]
    public int? AlternativeSpeedTimeEnd { get; set; }

    /// <summary>
    /// What day(s) to turn on alt speeds
    /// </summary>
    [JsonPropertyName("alt_speed_time_day")]
    public int? AlternativeSpeedTimeDay { get; set; }

    /// <summary>
    /// Max global upload speed (KBps)
    /// </summary>
    [JsonPropertyName("alt_speed_up")]
    public int? AlternativeSpeedUp { get; set; }

    /// <summary>
    /// Location of the blocklist to use for "blocklist_update"
    /// </summary>
    [JsonPropertyName("blocklist_url")]
    public string? BlocklistURL { get; set; }

    /// <summary>
    /// True means enabled
    /// </summary>
    [JsonPropertyName("blocklist_enabled")]
    public bool? BlocklistEnabled { get; set; }

    /// <summary>
    /// Maximum size of the disk cache (MB)
    /// </summary>
    [JsonPropertyName("cache_size_mib")]
    public int? CacheSizeMB { get; set; }

    /// <summary>
    /// Default path to download torrents
    /// </summary>
    [JsonPropertyName("download_dir")]
    public string? DownloadDirectory { get; set; }

    /// <summary>
    /// Free space in download dir
    /// </summary>
    [JsonPropertyName("download_dir_free_space")]
    [Obsolete("Obsolete since Transmission 4.0.0. Use the free_space method instead.")]
    public long? DownloadDirectoryFreeSpace { get; set; }

    /// <summary>
    /// Max number of torrents to download at once (see download_queue_enabled)
    /// </summary>
    [JsonPropertyName("download_queue_size")]
    public int? DownloadQueueSize { get; set; }

    /// <summary>
    /// If true, limit how many torrents can be downloaded at once
    /// </summary>
    [JsonPropertyName("download_queue_enabled")]
    public bool? DownloadQueueEnabled { get; set; }

    /// <summary>
    /// True means allow dht in public torrents
    /// </summary>
    [JsonPropertyName("dht_enabled")]
    public bool? DHTEnabled { get; set; }

    /// <summary>
    /// "required", "preferred", "allowed"
    /// </summary>
    [JsonPropertyName("encryption")]
    public string? Encryption { get; set; }

    /// <summary>
    /// Torrents we're seeding will be stopped if they're idle for this long
    /// </summary>
    [JsonPropertyName("idle_seeding_limit")]
    public int? IdleSeedingLimit { get; set; }

    /// <summary>
    /// True if the seeding inactivity limit is honored by default
    /// </summary>
    [JsonPropertyName("idle_seeding_limit_enabled")]
    public bool? IdleSeedingLimitEnabled { get; set; }

    /// <summary>
    /// Path for incomplete torrents, when enabled
    /// </summary>
    [JsonPropertyName("incomplete_dir")]
    public string? IncompleteDirectory { get; set; }

    /// <summary>
    /// True means keep torrents in incomplete_dir until done
    /// </summary>
    [JsonPropertyName("incomplete_dir_enabled")]
    public bool? IncompleteDirectoryEnabled { get; set; }

    /// <summary>
    /// True means allow Local Peer Discovery in public torrents
    /// </summary>
    [JsonPropertyName("lpd_enabled")]
    public bool? LPDEnabled { get; set; }

    /// <summary>
    /// Maximum global number of peers
    /// </summary>
    [JsonPropertyName("peer_limit_global")]
    public int? PeerLimitGlobal { get; set; }

    /// <summary>
    /// Maximum global number of peers
    /// </summary>
    [JsonPropertyName("peer_limit_per_torrent")]
    public int? PeerLimitPerTorrent { get; set; }

    /// <summary>
    /// True means allow pex in public torrents
    /// </summary>
    [JsonPropertyName("pex_enabled")]
    public bool? PexEnabled { get; set; }

    /// <summary>
    /// Port number
    /// </summary>
    [JsonPropertyName("peer_port")]
    public int? PeerPort { get; set; }

    /// <summary>
    /// True means pick a random peer port on launch
    /// </summary>
    [JsonPropertyName("peer_port_random_on_start")]
    public bool? PeerPortRandomOnStart { get; set; }

    /// <summary>
    /// true means enabled
    /// </summary>
    [JsonPropertyName("port_forwarding_enabled")]
    public bool? PortForwardingEnabled { get; set; }

    /// <summary>
    /// Whether or not to consider idle torrents as stalled
    /// </summary>
    [JsonPropertyName("queue_stalled_enabled")]
    public bool? QueueStalledEnabled { get; set; }

    /// <summary>
    /// Torrents that are idle for N minuets aren't counted toward seed_queue_size or download_queue_size
    /// </summary>
    [JsonPropertyName("queue_stalled_minutes")]
    public int? QueueStalledMinutes { get; set; }

    /// <summary>
    /// True means append ".part" to incomplete files
    /// </summary>
    [JsonPropertyName("rename_partial_files")]
    public bool? RenamePartialFiles { get; set; }

    /// <summary>
    /// Session ID
    /// </summary>
    [JsonPropertyName("session_id")]
    public string? SessionID { get; set; }

    /// <summary>
    /// Filename of the script to run
    /// </summary>
    [JsonPropertyName("script_torrent_done_filename")]
    public string? ScriptTorrentDoneFilename { get; set; }

    /// <summary>
    /// Whether or not to call the "done" script
    /// </summary>
    [JsonPropertyName("script_torrent_done_enabled")]
    public bool? ScriptTorrentDoneEnabled { get; set; }

    /// <summary>
    /// The default seed ratio for torrents to use
    /// </summary>
    [JsonPropertyName("seed_ratio_limit")]
    public double? SeedRatioLimit { get; set; }

    /// <summary>
    /// True if seed_ratio_limit is honored by default
    /// </summary>
    [JsonPropertyName("seed_ratio_limited")]
    public bool? SeedRatioLimited { get; set; }

    /// <summary>
    /// Max number of torrents to uploaded at once (see seed_queue_enabled)
    /// </summary>
    [JsonPropertyName("seed_queue_size")]
    public int? SeedQueueSize { get; set; }

    /// <summary>
    /// If true, limit how many torrents can be uploaded at once
    /// </summary>
    [JsonPropertyName("seed_queue_enabled")]
    public bool? SeedQueueEnabled { get; set; }

    /// <summary>
    /// Max global download speed (KBps)
    /// </summary>
    [JsonPropertyName("speed_limit_down")]
    public double? SpeedLimitDown { get; set; }

    /// <summary>
    /// True means enabled
    /// </summary>
    [JsonPropertyName("speed_limit_down_enabled")]
    public bool? SpeedLimitDownEnabled { get; set; }

    /// <summary>
    ///  max global upload speed (KBps)
    /// </summary>
    [JsonPropertyName("speed_limit_up")]
    public double? SpeedLimitUp { get; set; }

    /// <summary>
    /// True means enabled
    /// </summary>
    [JsonPropertyName("speed_limit_up_enabled")]
    public bool? SpeedLimitUpEnabled { get; set; }

    /// <summary>
    /// True means added torrents will be started right away
    /// </summary>
    [JsonPropertyName("start_added_torrents")]
    public bool? StartAddedTorrents { get; set; }

    /// <summary>
    /// True means the .torrent file of added torrents will be deleted
    /// </summary>
    [JsonPropertyName("trash_original_torrent_files")]
    public bool? TrashOriginalTorrentFiles { get; set; }

    /// <summary>
    /// Units
    /// </summary>
    [JsonPropertyName("units")]
    public Units? Units { get; set; }

    /// <summary>
    /// True means allow utp
    /// </summary>
    [JsonPropertyName("utp_enabled")]
    public bool? UtpEnabled { get; set; }

    /// <summary>
    /// Number of rules in the blocklist
    /// </summary>
    [JsonPropertyName("blocklist_size")]
    public int? BlocklistSize { get; set; }

    /// <summary>
    /// Location of transmission's configuration directory
    /// </summary>
    [JsonPropertyName("config_dir")]
    public string? ConfigDirectory { get; set; }

    /// <summary>
    /// The current RPC API version
    /// </summary>
    [JsonPropertyName("rpc_version")]
    public int? RpcVersion { get; set; }

    /// <summary>
    /// The minimum RPC API version supported
    /// </summary>
    [JsonPropertyName("rpc_version_minimum")]
    public int? RpcVersionMinimum { get; set; }

    /// <summary>
    /// Long version string "$version ($revision)"
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}
