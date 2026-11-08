using Transmission.Net.Core.Entity;

namespace Transmission.Net.Api;

/// <summary>
/// Torrent fields
/// </summary>
public static class TorrentFields
{
    /// <inheritdoc cref="ITorrentView.ActivityDate"/>
    public const string ACTIVITY_DATE = "activity_date";

    /// <inheritdoc cref="ITorrentView.AddedDate"/>
    public const string ADDED_DATE = "added_date";

    /// <inheritdoc cref="ITorrentData.BandwidthPriority"/>
    public const string BANDWIDTH_PRIORITY = "bandwidth_priority";

    /// <inheritdoc cref="ITorrentView.Comment"/>
    public const string COMMENT = "comment";

    /// <inheritdoc cref="ITorrentView.CorruptEver"/>
    public const string CORRUPT_EVER = "corrupt_ever";

    /// <inheritdoc cref="ITorrentView.Creator"/>
    public const string CREATOR = "creator";

    /// <inheritdoc cref="ITorrentView.DateCreated"/>
    public const string DATE_CREATED = "date_created";

    /// <inheritdoc cref="ITorrentView.DesiredAvailable"/>
    public const string DESIRED_AVAILABLE = "desired_available";

    /// <inheritdoc cref="ITorrentView.DoneDate"/>
    public const string DONE_DATE = "done_date";

    /// <inheritdoc cref="ITorrentView.DownloadDir"/>
    public const string DOWNLOAD_DIR = "download_dir";

    /// <inheritdoc cref="ITorrentView.DownloadedEver"/>
    public const string DOWNLOADED_EVER = "downloaded_ever";

    /// <inheritdoc cref="ITorrentData.DownloadLimit"/>
    public const string DOWNLOAD_LIMIT = "download_limit";

    /// <inheritdoc cref="ITorrentData.DownloadLimited"/>
    public const string DOWNLOAD_LIMITED = "download_limited";

    /// <inheritdoc cref="ITorrentView.EditDate"/>
    public const string EDIT_DATE = "edit_date";

    /// <inheritdoc cref="ITorrentView.Error"/>
    public const string ERROR = "error";

    /// <inheritdoc cref="ITorrentView.ErrorString"/>
    public const string ERROR_STRING = "error_string";

    /// <inheritdoc cref="ITorrentView.Eta"/>
    public const string ETA = "eta";

    /// <inheritdoc cref="ITorrentView.EtaIdle"/>
    public const string ETA_IDLE = "eta_idle";

    /// <inheritdoc cref="ITorrentView.FileCount"/>
    public const string FILE_COUNT = "file_count";

    /// <inheritdoc cref="ITorrentView.Files"/>
    public const string FILES = "files";

    /// <inheritdoc cref="ITorrentView.FileStats"/>
    public const string FILE_STATS = "file_stats";

    /// <inheritdoc cref="ITorrentView.HashString"/>
    public const string HASH_STRING = "hash_string";

    /// <inheritdoc cref="ITorrentView.HaveUnchecked"/>
    public const string HAVE_UNCHECKED = "have_unchecked";

    /// <inheritdoc cref="ITorrentView.HaveValid"/>
    public const string HAVE_VALID = "have_valid";

    /// <inheritdoc cref="ITorrentData.HonorsSessionLimits"/>
    public const string HONORS_SESSION_LIMITS = "honors_session_limits";

    /// <inheritdoc cref="ITorrentView.Id"/>
    public const string ID = "id";

    /// <inheritdoc cref="ITorrentView.IsFinished"/>
    public const string IS_FINISHED = "is_finished";

    /// <inheritdoc cref="ITorrentView.IsPrivate"/>
    public const string IS_PRIVATE = "is_private";

    /// <inheritdoc cref="ITorrentView.IsStalled"/>
    public const string IS_STALLED = "is_stalled";

    /// <inheritdoc cref="ITorrentData.Labels"/>
    public const string LABELS = "labels";

    /// <inheritdoc cref="ITorrentView.LeftUntilDone"/>
    public const string LEFT_UNTIL_DONE = "left_until_done";

    /// <inheritdoc cref="ITorrentView.MagnetLink"/>
    public const string MAGNET_LINK = "magnet_link";

