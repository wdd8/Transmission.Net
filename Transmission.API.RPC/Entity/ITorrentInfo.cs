using Newtonsoft.Json;
using Transmission.API.RPC.Common;
using static Transmission.API.RPC.Entity.TorrentFields;

namespace Transmission.API.RPC.Entity
{
    public interface ITorrentInfo : ITorrentAttributes
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
        /// Defines what kind of text is in errorString.
        /// 
        /// See <seealso cref="ErrorString"/>
        /// </summary>
        [JsonProperty(ERROR)]
        public TorrentError Error { get; set; }

        /// <summary>
        /// A warning or error message regarding the torrent.
        /// 
        /// <seealso cref="Error"/>
        /// </summary>
        [JsonProperty(ERROR_STRING)]
        public string ErrorString { get; set; }

        /// <summary>
        /// If downloading, estimated number of seconds left until the torrent is done.
        /// If seeding, estimated number of seconds left until seed ratio is reached.
        /// </summary>
        [JsonProperty(ETA)]
        public int Eta { get; set; }

        /// <summary>
        /// If seeding, number of seconds left until the idle time limit is reached.
        /// </summary>
        [JsonProperty(ETA_IDLE)]
        public int EtaIdle { get; set; }

        [JsonProperty(FILE_COUNT)]
        public int FileCount { get; set; }

        [JsonProperty(FILES)]
        public ITransmissionTorrentFile[] Files { get; set; }

        [JsonProperty(FILE_STATS)]
        public ITransmissionTorrentFileStats[] FileStats { get; set; }

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

        [JsonProperty(IS_FINISHED)]
        public bool IsFinished { get; set; }

        [JsonProperty(IS_PRIVATE)]
        public bool IsPrivate { get; set; }

        [JsonProperty(IS_STALLED)]
        public bool IsStalled { get; set; }

        [JsonProperty(LEFT_UNTIL_DONE)]
        public long LeftUntilDone { get; set; }

        [JsonProperty(MAGNET_LINK)]
        public string MagnetLink { get; set; }

        /// <summary>
        /// Time when one or more of the torrent's trackers will
        /// allow you to manually ask for more peers, or 0 if you
        /// can't
        /// </summary>
        [JsonProperty(MANUAL_ANNOUNCE_TIME)]
        public int ManualAnnounceTime { get; set; }

        [JsonProperty(MAX_CONNECTED_PEERS)]
        public int MaxConnectedPeers { get; set; }

        [JsonProperty(METADATA_PERCENT_COMPLETE)]
        public double MetadataPercentComplete { get; set; }

        [JsonProperty(NAME)]
        public string Name { get; set; }

        [JsonProperty(PEERS)]
        public ITransmissionTorrentPeers[] Peers { get; set; }

        /// <summary>
        /// Number of peers that we're connected to
        /// </summary>
        [JsonProperty(PEERS_CONNECTED)]
        public int PeersConnected { get; set; }

        /// <summary>
        /// How many peers we found out about from the tracker, or from pex,
        /// or from incoming connections, or from our resume file.
        /// </summary>
        [JsonProperty(PEERS_FROM)]
        public ITransmissionTorrentPeersFrom PeersFrom { get; set; }

        /// <summary>
        /// Number of peers that we're sending data to.
        /// </summary>
        [JsonProperty(PEERS_GETTING_FROM_US)]
        public int PeersGettingFromUs { get; set; }

        /// <summary>
        /// Number of peers that are sending data to us.
        /// </summary>
        [JsonProperty(PEERS_SENDING_TO_US)]
        public int PeersSendingToUs { get; set; }

        [JsonProperty(PERCENT_COMPLETE)]
        public double PercentComplete { get; set; }

        [JsonProperty(PERCENT_DONE)]
        public double PercentDone { get; set; }

        [JsonProperty(PIECES)]
        public string Pieces { get; set; }

        [JsonProperty(PIECE_COUNT)]
        public int PieceCount { get; set; }

        [JsonProperty(PIECE_SIZE)]
        public long PieceSize { get; set; }

        [JsonProperty(PRIORITIES)]
        public int[] Priorities { get; set; }

