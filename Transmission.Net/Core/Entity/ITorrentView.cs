using Transmission.Net.Api.Entity;
using Transmission.Net.Core.Entity.Torrent;
using Transmission.Net.Core.Enums;

namespace Transmission.Net.Core.Entity;

public interface ITorrentView : ITorrentData
{
    /// <summary>
    /// The torrent's unique Id.
    /// </summary>
    int? Id { get; set; }

    /// <summary>
    /// The last time we uploaded or downloaded piece data on this torrent.
    /// </summary>
    DateTime? ActivityDate { get; set; }

    /// <summary>
    /// When the torrent was first added.
    /// </summary>
    DateTime? AddedDate { get; set; }

    string? Comment { get; set; }

    /// <summary>
    /// Byte count of all the corrupt data you've ever downloaded for
    /// this torrent.If you're on a poisoned torrent, this number can
    /// grow very large.
    /// </summary>
    int? CorruptEver { get; set; }

    string? Creator { get; set; }

    DateTime? DateCreated { get; set; }

    /// <summary>
    /// Byte count of all the piece data we want and don't have yet,
    /// but that a connected peer does have. [0...<see cref="LeftUntilDone"/>]
    /// </summary>
    long? DesiredAvailable { get; set; }

    /// <summary>
    /// When the torrent finished downloading.
    /// </summary>
    DateTime? DoneDate { get; set; }

    string? DownloadDir { get; set; }

    /// <summary>
    /// Byte count of all the non-corrupt data you've ever downloaded
    /// for this torrent. If you delete the files and download them a
    /// second time, this will be 2 * <see cref="TotalSize"/>..
    /// </summary>
    long? DownloadedEver { get; set; }

    /// <summary>
    /// The last time during this session that a rarely-changing field
    /// changed -- e.g.any tr_torrent_metainfo field(trackers, filenames, name)
    /// or download directory.RPC clients can monitor this to know when
    /// to reload fields that rarely change.
    /// </summary>
    DateTime? EditDate { get; set; }

    /// <summary>
    /// Defines what kind of text is in errorString.
    ///
    /// See <seealso cref="ErrorString"/>
    /// </summary>
    TorrentError? Error { get; set; }

    /// <summary>
    /// A warning or error message regarding the torrent.
    ///
    /// <seealso cref="Error"/>
    /// </summary>
    string? ErrorString { get; set; }

    /// <summary>
    /// If downloading, estimated number of seconds left until the torrent is done.
    /// If seeding, estimated number of seconds left until seed ratio is reached.
    /// </summary>
    int? Eta { get; set; }

    /// <summary>
    /// If seeding, number of seconds left until the idle time limit is reached.
    /// </summary>
    int? EtaIdle { get; set; }

    int? FileCount { get; set; }

    ITorrentFile[]? Files { get; set; }

    ITorrentFileStats[]? FileStats { get; set; }

    string? HashString { get; set; }

    /// <summary>
    /// Byte count of all the partial piece data we have for this torrent.
    ///
    /// As pieces become complete, this value may decrease as portions of it
    /// are moved to <see cref="CorruptEver"/> or <see cref="HaveValid"/>.
    /// </summary>
    long? HaveUnchecked { get; set; }

    /// <summary>
    /// Byte count of all the checksum-verified data we have for this torrent.
    /// </summary>
    long? HaveValid { get; set; }

    /// <summary>
    /// A torrent is considered finished if it has met its seed ratio.
    /// As a result, only paused torrents can be finished.
    /// </summary>
    bool? IsFinished { get; set; }

    bool? IsPrivate { get; set; }

    /// <summary>
    /// <see langword="true"/> if the torrent is running, but has been idle for long enough
    /// to be considered stalled.
    ///
    /// See <seealso cref="SessionInfo.QueueStalledMinutes"/>
    /// </summary>
    bool? IsStalled { get; set; }

    /// <summary>
    /// Byte count of how much data is left to be downloaded until we've got
    /// all the pieces that we want. [0..<see cref="SizeWhenDone"/>]
    /// </summary>
    long? LeftUntilDone { get; set; }

    string? MagnetLink { get; set; }

    /// <summary>
    /// Time when one or more of the torrent's trackers will
    /// allow you to manually ask for more peers, or 0 if you
    /// can't
    /// </summary>
    int? ManualAnnounceTime { get; set; }

    int? MaxConnectedPeers { get; set; }

