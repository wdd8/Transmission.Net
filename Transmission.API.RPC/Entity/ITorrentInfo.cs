using Newtonsoft.Json;
using Transmission.API.RPC.Common;
using static Transmission.API.RPC.Entity.TorrentFields;

namespace Transmission.API.RPC.Entity
{
    public interface ITorrentInfo: ITorrentAttributes
    {
        /// <summary>
        /// The torrent's unique Id.
        /// </summary>
        [JsonProperty(ID)]
        int Id { get; set; }

        /// <summary>
        /// The last time we uploaded or downloaded piece data on this torrent.
        /// </summary>
        [JsonProperty(ACTIVITY_DATE)]
        public long ActivityDate { get; set; }

        /// <summary>
        /// When the torrent was first added.
        /// </summary>
        [JsonProperty(ADDED_DATE)]
        public long AddedDate { get; set; }

        /// <summary>
        /// Comment
        /// </summary>
        [JsonProperty(COMMENT)]
        public string Comment { get; set; }

        /// <summary>
        /// Byte count of all the corrupt data you've ever downloaded for
        /// this torrent.If you're on a poisoned torrent, this number can
        /// grow very large.
        /// </summary>
        [JsonProperty(CORRUPT_EVER)]
        public int CorruptEver { get; set; }

        /// <summary>
        /// Creator
        /// </summary>
        [JsonProperty(CREATOR)]
        public string Creator { get; set; }

        /// <summary>
        /// Date created
        /// </summary>
        [JsonProperty(DATE_CREATED)]
        public long DateCreated { get; set; }

        /// <summary>
        /// Byte count of all the piece data we want and don't have yet,
        /// but that a connected peer does have. [0...<see cref="LeftUntilDone"/>]
        /// </summary>
        [JsonProperty(DESIRED_AVAILABLE)]
        public long DesiredAvailable { get; set; }

        /// <summary>
        /// When the torrent finished downloading.
        /// </summary>
        [JsonProperty(DONE_DATE)]
        public long DoneDate { get; set; }

        /// <summary>
        /// Download directory
        /// </summary>
        [JsonProperty(DOWNLOAD_DIR)]
        public string DownloadDir { get; set; }

        /// <summary>
        /// Byte count of all the non-corrupt data you've ever downloaded
        /// for this torrent. If you delete the files and download them a
        /// second time, this will be 2 * <see cref="TotalSize"/>..
        /// </summary>
        [JsonProperty(DOWNLOADED_EVER)]
        public string DownloadedEver { get; set; }

        /// <summary>
        /// Edit date
        /// </summary>
        [JsonProperty(EDIT_DATE)]
        public long EditDate { get; set; }

        /// <summary>
        /// Error
        /// </summary>
        [JsonProperty(ERROR)]
        public int Error { get; set; }

        /// <summary>
        /// Error string
        /// </summary>
        [JsonProperty(ERROR_STRING)]
        public string ErrorString { get; set; }

        /// <summary>
        /// ETA
        /// </summary>
        [JsonProperty(ETA)]
        public int Eta { get; set; }

        /// <summary>
        /// ETA idle
        /// </summary>
        [JsonProperty(ETA_IDLE)]
        public int EtaIdle { get; set; }

        /// <summary>
        /// File count
        /// </summary>
        [JsonProperty(FILE_COUNT)]
        public int FileCount { get; set; }

        /// <summary>
        /// Files
        /// </summary>
        [JsonProperty(FILES)]
        public TransmissionTorrentFiles[] Files { get; set; }

        /// <summary>
        /// File stats
        /// </summary>
        [JsonProperty(FILE_STATS)]
        public TransmissionTorrentFileStats[] FileStats { get; set; }

        /// <summary>
        /// Hash string
        /// </summary>
        [JsonProperty(HASH_STRING)]
        public string HashString { get; set; }

        /// <summary>
        /// Byte count of all the partial piece data we have for this torrent.
        /// 
        /// As pieces become complete, this value may decrease as portions of it
        /// are moved to <see cref="CorruptEver"/> or <see cref="HaveValid"/>.
        /// </summary>
        [JsonProperty(HAVE_UNCHECKED)]
        public int HaveUnchecked { get; set; }

        /// <summary>
        /// Byte count of all the checksum-verified data we have for this torrent.
        /// </summary>
        [JsonProperty(HAVE_VALID)]
        public long HaveValid { get; set; }

        /// <summary>
        /// Is finished
        /// </summary>
        [JsonProperty(IS_FINISHED)]
        public bool IsFinished { get; set; }

        /// <summary>
        /// Is private
        /// </summary>
        [JsonProperty(IS_PRIVATE)]
        public bool IsPrivate { get; set; }

        /// <summary>
        /// Is stalled
        /// </summary>
        [JsonProperty(IS_STALLED)]
        public bool IsStalled { get; set; }

        /// <summary>
        /// Left until done
        /// </summary>
        [JsonProperty(LEFT_UNTIL_DONE)]
        public long LeftUntilDone { get; set; }

        /// <summary>
        /// Magnet link
        /// </summary>
        [JsonProperty(MAGNET_LINK)]
        public string MagnetLink { get; set; }