        [JsonProperty(PRIMARY_MIME_TYPE)]
        public string PrimaryMimeType { get; set; }

        [JsonProperty(RATE_DOWNLOAD)]
        public int RateDownload { get; set; }

        [JsonProperty(RATE_UPLOAD)]
        public int RateUpload { get; set; }

        [JsonProperty(RECHECK_PROGRESS)]
        public double RecheckProgress { get; set; }

        /// <summary>
        /// Cumulative seconds the torrent's ever spent downloading 
        /// </summary>
        [JsonProperty(SECONDS_DOWNLOADING)]
        public int SecondsDownloading { get; set; }

        [JsonProperty(SECONDS_SEEDING)]
        public int SecondsSeeding { get; set; }

        [JsonProperty(SIZE_WHEN_DONE)]
        public long SizeWhenDone { get; set; }

        [JsonProperty(START_DATE)]
        public long StartDate { get; set; }

        [JsonProperty(STATUS)]
        public TorrentStatus Status { get; set; }

        [JsonProperty(TRACKERS)]
        public ITransmissionTorrentTrackers[] Trackers { get; set; }

        [JsonProperty(TRACKER_STATS)]
        public ITransmissionTorrentTrackerStats[] TrackerStats { get; set; }

        [JsonProperty(TOTAL_SIZE)]
        public long TotalSize { get; set; }

        [JsonProperty(TORRENT_FILE)]
        public string TorrentFile { get; set; }

        [JsonProperty(UPLOADED_EVER)]
        public long UploadedEver { get; set; }

        [JsonProperty(UPLOAD_RATIO)]
        public double UploadRatio { get; set; }

        [JsonProperty(WANTED)]
        public bool[] Wanted { get; set; }

        [JsonProperty(WEBSEEDS)]
        public string[] Webseeds { get; set; }

