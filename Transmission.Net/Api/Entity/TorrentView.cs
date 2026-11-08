using System.Text.Json.Serialization;
using Transmission.Net.Core.Entity;
using Transmission.Net.Core.Entity.Torrent;
using Transmission.Net.Core.Enums;
using Transmission.Net.Core.Util;
using static Transmission.Net.Api.TorrentFields;

namespace Transmission.Net.Api.Entity;

/// <summary>
/// Torrent information
/// </summary>
public class TorrentView : ITorrentView
{
    [JsonPropertyName(ID)]
    public int? Id { get; set; }

    [JsonPropertyName(ACTIVITY_DATE), JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime? ActivityDate { get; set; }

    [JsonPropertyName(ADDED_DATE), JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime? AddedDate { get; set; }

    [JsonPropertyName(BANDWIDTH_PRIORITY)]
    public Priority? BandwidthPriority { get; set; }

    [JsonPropertyName(COMMENT)]
    public string? Comment { get; set; }

    [JsonPropertyName(CORRUPT_EVER)]
    public int? CorruptEver { get; set; }

    [JsonPropertyName(CREATOR)]
    public string? Creator { get; set; }

    [JsonPropertyName(DATE_CREATED), JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime? DateCreated { get; set; }

    [JsonPropertyName(DESIRED_AVAILABLE)]
    public long? DesiredAvailable { get; set; }

    [JsonPropertyName(DONE_DATE), JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime? DoneDate { get; set; }

    [JsonPropertyName(DOWNLOAD_DIR)]
    public string? DownloadDir { get; set; }

    [JsonPropertyName(DOWNLOADED_EVER)]
    public long? DownloadedEver { get; set; }

    [JsonPropertyName(DOWNLOAD_LIMIT)]
    public int? DownloadLimit { get; set; }

    [JsonPropertyName(DOWNLOAD_LIMITED)]
    public bool? DownloadLimited { get; set; }

    [JsonPropertyName(EDIT_DATE), JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime? EditDate { get; set; }

    [JsonPropertyName(ERROR)]
    public TorrentError? Error { get; set; }

    [JsonPropertyName(ERROR_STRING)]
    public string? ErrorString { get; set; }

    [JsonPropertyName(ETA)]
    public int? Eta { get; set; }

    [JsonPropertyName(ETA_IDLE)]
    public int? EtaIdle { get; set; }

    [JsonPropertyName(FILE_COUNT)]
    public int? FileCount { get; set; }

    [JsonPropertyName(FILES)]
    public ITorrentFile[]? Files { get; set; }

    [JsonPropertyName(FILE_STATS)]
    public ITorrentFileStats[]? FileStats { get; set; }

    [JsonPropertyName(HASH_STRING)]
    public string? HashString { get; set; }

    [JsonPropertyName(HAVE_UNCHECKED)]
    public long? HaveUnchecked { get; set; }

    [JsonPropertyName(HAVE_VALID)]
    public long? HaveValid { get; set; }

    public long? Have => HaveUnchecked + HaveValid;

    [JsonPropertyName(HONORS_SESSION_LIMITS)]
    public bool? HonorsSessionLimits { get; set; }

    [JsonPropertyName(IS_FINISHED)]
    public bool? IsFinished { get; set; }

    [JsonPropertyName(IS_PRIVATE)]
    public bool? IsPrivate { get; set; }

    [JsonPropertyName(IS_STALLED)]
    public bool? IsStalled { get; set; }

    [JsonPropertyName(LABELS)]
    public string[]? Labels { get; set; }

    [JsonPropertyName(LEFT_UNTIL_DONE)]
    public long? LeftUntilDone { get; set; }

    [JsonPropertyName(MAGNET_LINK)]
    public string? MagnetLink { get; set; }

    [JsonPropertyName(MANUAL_ANNOUNCE_TIME)]
    public int? ManualAnnounceTime { get; set; }

    [JsonPropertyName(MAX_CONNECTED_PEERS)]
    public int? MaxConnectedPeers { get; set; }

    [JsonPropertyName(METADATA_PERCENT_COMPLETE)]
    public double? MetadataPercentComplete { get; set; }

    [JsonPropertyName(NAME)]
    public string? Name { get; set; }

    [JsonPropertyName(PEER_LIMIT)]
    public int? PeerLimit { get; set; }

    [JsonPropertyName(PEERS)]
    public ITorrentPeers[]? Peers { get; set; }

    [JsonPropertyName(PEERS_CONNECTED)]
    public int? PeersConnected { get; set; }

    [JsonPropertyName(PEERS_FROM)]
    public ITorrentPeersFrom? PeersFrom { get; set; }

    [JsonPropertyName(PEERS_GETTING_FROM_US)]
    public int? PeersGettingFromUs { get; set; }

    [JsonPropertyName(PEERS_SENDING_TO_US)]
    public int? PeersSendingToUs { get; set; }

    [JsonPropertyName(PERCENT_COMPLETE)]
    public double? PercentComplete { get; set; }

    [JsonPropertyName(PERCENT_DONE)]
    public double? PercentDone { get; set; }

    [JsonPropertyName(PIECES)]
    public string? Pieces { get; set; }

    [JsonPropertyName(PIECE_COUNT)]
    public int? PieceCount { get; set; }

    [JsonPropertyName(PIECE_SIZE)]
    public long? PieceSize { get; set; }

    [JsonPropertyName(PRIORITIES)]
    public Priority[]? Priorities { get; set; }

    [JsonPropertyName(PRIMARY_MIME_TYPE)]
    public string? PrimaryMimeType { get; set; }

    [JsonPropertyName(QUEUE_POSITION)]
    public int? QueuePosition { get; set; }

    [JsonPropertyName(RATE_DOWNLOAD)]
    public int? RateDownload { get; set; }

    [JsonPropertyName(RATE_UPLOAD)]
    public int? RateUpload { get; set; }

    [JsonPropertyName(RECHECK_PROGRESS)]
    public double? RecheckProgress { get; set; }

    [JsonPropertyName(SECONDS_DOWNLOADING)]
    public int? SecondsDownloading { get; set; }

    [JsonPropertyName(SECONDS_SEEDING)]
    public int? SecondsSeeding { get; set; }

    [JsonPropertyName(SEED_IDLE_LIMIT)]
    public int? SeedIdleLimit { get; set; }

    [JsonPropertyName(SEED_IDLE_MODE)]
    public int? SeedIdleMode { get; set; }

    [JsonPropertyName(SEED_RATIO_LIMIT)]
    public double? SeedRatioLimit { get; set; }

    [JsonPropertyName(SEED_RATIO_MODE)]
    public int? SeedRatioMode { get; set; }

    [JsonPropertyName(SEQUENTIAL_DOWNLOAD)]
    public bool? SequentialDownload { get; set; }

    [JsonPropertyName(SIZE_WHEN_DONE)]
    public long? SizeWhenDone { get; set; }

    [JsonPropertyName(START_DATE), JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime? StartDate { get; set; }

    [JsonPropertyName(STATUS)]
    public TorrentStatus? Status { get; set; }

    [JsonPropertyName(TRACKERS)]
    public ITorrentTracker[]? Trackers { get; set; }

    [JsonPropertyName(TRACKER_LIST)]
    public string? TrackerList { get; set; }

    [JsonPropertyName(TRACKER_STATS)]
    public ITorrentTrackerStats[]? TrackerStats { get; set; }

    [JsonPropertyName(TOTAL_SIZE)]
    public long? TotalSize { get; set; }

    [JsonPropertyName(TORRENT_FILE)]
    public string? TorrentFile { get; set; }

    [JsonPropertyName(UPLOADED_EVER)]
    public long? UploadedEver { get; set; }

    [JsonPropertyName(UPLOAD_LIMIT)]
    public int? UploadLimit { get; set; }

    [JsonPropertyName(UPLOAD_LIMITED)]
    public bool? UploadLimited { get; set; }

    [JsonPropertyName(UPLOAD_RATIO)]
    public double? UploadRatio { get; set; }

    [JsonPropertyName(WANTED)]
    public bool[]? Wanted { get; set; }

    [JsonPropertyName(WEBSEEDS)]
    public string[]? Webseeds { get; set; }

    [JsonPropertyName(WEBSEEDS_SENDING_TO_US)]
    public int? WebseedsSendingToUs { get; set; }
}