    /// <inheritdoc cref="ITorrentView.ManualAnnounceTime"/>
    public const string MANUAL_ANNOUNCE_TIME = "manual_announce_time";

    /// <inheritdoc cref="ITorrentView.MaxConnectedPeers"/>
    public const string MAX_CONNECTED_PEERS = "max_connected_peers";

    /// <inheritdoc cref="ITorrentView.MetadataPercentComplete"/>
    public const string METADATA_PERCENT_COMPLETE = "metadata_percent_complete";

    /// <inheritdoc cref="ITorrentView.Name"/>
    public const string NAME = "name";

    /// <inheritdoc cref="ITorrentData.PeerLimit"/>
    public const string PEER_LIMIT = "peer_limit";

    /// <inheritdoc cref="ITorrentView.Peers"/>
    public const string PEERS = "peers";

    /// <inheritdoc cref="ITorrentView.PeersConnected"/>
    public const string PEERS_CONNECTED = "peers_connected";

    /// <inheritdoc cref="ITorrentView.PeersFrom"/>
    public const string PEERS_FROM = "peers_from";

    /// <inheritdoc cref="ITorrentView.PeersGettingFromUs"/>
    public const string PEERS_GETTING_FROM_US = "peers_getting_from_us";

    /// <inheritdoc cref="ITorrentView.PeersSendingToUs"/>
    public const string PEERS_SENDING_TO_US = "peers_sending_to_us";

    /// <inheritdoc cref="ITorrentView.PercentComplete"/>
    public const string PERCENT_COMPLETE = "percent_complete";

    /// <inheritdoc cref="ITorrentView.PercentDone"/>
    public const string PERCENT_DONE = "percent_done";

    /// <inheritdoc cref="ITorrentView.Pieces"/>
    public const string PIECES = "pieces";

    /// <inheritdoc cref="ITorrentView.PieceCount"/>
    public const string PIECE_COUNT = "piece_count";

    /// <inheritdoc cref="ITorrentView.PieceSize"/>
    public const string PIECE_SIZE = "piece_size";

    /// <inheritdoc cref="ITorrentView.Priorities"/>
    public const string PRIORITIES = "priorities";

    /// <inheritdoc cref="ITorrentView.PrimaryMimeType"/>
    public const string PRIMARY_MIME_TYPE = "primary_mime_type";

    /// <inheritdoc cref="ITorrentData.QueuePosition"/>
    public const string QUEUE_POSITION = "queue_position";

    /// <inheritdoc cref="ITorrentView.RateDownload"/>
    public const string RATE_DOWNLOAD = "rate_download";

    /// <inheritdoc cref="ITorrentView.RateUpload"/>
    public const string RATE_UPLOAD = "rate_upload";

    /// <inheritdoc cref="ITorrentView.RecheckProgress"/>
    public const string RECHECK_PROGRESS = "recheck_progress";

    /// <inheritdoc cref="ITorrentView.SecondsDownloading"/>
    public const string SECONDS_DOWNLOADING = "seconds_downloading";

    /// <inheritdoc cref="ITorrentView.SecondsSeeding"/>
    public const string SECONDS_SEEDING = "seconds_seeding";

    /// <inheritdoc cref="ITorrentData.SeedIdleLimit"/>
    public const string SEED_IDLE_LIMIT = "seed_idle_limit";

    /// <inheritdoc cref="ITorrentData.SeedIdleMode"/>
    public const string SEED_IDLE_MODE = "seed_idle_mode";

    /// <inheritdoc cref="ITorrentData.SeedRatioLimit"/>
    public const string SEED_RATIO_LIMIT = "seed_ratio_limit";

    /// <inheritdoc cref="ITorrentData.SeedRatioMode"/>
    public const string SEED_RATIO_MODE = "seed_ratio_mode";

    /// <inheritdoc cref="ITorrentData.SequentialDownload"/>
    public const string SEQUENTIAL_DOWNLOAD = "sequential_download";

    /// <inheritdoc cref="ITorrentView.SizeWhenDone"/>
    public const string SIZE_WHEN_DONE = "size_when_done";

    /// <inheritdoc cref="ITorrentView.StartDate"/>
    public const string START_DATE = "start_date";

    /// <inheritdoc cref="ITorrentView.Status"/>
    public const string STATUS = "status";