        /// <summary>
        /// Number of webseeds that are sending data to us.
        /// </summary>
        [JsonProperty(WEBSEEDS_SENDING_TO_US)]
        public int WebseedsSendingToUs { get; set; }
    }

    public interface ITransmissionTorrentFile
    {
        /// <summary>
        /// Bytes completed
        /// </summary>
        [JsonProperty("bytesCompleted")]
        double BytesCompleted { get; set; }

        /// <summary>
        /// Length
        /// </summary>
        [JsonProperty("length")]
        double Length { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name")]
        string Name { get; set; }
    }

    public interface ITransmissionTorrentFileStats
    {
        /// <summary>
        /// Bytes completed
        /// </summary>
        [JsonProperty("bytesCompleted")]
        double BytesCompleted { get; set; }

        /// <summary>
        /// Wanted
        /// </summary>
        [JsonProperty("wanted")]
        bool Wanted { get; set; }

        /// <summary>
        /// Priority
        /// </summary>
        [JsonProperty("priority")]
        int Priority { get; set; }
    }

    public interface ITransmissionTorrentPeers
    {
        /// <summary>
        /// Address
        /// </summary>
        [JsonProperty("address")]
        string Address { get; set; }

        /// <summary>
        /// Client name
        /// </summary>
        [JsonProperty("clientName")]
        string ClientName { get; set; }

        /// <summary>
        /// Client is choked
        /// </summary>
        [JsonProperty("clientIsChoked")]
        bool ClientIsChoked { get; set; }

        /// <summary>
        /// Client is interested
        /// </summary>
        [JsonProperty("clientIsInterested")]
        bool ClientIsInterested { get; set; }

        /// <summary>
        /// Flag string
        /// </summary>
        [JsonProperty("flagStr")]
        string FlagStr { get; set; }

        /// <summary>
        /// Is downloading from
        /// </summary>
        [JsonProperty("isDownloadingFrom")]
        bool IsDownloadingFrom { get; set; }

        /// <summary>
        /// Is encrypted
        /// </summary>
        [JsonProperty("isEncrypted")]
        bool IsEncrypted { get; set; }

        /// <summary>
        /// Is uploading to
        /// </summary>
        [JsonProperty("isUploadingTo")]
        bool IsUploadingTo { get; set; }

        /// <summary>
        /// Is UTP
        /// </summary>
        [JsonProperty("isUTP")]
        bool IsUTP { get; set; }

        /// <summary>
        /// Peer is choked
        /// </summary>
        [JsonProperty("peerIsChoked")]
        bool PeerIsChoked { get; set; }

        /// <summary>
        /// Peer is interested
        /// </summary>
        [JsonProperty("peerIsInterested")]
        bool PeerIsInterested { get; set; }

        /// <summary>
        /// Port
        /// </summary>
        [JsonProperty("port")]
        int Port { get; set; }

        /// <summary>
        /// Progress
        /// </summary>
        [JsonProperty("progress")]
        double Progress { get; set; }

        /// <summary>
        /// Rate to client
        /// </summary>
        [JsonProperty("rateToClient")]
        int RateToClient { get; set; }

        /// <summary>
        /// Rate to peer
        /// </summary>
        [JsonProperty("rateToPeer")]
        int RateToPeer { get; set; }
    }

    /// <summary>
    /// Torrent peers from
    /// </summary>
    public interface ITransmissionTorrentPeersFrom
    {
        /// <summary>
        /// From DHT
        /// </summary>
        [JsonProperty("fromDht")]
        int FromDHT { get; set; }

        /// <summary>
        /// From incoming
        /// </summary>
        [JsonProperty("fromIncoming")]
        int FromIncoming { get; set; }

        /// <summary>
        /// From LPD
        /// </summary>
        [JsonProperty("fromLpd")]
        int FromLPD { get; set; }

        /// <summary>
        /// From LTEP
        /// </summary>
        [JsonProperty("fromLtep")]
        int FromLTEP { get; set; }

        /// <summary>
        /// From PEX
        /// </summary>
        [JsonProperty("fromPex")]
        int FromPEX { get; set; }

        /// <summary>
        /// From tracker
        /// </summary>
        [JsonProperty("fromTracker")]
        int FromTracker { get; set; }
    }

    /// <summary>
    /// Torrent trackers
    /// </summary>
    public interface ITransmissionTorrentTrackers
    {
        /// <summary>
        /// Announce
        /// </summary>
        [JsonProperty("announce")]
        public string Announce { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Scrape
        /// </summary>
        [JsonProperty("scrape")]
        public string Scrape { get; set; }

        /// <summary>
        /// Tier
        /// </summary>
        [JsonProperty("tier")]
        public int Tier { get; set; }
    }

    /// <summary>
    /// Torrent tracker stats
    /// </summary>
    public interface ITransmissionTorrentTrackerStats
    {
        /// <summary>
        /// Announce
        /// </summary>
        [JsonProperty("announce")]
        string Announce { get; set; }

        /// <summary>
        /// Announce state
        /// </summary>
        [JsonProperty("announceState")]
        int AnnounceState { get; set; }

        /// <summary>
        /// Download count
        /// </summary>
        [JsonProperty("downloadCount")]
        int DownloadCount { get; set; }

        /// <summary>
        /// Has announced
        /// </summary>
        [JsonProperty("hasAnnounced")]
        bool HasAnnounced { get; set; }

        /// <summary>
        /// Has scraped
        /// </summary>
        [JsonProperty("hasScraped")]
        bool HasScraped { get; set; }

        /// <summary>
        /// Host
        /// </summary>
        [JsonProperty("host")]
        string Host { get; set; }

        /// <summary>
        /// Is backup
        /// </summary>
        [JsonProperty("isBackup")]
        bool IsBackup { get; set; }

        /// <summary>
        /// Last announce peer count
        /// </summary>
        [JsonProperty("lastAnnouncePeerCount")]
        int LastAnnouncePeerCount { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        [JsonProperty("id")]
        int Id { get; set; }

        /// <summary>
        /// Last announce result 
        /// </summary>
        [JsonProperty("lastAnnounceResult")]
        string LastAnnounceResult { get; set; }

        /// <summary>
        /// Last announce succeeded
        /// </summary>
        [JsonProperty("lastAnnounceSucceeded")]
        bool LastAnnounceSucceeded { get; set; }

        /// <summary>
        /// Last announce start time
        /// </summary>
        [JsonProperty("lastAnnounceStartTime")]
        int LastAnnounceStartTime { get; set; }

        /// <summary>
        /// Last scrape result
        /// </summary>
        [JsonProperty("lastScrapeResult")]
        string LastScrapeResult { get; set; }

        /// <summary>
        /// Last announce timed out
        /// </summary>
        [JsonProperty("lastAnnounceTimedOut")]
        bool LastAnnounceTimedOut { get; set; }

        /// <summary>
        /// Last announce time
        /// </summary>
        [JsonProperty("lastAnnounceTime")]
        int LastAnnounceTime { get; set; }

        /// <summary>
        /// Last scrape scceeded
        /// </summary>
        [JsonProperty("lastScrapeSucceeded")]
        bool LastScrapeSucceeded { get; set; }

        /// <summary>
        /// Last scrape start time
        /// </summary>
        [JsonProperty("lastScrapeStartTime")]
        int LastScrapeStartTime { get; set; }

        /// <summary>
        /// Last scrape timed out
        /// </summary>
        [JsonProperty("lastScrapeTimedOut")]
        bool LastScrapeTimedOut { get; set; }

        /// <summary>
        /// Last scrape time
        /// </summary>
        [JsonProperty("lastScrapeTime")]
        int LastScrapeTime { get; set; }

        /// <summary>
        /// Scrape
        /// </summary>
        [JsonProperty("scrape")]
        string Scrape { get; set; }

        /// <summary>
        /// Tier
        /// </summary>
        [JsonProperty("tier")]
        int Tier { get; set; }

        /// <summary>
        /// Leecher count
        /// </summary>
        [JsonProperty("leecherCount")]
        int LeecherCount { get; set; }

        /// <summary>
        /// Next announce time
        /// </summary>
        [JsonProperty("nextAnnounceTime")]
        int NextAnnounceTime { get; set; }

        /// <summary>
        /// Next scrape time
        /// </summary>
        [JsonProperty("nextScrapeTime")]
        int NextScrapeTime { get; set; }

        /// <summary>
        /// Scrape state
        /// </summary>
        [JsonProperty("scrapeState")]
        int ScrapeState { get; set; }

        /// <summary>
        /// Seeder count
        /// </summary>
        [JsonProperty("seederCount")]
        int SeederCount { get; set; }
    }

    /// <summary>
    /// Contains arrays of torrents and removed torrents
    /// </summary>
    public interface ITransmissionTorrents
    {
        /// <summary>
        /// Array of torrents
        /// </summary>
        [JsonProperty("torrents")]
        TorrentInfo[] Torrents { get; set; }

        /// <summary>
        /// Array of torrent-id numbers of recently-removed torrents
        /// </summary>
        [JsonProperty("removed")]
        TorrentInfo[] Removed { get; set; }
    }

    public enum TorrentError
    {
        /// <summary>
        /// Everything's fine
        /// </summary>
        Ok = 0,
        /// <summary>
        /// When we anounced to the tracker, we got a warning in the response
        /// </summary>
        TrackerWarning = 1,
        /// <summary>
        /// When we anounced to the tracker, we got an error in the response
        /// </summary>
        TrackerError = 2,
        /// <summary>
        /// Local trouble, such as disk full or permissions error
        /// </summary>
        LocalError = 3
    }

    public enum TorrentStatus
    {
        /// <summary>
        /// Torrent is stopped
        /// </summary>
        Stopped = 0,

        /// <summary>
        /// Torrent is queued to verify local data
        /// </summary>
        QueueVerify = 1,

        /// <summary>
        /// Torrent is verifying local data
        /// </summary>
        Verifying = 2,

        /// <summary>
        /// Torrent is queued to download
        /// </summary>
        QueueDownload = 3,

        /// <summary>
        /// Torrent is downloading
        /// </summary>
        Downloading = 4,

        /// <summary>
        /// Torrent is queued to seed
        /// </summary>
        QueueSeed = 5,

        /// <summary>
        /// Torrent is seeding
        /// </summary>
        Seeding = 6,
    }
}
