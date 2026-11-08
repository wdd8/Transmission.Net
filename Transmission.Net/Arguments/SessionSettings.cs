using Transmission.Net.Api;
using Transmission.Net.Api.Entity.Session;

namespace Transmission.Net.Arguments;

/// <summary>
/// Settings
/// </summary>
public class SessionSettings : ArgumentsBase
{
    /// <summary>
    /// Max global download speed (KBps)
    /// </summary>
    public int? AlternativeSpeedDown { get => GetValue<int?>("alt_speed_down"); set => this["alt_speed_down"] = value; }

    /// <summary>
    /// True means use the alt speeds
    /// </summary>
    public bool? AlternativeSpeedEnabled { get => GetValue<bool?>("alt_speed_enabled"); set => this["alt_speed_enabled"] = value; }

    /// <summary>
    /// When to turn on alt speeds (units: minutes after midnight)
    /// </summary>
    public int? AlternativeSpeedTimeBegin { get => GetValue<int?>("alt_speed_time_begin"); set => this["alt_speed_time_begin"] = value; }

    /// <summary>
    /// True means the scheduled on/off times are used
    /// </summary>
    public bool? AlternativeSpeedTimeEnabled { get => GetValue<bool?>("alt_speed_time_enabled"); set => this["alt_speed_time_enabled"] = value; }

    /// <summary>
    /// When to turn off alt speeds
    /// </summary>
    public int? AlternativeSpeedTimeEnd { get => GetValue<int?>("alt_speed_time_end"); set => this["alt_speed_time_end"] = value; }

    /// <summary>
    /// What day(s) to turn on alt speeds
    /// </summary>
    public int? AlternativeSpeedTimeDay { get => GetValue<int?>("alt_speed_time_day"); set => this["alt_speed_time_day"] = value; }

    /// <summary>
    /// Max global upload speed (KBps)
    /// </summary>
    public int? AlternativeSpeedUp { get => GetValue<int?>("alt_speed_up"); set => this["alt_speed_up"] = value; }

    /// <summary>
    /// Location of the blocklist to use for "blocklist_update"
    /// </summary>
    public string? BlocklistURL { get => GetValue<string?>("blocklist_url"); set => this["blocklist_url"] = value; }

    /// <summary>
    /// True means enabled
    /// </summary>
    public bool? BlocklistEnabled { get => GetValue<bool?>("blocklist_enabled"); set => this["blocklist_enabled"] = value; }

    /// <summary>
    /// Maximum size of the disk cache (MB)
    /// </summary>
    public int? CacheSizeMB { get => GetValue<int?>("cache_size_mib"); set => this["cache_size_mib"] = value; }

    /// <summary>
    /// Default path to download torrents
    /// </summary>
    public string? DownloadDirectory { get => GetValue<string?>("download_dir"); set => this["download_dir"] = value; }

    /// <summary>
    /// Max number of torrents to download at once (see download_queue_enabled)
    /// </summary>
    public int? DownloadQueueSize { get => GetValue<int?>("download_queue_size"); set => this["download_queue_size"] = value; }

    /// <summary>
    /// If true, limit how many torrents can be downloaded at once
    /// </summary>
    public bool? DownloadQueueEnabled { get => GetValue<bool?>("download_queue_enabled"); set => this["download_queue_enabled"] = value; }

    /// <summary>
    /// True means allow dht in public torrents
    /// </summary>
    public bool? DHTEnabled { get => GetValue<bool?>("dht_enabled"); set => this["dht_enabled"] = value; }

    /// <summary>
    /// "required", "preferred", "allowed"
    /// </summary>
    public string? Encryption { get => GetValue<string?>("encryption"); set => this["encryption"] = value; }

    /// <summary>
    /// Torrents we're seeding will be stopped if they're idle for this long
    /// </summary>
    public int? IdleSeedingLimit { get => GetValue<int?>("idle_seeding_limit"); set => this["idle_seeding_limit"] = value; }

    /// <summary>
    /// True if the seeding inactivity limit is honored by default
    /// </summary>
    public bool? IdleSeedingLimitEnabled { get => GetValue<bool?>("idle_seeding_limit_enabled"); set => this["idle_seeding_limit_enabled"] = value; }

    /// <summary>
    /// Path for incomplete torrents, when enabled
    /// </summary>
    public string? IncompleteDirectory { get => GetValue<string?>("incomplete_dir"); set => this["incomplete_dir"] = value; }

    /// <summary>
    /// True means keep torrents in incomplete_dir until done
    /// </summary>
    public bool? IncompleteDirectoryEnabled { get => GetValue<bool?>("incomplete_dir_enabled"); set => this["incomplete_dir_enabled"] = value; }

    /// <summary>
    /// True means allow Local Peer Discovery in public torrents
    /// </summary>
    public bool? LPDEnabled { get => GetValue<bool?>("lpd_enabled"); set => this["lpd_enabled"] = value; }

    /// <summary>
    /// Maximum global number of peers
    /// </summary>
    public int? PeerLimitGlobal { get => GetValue<int?>("peer_limit_global"); set => this["peer_limit_global"] = value; }