        /// <summary>
        /// Time when one or more of the torrent's trackers will
        /// allow you to manually ask for more peers, or 0 if you
        /// can't
        /// </summary>
        [JsonProperty(MANUAL_ANNOUNCE_TIME)]
        public int ManualAnnounceTime { get; set; }

        /// <summary>
        /// Max connected peers
        /// </summary>
        [JsonProperty(MAX_CONNECTED_PEERS)]
        public int MaxConnectedPeers { get; set; }

        /// <summary>
        /// Metadata percent complete
        /// </summary>
        [JsonProperty(METADATA_PERCENT_COMPLETE)]
        public double MetadataPercentComplete { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty(NAME)]
        public string Name { get; set; }

        /// <summary>
        /// Peers
        /// </summary>
        [JsonProperty(PEERS)]
        public TransmissionTorrentPeers[] Peers { get; set; }

        /// <summary>
        /// Peers connected
        /// </summary>
        [JsonProperty(PEERS_CONNECTED)]
        public int PeersConnected { get; set; }

        /// <summary>
        /// Peers from
        /// </summary>
        [JsonProperty(PEERS_FROM)]
        public TransmissionTorrentPeersFrom PeersFrom { get; set; }

        /// <summary>
        /// Peers getting from us
        /// </summary>
        [JsonProperty(PEERS_GETTING_FROM_US)]
        public int PeersGettingFromUs { get; set; }

        /// <summary>
        /// Peers sending to us
        /// </summary>
        [JsonProperty(PEERS_SENDING_TO_US)]
        public int PeersSendingToUs { get; set; }

        /// <summary>
        /// Percent complete
        /// </summary>
        [JsonProperty(PERCENT_COMPLETE)]
        public double PercentComplete { get; set; }

        /// <summary>
        /// Percent done
        /// </summary>
        [JsonProperty(PERCENT_DONE)]
        public double PercentDone { get; set; }

        /// <summary>
        /// Pieces
        /// </summary>
        [JsonProperty(PIECES)]
        public string Pieces { get; set; }

        /// <summary>
        /// Piece count
        /// </summary>
        [JsonProperty(PIECE_COUNT)]
        public int PieceCount { get; set; }

        /// <summary>
        /// Piece size
        /// </summary>
        [JsonProperty(PIECE_SIZE)]
        public long PieceSize { get; set; }

        /// <summary>
        /// Priorities
        /// </summary>
        [JsonProperty(PRIORITIES)]
        public int[] Priorities { get; set; }

        /// <summary>
        /// Primary mime type
        /// </summary>
        [JsonProperty(PRIMARY_MIME_TYPE)]
        public string PrimaryMimeType { get; set; }

        /// <summary>
        /// Rate download
        /// </summary>
        [JsonProperty(RATE_DOWNLOAD)]
        public int RateDownload { get; set; }

        /// <summary>
        /// Rate upload
        /// </summary>
        [JsonProperty(RATE_UPLOAD)]
        public int RateUpload { get; set; }

        /// <summary>
        /// Recheck progress
        /// </summary>
        [JsonProperty(RECHECK_PROGRESS)]
        public double RecheckProgress { get; set; }

        /// <summary>
        /// Seconds downloading
        /// </summary>
        [JsonProperty(SECONDS_DOWNLOADING)]
        public int SecondsDownloading { get; set; }

        /// <summary>
        /// Seconds seeding
        /// </summary>
        [JsonProperty(SECONDS_SEEDING)]
        public int SecondsSeeding { get; set; }

        /// <summary>
        /// Size when done
        /// </summary>
        [JsonProperty(SIZE_WHEN_DONE)]
        public long SizeWhenDone { get; set; }

        /// <summary>
        /// Start date
        /// </summary>
        [JsonProperty(START_DATE)]
        public long StartDate { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty(STATUS)]
        public int Status { get; set; }

        /// <summary>
        /// Trackers
        /// </summary>
        [JsonProperty(TRACKERS)]
        public TransmissionTorrentTrackers[] Trackers { get; set; }

        /// <summary>
        /// Tracker stats
        /// </summary>
        [JsonProperty(TRACKER_STATS)]
        public TransmissionTorrentTrackerStats[] TrackerStats { get; set; }

        /// <summary>
        /// Total size
        /// </summary>
        [JsonProperty(TOTAL_SIZE)]
        public long TotalSize { get; set; }

        /// <summary>
        /// Torrent file
        /// </summary>
        [JsonProperty(TORRENT_FILE)]
        public string TorrentFile { get; set; }

        /// <summary>
        /// Uploaded ever
        /// </summary>
        [JsonProperty(UPLOADED_EVER)]
        public long UploadedEver { get; set; }

        /// <summary>
        /// Upload ratio
        /// </summary>
        [JsonProperty(UPLOAD_RATIO)]
        public double UploadRatio { get; set; }

        /// <summary>
        /// Wanted
        /// </summary>
        [JsonProperty(WANTED)]
        public bool[] Wanted { get; set; }

        /// <summary>
        /// Web seeds
        /// </summary>
        [JsonProperty(WEBSEEDS)]
        public string[] Webseeds { get; set; }

        /// <summary>
        /// Web seeds sending to us
        /// </summary>
        [JsonProperty(WEBSEEDS_SENDING_TO_US)]
        public int WebseedsSendingToUs { get; set; }
    }
}