    /// <summary>
    /// How much of the metadata the torrent has.
    /// For torrents added from a.torrent this will always be 1.
    /// For magnet links, this number will from from 0 to 1 as the metadata is downloaded.
    /// Range is [0..1]
    /// </summary>
    double? MetadataPercentComplete { get; set; }

    string? Name { get; set; }

    ITorrentPeers[]? Peers { get; set; }

    /// <summary>
    /// Number of peers that we're connected to
    /// </summary>
    int? PeersConnected { get; set; }

    /// <summary>
    /// How many peers we found out about from the tracker, or from pex,
    /// or from incoming connections, or from our resume file.
    /// </summary>
    ITorrentPeersFrom? PeersFrom { get; set; }

    /// <summary>
    /// Number of peers that we're sending data to.
    /// </summary>
    int? PeersGettingFromUs { get; set; }

    /// <summary>
    /// Number of peers that are sending data to us.
    /// </summary>
    int? PeersSendingToUs { get; set; }

    /// <summary>
    /// How much has been downloaded of the entire torrent.
    /// Range is [0..1]
    /// </summary>
    double? PercentComplete { get; set; }

    /// <summary>
    /// How much has been downloaded of the files the user wants. This differs
    /// from percentComplete if the user wants only some of the torrent's files.
    /// Range is [0..1]
    ///
    /// See <seealso cref="LeftUntilDone"/>
    /// </summary>
    double? PercentDone { get; set; }

    string? Pieces { get; set; }

    int? PieceCount { get; set; }

    long? PieceSize { get; set; }

    /// <summary>
    /// Array of <see langword="Priority"/>, with each one corresponding to a file.
    /// </summary>
    Priority[]? Priorities { get; set; }

    /// <summary>
    /// Return the mime-type (e.g. "audio/x-flac") that matches more of the
    /// torrent's content than any other mime-type.
    /// </summary>
    string? PrimaryMimeType { get; set; }

    /// <summary>
    /// Download speed (B/s)
    /// </summary>
    int? RateDownload { get; set; }

    /// <summary>
    /// Upload speed (B/s)
    /// </summary>
    int? RateUpload { get; set; }

    /// <summary>
    /// When <see cref="Status"/> is <see cref="TorrentStatus.Verifying"/> or <see cref="TorrentStatus.VerifyQueue"/>,
    /// this is the percentage of how much of the files has been
    /// verified. When it gets to 1, the verify process is done.
    /// Range is [0..1]
    ///
    /// See <seealso cref="Status"/>
    /// </summary>
    double? RecheckProgress { get; set; }

    /// <summary>
    /// Cumulative seconds the torrent's ever spent downloading
    /// </summary>
    int? SecondsDownloading { get; set; }

    /// <summary>
    /// Cumulative seconds the torrent's ever spent seeding
    /// </summary>
    int? SecondsSeeding { get; set; }

    /// <summary>
    /// Byte count of all the piece data we'll have downloaded when we're done,
    /// whether or not we have it yet. This may be less than <see cref="TotalSize"/>
    /// if only some of the torrent's files are wanted.
    /// [0...<see cref="TotalSize"/>]
    /// </summary>
    long? SizeWhenDone { get; set; }

    /// <summary>
    /// When the torrent was last started.
    /// </summary>
    DateTime? StartDate { get; set; }

    /// <summary>
    /// What is this torrent doing right now?
    /// </summary>
    TorrentStatus? Status { get; set; }

    ITorrentTracker[]? Trackers { get; set; }

    ITorrentTrackerStats[]? TrackerStats { get; set; }

    /// <summary>
    /// Total size of the torrent, including unwanted files.
    /// </summary>
    long? TotalSize { get; set; }

    /// <summary>
    /// Path to the torrent file in the server
    /// </summary>
    string? TorrentFile { get; set; }

    /// <summary>
    /// Byte count of all data you've ever uploaded for this torrent.
    /// </summary>
    long? UploadedEver { get; set; }

    /// <summary>
    /// Total uploaded bytes / total torrent size.
    /// </summary>
    double? UploadRatio { get; set; }

    /// <summary>
    /// An array of booleans, with each item corresponding to a file
    /// </summary>
    bool[]? Wanted { get; set; }

    string[]? Webseeds { get; set; }

    /// <summary>
    /// Number of webseeds that are sending data to us.
    /// </summary>
    int? WebseedsSendingToUs { get; set; }
}
