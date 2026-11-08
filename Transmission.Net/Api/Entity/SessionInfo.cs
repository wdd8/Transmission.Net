using Newtonsoft.Json;
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
    [JsonProperty("alt_speed_down")]
    public int? AlternativeSpeedDown { get; set; }

    /// <summary>
    /// True means use the alt speeds
    /// </summary>
    [JsonProperty("alt_speed_enabled")]
    public bool? AlternativeSpeedEnabled { get; set; }

    /// <summary>
    /// When to turn on alt speeds (units: minutes after midnight)
    /// </summary>
    [JsonProperty("alt_speed_time_begin")]
    public int? AlternativeSpeedTimeBegin { get; set; }

    /// <summary>
    /// True means the scheduled on/off times are used
    /// </summary>
    [JsonProperty("alt_speed_time_enabled")]
    public bool? AlternativeSpeedTimeEnabled { get; set; }

    /// <summary>
    /// When to turn off alt speeds
    /// </summary>
    [JsonProperty("alt_speed_time_end")]
    public int? AlternativeSpeedTimeEnd { get; set; }

    /// <summary>
    /// What day(s) to turn on alt speeds
    /// </summary>
    [JsonProperty("alt_speed_time_day")]
    public int? AlternativeSpeedTimeDay { get; set; }

    /// <summary>
    /// Max global upload speed (KBps)
    /// </summary>
    [JsonProperty("alt_speed_up")]
    public int? AlternativeSpeedUp { get; set; }

    /// <summary>
    /// Location of the blocklist to use for "blocklist_update"
    /// </summary>
    [JsonProperty("blocklist_url")]
    public string? BlocklistURL { get; set; }

    /// <summary>
    /// True means enabled
    /// </summary>
    [JsonProperty("blocklist_enabled")]
    public bool? BlocklistEnabled { get; set; }

    /// <summary>
    /// Maximum size of the disk cache (MB)
    /// </summary>
    [JsonProperty("cache_size_mib")]
    public int? CacheSizeMB { get; set; }

    /// <summary>
    /// Default path to download torrents
    /// </summary>
    [JsonProperty("download_dir")]
    public string? DownloadDirectory { get; set; }

    /// <summary>
    /// Free space in download dir
    /// </summary>
    [JsonProperty("download_dir_free_space")]
    [Obsolete("Obsolete since Transmission 4.0.0. Use the free_space method instead.")]
    public string? DownloadDirectoryFreeSpace { get; set; }

    /// <summary>
    /// Max number of torrents to download at once (see download_queue_enabled)
    /// </summary>
    [JsonProperty("download_queue_size")]
    public int? DownloadQueueSize { get; set; }

    /// <summary>
    /// If true, limit how many torrents can be downloaded at once
    /// </summary>
    [JsonProperty("download_queue_enabled")]
    public bool? DownloadQueueEnabled { get; set; }

    /// <summary>
    /// True means allow dht in public torrents
    /// </summary>
    [JsonProperty("dht_enabled")]
    public bool? DHTEnabled { get; set; }

    /// <summary>
    /// "required", "preferred", "allowed"
    /// </summary>
    [JsonProperty("encryption")]
    public string? Encryption { get; set; }

    /// <summary>
    /// Torrents we're seeding will be stopped if they're idle for this long
    /// </summary>
    [JsonProperty("idle_seeding_limit")]
    public int? IdleSeedingLimit { get; set; }

    /// <summary>
    /// True if the seeding inactivity limit is honored by default
    /// </summary>
    [JsonProperty("idle_seeding_limit_enabled")]
    public bool? IdleSeedingLimitEnabled { get; set; }

    /// <summary>
    /// Path for incomplete torrents, when enabled
    /// </summary>
    [JsonProperty("incomplete_dir")]
    public string? IncompleteDirectory { get; set; }

    /// <summary>
    /// True means keep torrents in incomplete_dir until done
    /// </summary>
    [JsonProperty("incomplete_dir_enabled")]
    public bool? IncompleteDirectoryEnabled { get; set; }

    /// <summary>
    /// True means allow Local Peer Discovery in public torrents
    /// </summary>
    [JsonProperty("lpd_enabled")]
    public bool? LPDEnabled { get; set; }

    /// <summary>
    /// Maximum global number of peers
    /// </summary>
    [JsonProperty("peer_limit_global")]
    public int? PeerLimitGlobal { get; set; }

    /// <summary>
    /// Maximum global number of peers
    /// </summary>
    [JsonProperty("peer_limit_per_torrent")]
    public int? PeerLimitPerTorrent { get; set; }

    /// <summary>
    /// True means allow pex in public torrents
    /// </summary>
    [JsonProperty("pex_enabled")]
    public bool? PexEnabled { get; set; }

    /// <summary>
    /// Port number
    /// </summary>
    [JsonProperty("peer_port")]
    public int? PeerPort { get; set; }

    /// <summary>
    /// True means pick a random peer port on launch
    /// </summary>
    [JsonProperty("peer_port_random_on_start")]
    public bool? PeerPortRandomOnStart { get; set; }

    /// <summary>
    /// true means enabled
    /// </summary>
    [JsonProperty("port_forwarding_enabled")]
    public bool? PortForwardingEnabled { get; set; }

    /// <summary>
    /// Whether or not to consider idle torrents as stalled
    /// </summary>
    [JsonProperty("queue_stalled_enabled")]
    public bool? QueueStalledEnabled { get; set; }

    /// <summary>
    /// Torrents that are idle for N minuets aren't counted toward seed_queue_size or download_queue_size
    /// </summary>
    [JsonProperty("queue_stalled_minutes")]
    public int? QueueStalledMinutes { get; set; }

    /// <summary>
    /// True means append ".part" to incomplete files
    /// </summary>
    [JsonProperty("rename_partial_files")]
    public bool? RenamePartialFiles { get; set; }

    /// <summary>
    /// Session ID
    /// </summary>
    [JsonProperty("session_id")]
    public string? SessionID { get; set; }

    /// <summary>
    /// Filename of the script to run
    /// </summary>
    [JsonProperty("script_torrent_done_filename")]
    public string? ScriptTorrentDoneFilename { get; set; }

    /// <summary>
    /// Whether or not to call the "done" script
    /// </summary>
    [JsonProperty("script_torrent_done_enabled")]
    public bool? ScriptTorrentDoneEnabled { get; set; }

    /// <summary>
    /// The default seed ratio for torrents to use
    /// </summary>
    [JsonProperty("seed_ratio_limit")]
    public double? SeedRatioLimit { get; set; }

    /// <summary>
    /// True if seed_ratio_limit is honored by default
    /// </summary>
    [JsonProperty("seed_ratio_limited")]
    public bool? SeedRatioLimited { get; set; }

    /// <summary>
    /// Max number of torrents to uploaded at once (see seed_queue_enabled)
    /// </summary>
    [JsonProperty("seed_queue_size")]
    public int? SeedQueueSize { get; set; }

    /// <summary>
    /// If true, limit how many torrents can be uploaded at once
    /// </summary>
    [JsonProperty("seed_queue_enabled")]
    public bool? SeedQueueEnabled { get; set; }

    /// <summary>
    /// Max global download speed (KBps)
    /// </summary>
    [JsonProperty("speed_limit_down")]
    public double? SpeedLimitDown { get; set; }

    /// <summary>
    /// True means enabled
    /// </summary>
    [JsonProperty("speed_limit_down_enabled")]
    public bool? SpeedLimitDownEnabled { get; set; }

    /// <summary>
    ///  max global upload speed (KBps)
    /// </summary>
    [JsonProperty("speed_limit_up")]
    public double? SpeedLimitUp { get; set; }

    /// <summary>
    /// True means enabled
    /// </summary>
    [JsonProperty("speed_limit_up_enabled")]
    public bool? SpeedLimitUpEnabled { get; set; }

    /// <summary>
    /// True means added torrents will be started right away
    /// </summary>
    [JsonProperty("start_added_torrents")]
    public bool? StartAddedTorrents { get; set; }

    /// <summary>
    /// True means the .torrent file of added torrents will be deleted
    /// </summary>
    [JsonProperty("trash_original_torrent_files")]
    public bool? TrashOriginalTorrentFiles { get; set; }

    /// <summary>
    /// Units
    /// </summary>
    [JsonProperty("units")]
    public Units? Units { get; set; }

    /// <summary>
    /// True means allow utp
    /// </summary>
    [JsonProperty("utp_enabled")]
    public bool? UtpEnabled { get; set; }

    /// <summary>
    /// Number of rules in the blocklist
    /// </summary>
    [JsonProperty("blocklist_size")]
    public int? BlocklistSize { get; set; }

    /// <summary>
    /// Location of transmission's configuration directory
    /// </summary>
    [JsonProperty("config_dir")]
    public string? ConfigDirectory { get; set; }

    /// <summary>
    /// The current RPC API version
    /// </summary>
    [JsonProperty("rpc_version")]
    public int? RpcVersion { get; set; }

    /// <summary>
    /// The minimum RPC API version supported
    /// </summary>
    [JsonProperty("rpc_version_minimum")]
    public int? RpcVersionMinimum { get; set; }

    /// <summary>
    /// Long version string "$version ($revision)"
    /// </summary>
    [JsonProperty("version")]
    public string? Version { get; set; }
}