    /// <inheritdoc cref="ITorrentView.Trackers"/>
    public const string TRACKERS = "trackers";

    /// <inheritdoc cref="ITorrentData.TrackerList"/>
    public const string TRACKER_LIST = "tracker_list";

    /// <inheritdoc cref="ITorrentView.TrackerStats"/>
    public const string TRACKER_STATS = "tracker_stats";

    /// <inheritdoc cref="ITorrentView.TotalSize"/>
    public const string TOTAL_SIZE = "total_size";

    /// <inheritdoc cref="ITorrentView.TorrentFile"/>
    public const string TORRENT_FILE = "torrent_file";

    /// <inheritdoc cref="ITorrentView.UploadedEver"/>
    public const string UPLOADED_EVER = "uploaded_ever";

    /// <inheritdoc cref="ITorrentData.UploadLimit"/>
    public const string UPLOAD_LIMIT = "upload_limit";

    /// <inheritdoc cref="ITorrentData.UploadLimited"/>
    public const string UPLOAD_LIMITED = "upload_limited";

    /// <inheritdoc cref="ITorrentView.UploadRatio"/>
    public const string UPLOAD_RATIO = "upload_ratio";

    /// <inheritdoc cref="ITorrentView.Wanted"/>
    public const string WANTED = "wanted";

    /// <inheritdoc cref="ITorrentView.Webseeds"/>
    public const string WEBSEEDS = "webseeds";

    /// <inheritdoc cref="ITorrentView.WebseedsSendingToUs"/>
    public const string WEBSEEDS_SENDING_TO_US = "webseeds_sending_to_us";

    /// <summary>
    /// All fields
    /// </summary>
    public static string[] ALL_FIELDS => new string[]
            {
                #region ALL FIELDS
                ACTIVITY_DATE,
                ADDED_DATE,
                BANDWIDTH_PRIORITY,
                COMMENT,
                CORRUPT_EVER,
                CREATOR,
                DATE_CREATED,
                DESIRED_AVAILABLE,
                DONE_DATE,
                DOWNLOAD_DIR,
                DOWNLOADED_EVER,
                DOWNLOAD_LIMIT,
                DOWNLOAD_LIMITED,
                EDIT_DATE,
                ERROR,
                ERROR_STRING,
                ETA,
                ETA_IDLE,
                FILE_COUNT,
                FILES,
                FILE_STATS,
                HASH_STRING,
                HAVE_UNCHECKED,
                HAVE_VALID,
                HONORS_SESSION_LIMITS,
                ID,
                IS_FINISHED,
                IS_PRIVATE,
                IS_STALLED,
                LABELS,
                LEFT_UNTIL_DONE,
                MAGNET_LINK,
                MANUAL_ANNOUNCE_TIME,
                MAX_CONNECTED_PEERS,
                METADATA_PERCENT_COMPLETE,
                NAME,
                PEER_LIMIT,
                PEERS,
                PEERS_CONNECTED,
                PEERS_FROM,
                PEERS_GETTING_FROM_US,
                PEERS_SENDING_TO_US,
                PERCENT_COMPLETE,
                PERCENT_DONE,
                PIECES,
                PIECE_COUNT,
                PIECE_SIZE,
                PRIORITIES,
                PRIMARY_MIME_TYPE,
                QUEUE_POSITION,
                RATE_DOWNLOAD,
                RATE_UPLOAD,
                RECHECK_PROGRESS,
                SECONDS_DOWNLOADING,
                SECONDS_SEEDING,
                SEED_IDLE_LIMIT,
                SEED_IDLE_MODE,
                SEED_RATIO_LIMIT,
                SEED_RATIO_MODE,
                SEQUENTIAL_DOWNLOAD,
                SIZE_WHEN_DONE,
                START_DATE,
                STATUS,
                TRACKERS,
                TRACKER_LIST,
                TRACKER_STATS,
                TOTAL_SIZE,
                TORRENT_FILE,
                UPLOADED_EVER,
                UPLOAD_LIMIT,
                UPLOAD_LIMITED,
                UPLOAD_RATIO,
                WANTED,
                WEBSEEDS,
                WEBSEEDS_SENDING_TO_US,
                #endregion
            };
}