    /// <summary>
    /// Maximum global number of peers
    /// </summary>
    public int? PeerLimitPerTorrent { get => GetValue<int?>("peer_limit_per_torrent"); set => this["peer_limit_per_torrent"] = value; }

    /// <summary>
    /// True means allow pex in public torrents
    /// </summary>
    public bool? PexEnabled { get => GetValue<bool?>("pex_enabled"); set => this["pex_enabled"] = value; }

    /// <summary>
    /// Port number
    /// </summary>
    public int? PeerPort { get => GetValue<int?>("peer_port"); set => this["peer_port"] = value; }

    /// <summary>
    /// True means pick a random peer port on launch
    /// </summary>
    public bool? PeerPortRandomOnStart { get => GetValue<bool?>("peer_port_random_on_start"); set => this["peer_port_random_on_start"] = value; }

    /// <summary>
    /// true means enabled
    /// </summary>
    public bool? PortForwardingEnabled { get => GetValue<bool?>("port_forwarding_enabled"); set => this["port_forwarding_enabled"] = value; }

    /// <summary>
    /// Whether or not to consider idle torrents as stalled
    /// </summary>
    public bool? QueueStalledEnabled { get => GetValue<bool?>("queue_stalled_enabled"); set => this["queue_stalled_enabled"] = value; }

    /// <summary>
    /// Torrents that are idle for N minuets aren't counted toward seed_queue_size or download_queue_size
    /// </summary>
    public int? QueueStalledMinutes { get => GetValue<int?>("queue_stalled_minutes"); set => this["queue_stalled_minutes"] = value; }

    /// <summary>
    /// True means append ".part" to incomplete files
    /// </summary>
    public bool? RenamePartialFiles { get => GetValue<bool?>("rename_partial_files"); set => this["rename_partial_files"] = value; }

    /// <summary>
    /// Filename of the script to run
    /// </summary>
    public string? ScriptTorrentDoneFilename { get => GetValue<string?>("script_torrent_done_filename"); set => this["script_torrent_done_filename"] = value; }

    /// <summary>
    /// Whether or not to call the "done" script
    /// </summary>
    public bool? ScriptTorrentDoneEnabled { get => GetValue<bool?>("script_torrent_done_enabled"); set => this["script_torrent_done_enabled"] = value; }

    /// <summary>
    /// The default seed ratio for torrents to use
    /// </summary>
    public double? SeedRatioLimit { get => GetValue<int?>("seed_ratio_limit"); set => this["seed_ratio_limit"] = value; }

    /// <summary>
    /// True if seed_ratio_limit is honored by default
    /// </summary>
    public bool? SeedRatioLimited { get => GetValue<bool?>("seed_ratio_limited"); set => this["seed_ratio_limited"] = value; }

    /// <summary>
    /// Max number of torrents to uploaded at once (see seed_queue_enabled)
    /// </summary>
    public int? SeedQueueSize { get => GetValue<int?>("seed_queue_size"); set => this["seed_queue_size"] = value; }

    /// <summary>
    /// If true, limit how many torrents can be uploaded at once
    /// </summary>
    public bool? SeedQueueEnabled { get => GetValue<bool?>("seed_queue_enabled"); set => this["seed_queue_enabled"] = value; }

    /// <summary>
    /// Max global download speed (KBps)
    /// </summary>
    public int? SpeedLimitDown { get => GetValue<int?>("speed_limit_down"); set => this["speed_limit_down"] = value; }

    /// <summary>
    /// True means enabled
    /// </summary>
    public bool? SpeedLimitDownEnabled { get => GetValue<bool?>("speed_limit_down_enabled"); set => this["speed_limit_down_enabled"] = value; }

    /// <summary>
    ///  max global upload speed (KBps)
    /// </summary>
    public int? SpeedLimitUp { get => GetValue<int?>("speed_limit_up"); set => this["speed_limit_up"] = value; }

    /// <summary>
    /// True means enabled
    /// </summary>
    public bool? SpeedLimitUpEnabled { get => GetValue<bool?>("speed_limit_up_enabled"); set => this["speed_limit_up_enabled"] = value; }

    /// <summary>
    /// True means added torrents will be started right away
    /// </summary>
    public bool? StartAddedTorrents { get => GetValue<bool?>("start_added_torrents"); set => this["start_added_torrents"] = value; }

    /// <summary>
    /// True means the .torrent file of added torrents will be deleted
    /// </summary>
    public bool? TrashOriginalTorrentFiles { get => GetValue<bool?>("trash_original_torrent_files"); set => this["trash_original_torrent_files"] = value; }

    /// <summary>
    /// Units
    /// </summary>
    public Units? Units { get => GetValue<Units?>("units"); set => this["units"] = value; }

    /// <summary>
    /// True means allow utp
    /// </summary>
    public bool? UtpEnabled { get => GetValue<bool?>("utp_enabled"); set => this["utp_enabled"] = value; }

}
