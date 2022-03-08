using Newtonsoft.Json;

namespace Transmission.API.RPC.Entity
{
    /// <summary>
    /// Torrent information
    /// </summary>
    public class TorrentInfo: ITorrentInfo
    {
        public int Id { get; set; }
        public long ActivityDate { get; set; }
        public long AddedDate { get; set; }
        public int BandwidthPriority { get; set; }
        public string Comment { get; set; }
        public int CorruptEver { get; set; }
        public string Creator { get; set; }
        public long DateCreated { get; set; }
        public long DesiredAvailable { get; set; }
        public long DoneDate { get; set; }
        public string DownloadDir { get; set; }
        public string DownloadedEver { get; set; }
        public string DownloadLimit { get; set; }
        public string DownloadLimited { get; set; }
        public long EditDate { get; set; }
        public int Error { get; set; }
        public string ErrorString { get; set; }
        public int Eta { get; set; }
        public int EtaIdle { get; set; }
        public int FileCount { get; set; }
        public TransmissionTorrentFiles[] Files { get; set; }
        public TransmissionTorrentFileStats[] FileStats { get; set; }
        public string HashString { get; set; }
        public int HaveUnchecked { get; set; }
        public long HaveValid { get; set; }
        public bool HonorsSessionLimits { get; set; }
        public bool IsFinished { get; set; }
        public bool IsPrivate { get; set; }
        public bool IsStalled { get; set; }
        public string[] Labels { get; set; }
        public long LeftUntilDone { get; set; }
        public string MagnetLink { get; set; }
        public int ManualAnnounceTime { get; set; }
        public int MaxConnectedPeers { get; set; }
        public double MetadataPercentComplete { get; set; }
        public string Name { get; set; }
        public int PeerLimit { get; set; }
        public TransmissionTorrentPeers[] Peers { get; set; }
        public int PeersConnected { get; set; }
        public TransmissionTorrentPeersFrom PeersFrom { get; set; }
        public int PeersGettingFromUs { get; set; }
        public int PeersSendingToUs { get; set; }
        public double PercentComplete { get; set; }
        public double PercentDone { get; set; }
        public string Pieces { get; set; }
        public int PieceCount { get; set; }
        public long PieceSize { get; set; }
        public int[] Priorities { get; set; }
        public string PrimaryMimeType { get; set; }
        public int QueuePosition { get; set; }
        public int RateDownload { get; set; }
        public int RateUpload { get; set; }
        public double RecheckProgress { get; set; }
        public int SecondsDownloading { get; set; }
        public int SecondsSeeding { get; set; }
        public int SeedIdleLimit { get; set; }
        public int SeedIdleMode { get; set; }
        public double SeedRatioLimit { get; set; }
        public int SeedRatioMode { get; set; }
        public long SizeWhenDone { get; set; }
        public long StartDate { get; set; }
        public int Status { get; set; }
        public TransmissionTorrentTrackers[] Trackers { get; set; }
        public string TrackerList { get; set; }
        public TransmissionTorrentTrackerStats[] TrackerStats { get; set; }
        public long TotalSize { get; set; }
        public string TorrentFile { get; set; }
        public long UploadedEver { get; set; }
        public int UploadLimit { get; set; }
        public bool UploadLimited { get; set; }
        public double UploadRatio { get; set; }
        public bool[] Wanted { get; set; }
        public string[] Webseeds { get; set; }
        public int WebseedsSendingToUs { get; set; }
    }

    /// <summary>
    /// Torrent files
    /// </summary>
    public class TransmissionTorrentFiles
    {
        /// <summary>
        /// Bytes completed
        /// </summary>
        [JsonProperty("bytesCompleted")]
        public double BytesCompleted { get; set; }

        /// <summary>
        /// Length
        /// </summary>
        [JsonProperty("length")]
        public double Length { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    /// <summary>
    /// Torrent file stats
    /// </summary>
    public class TransmissionTorrentFileStats
    {
        /// <summary>
        /// Bytes completed
        /// </summary>
        [JsonProperty("bytesCompleted")]
        public double BytesCompleted { get; set; }

        /// <summary>
        /// Wanted
        /// </summary>
        [JsonProperty("wanted")]
        public bool Wanted { get; set; }

        /// <summary>
        /// Priority
        /// </summary>
        [JsonProperty("priority")]
        public int Priority { get; set; }
    }

    /// <summary>
    /// Torrent peers
    /// </summary>
    public class TransmissionTorrentPeers
    {
        /// <summary>
        /// Address
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// Client name
        /// </summary>
        [JsonProperty("clientName")]
        public string ClientName { get; set; }

        /// <summary>
        /// Client is choked
        /// </summary>
        [JsonProperty("clientIsChoked")]
        public bool ClientIsChoked { get; set; }

        /// <summary>
        /// Client is interested
        /// </summary>
        [JsonProperty("clientIsInterested")]
        public bool ClientIsInterested { get; set; }

        /// <summary>
        /// Flag string
        /// </summary>
        [JsonProperty("flagStr")]
        public string FlagStr { get; set; }

        /// <summary>
        /// Is downloading from
        /// </summary>
        [JsonProperty("isDownloadingFrom")]
        public bool IsDownloadingFrom { get; set; }

        /// <summary>
        /// Is encrypted
        /// </summary>
        [JsonProperty("isEncrypted")]
        public bool IsEncrypted { get; set; }

        /// <summary>
        /// Is uploading to
        /// </summary>
        [JsonProperty("isUploadingTo")]
        public bool IsUploadingTo { get; set; }

        /// <summary>
        /// Is UTP
        /// </summary>
        [JsonProperty("isUTP")]
        public bool IsUTP { get; set; }

        /// <summary>
        /// Peer is choked
        /// </summary>
        [JsonProperty("peerIsChoked")]
        public bool PeerIsChoked { get; set; }

        /// <summary>
        /// Peer is interested
        /// </summary>
        [JsonProperty("peerIsInterested")]
        public bool PeerIsInterested { get; set; }

        /// <summary>
        /// Port
        /// </summary>
        [JsonProperty("port")]
        public int Port { get; set; }

        /// <summary>
        /// Progress
        /// </summary>
        [JsonProperty("progress")]
        public double Progress { get; set; }

        /// <summary>
        /// Rate to client
        /// </summary>
        [JsonProperty("rateToClient")]
        public int RateToClient { get; set; }

        /// <summary>
        /// Rate to peer
        /// </summary>
        [JsonProperty("rateToPeer")]
        public int RateToPeer { get; set; }
    }

    /// <summary>
    /// Torrent peers from
    /// </summary>
    public class TransmissionTorrentPeersFrom
    {
        /// <summary>
        /// From DHT
        /// </summary>
        [JsonProperty("fromDht")]
        public int FromDHT { get; set; }

        /// <summary>
        /// From incoming
        /// </summary>
        [JsonProperty("fromIncoming")]
        public int FromIncoming { get; set; }

        /// <summary>
        /// From LPD
        /// </summary>
        [JsonProperty("fromLpd")]
        public int FromLPD { get; set; }

        /// <summary>
        /// From LTEP
        /// </summary>
        [JsonProperty("fromLtep")]
        public int FromLTEP { get; set; }

        /// <summary>
        /// From PEX
        /// </summary>
        [JsonProperty("fromPex")]
        public int FromPEX { get; set; }

        /// <summary>
        /// From tracker
        /// </summary>
        [JsonProperty("fromTracker")]
        public int FromTracker { get; set; }
    }

    /// <summary>
    /// Torrent trackers
    /// </summary>
    public class TransmissionTorrentTrackers
    {
        /// <summary>
        /// Announce
        /// </summary>
        [JsonProperty("announce")]
        public string announce { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        [JsonProperty("id")]
        public int ID { get; set; }

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
    public class TransmissionTorrentTrackerStats
    {
        /// <summary>
        /// Announce
        /// </summary>
        [JsonProperty("announce")]
        public string announce { get; set; }

        /// <summary>
        /// Announce state
        /// </summary>
        [JsonProperty("announceState")]
        public int AnnounceState { get; set; }

        /// <summary>
        /// Download count
        /// </summary>
        [JsonProperty("downloadCount")]
        public int DownloadCount { get; set; }

        /// <summary>
        /// Has announced
        /// </summary>
        [JsonProperty("hasAnnounced")]
        public bool HasAnnounced { get; set; }

        /// <summary>
        /// Has scraped
        /// </summary>
        [JsonProperty("hasScraped")]
        public bool HasScraped { get; set; }

        /// <summary>
        /// Host
        /// </summary>
        [JsonProperty("host")]
        public string Host { get; set; }

        /// <summary>
        /// Is backup
        /// </summary>
        [JsonProperty("isBackup")]
        public bool IsBackup { get; set; }

        /// <summary>
        /// Last announce peer count
        /// </summary>
        [JsonProperty("lastAnnouncePeerCount")]
        public int LastAnnouncePeerCount { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        [JsonProperty("id")]
        public int ID { get; set; }

        /// <summary>
        /// Last announce result 
        /// </summary>
        [JsonProperty("lastAnnounceResult")]
        public string LastAnnounceResult { get; set; }

        /// <summary>
        /// Last announce succeeded
        /// </summary>
        [JsonProperty("lastAnnounceSucceeded")]
        public bool LastAnnounceSucceeded { get; set; }

        /// <summary>
        /// Last announce start time
        /// </summary>
        [JsonProperty("lastAnnounceStartTime")]
        public int LastAnnounceStartTime { get; set; }

        /// <summary>
        /// Last scrape result
        /// </summary>
        [JsonProperty("lastScrapeResult")]
        public string LastScrapeResult { get; set; }

        /// <summary>
        /// Last announce timed out
        /// </summary>
        [JsonProperty("lastAnnounceTimedOut")]
        public bool LastAnnounceTimedOut { get; set; }

        /// <summary>
        /// Last announce time
        /// </summary>
        [JsonProperty("lastAnnounceTime")]
        public int LastAnnounceTime { get; set; }

        /// <summary>
        /// Last scrape scceeded
        /// </summary>
        [JsonProperty("lastScrapeSucceeded")]
        public bool LastScrapeSucceeded { get; set; }

        /// <summary>
        /// Last scrape start time
        /// </summary>
        [JsonProperty("lastScrapeStartTime")]
        public int LastScrapeStartTime { get; set; }

        /// <summary>
        /// Last scrape timed out
        /// </summary>
        [JsonProperty("lastScrapeTimedOut")]
        public bool LastScrapeTimedOut { get; set; }

        /// <summary>
        /// Last scrape time
        /// </summary>
        [JsonProperty("lastScrapeTime")]
        public int LastScrapeTime { get; set; }

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

        /// <summary>
        /// Leecher count
        /// </summary>
        [JsonProperty("leecherCount")]
        public int LeecherCount { get; set; }

        /// <summary>
        /// Next announce time
        /// </summary>
        [JsonProperty("nextAnnounceTime")]
        public int NextAnnounceTime { get; set; }

        /// <summary>
        /// Next scrape time
        /// </summary>
        [JsonProperty("nextScrapeTime")]
        public int NextScrapeTime { get; set; }

        /// <summary>
        /// Scrape state
        /// </summary>
        [JsonProperty("scrapeState")]
        public int ScrapeState { get; set; }

        /// <summary>
        /// Seeder count
        /// </summary>
        [JsonProperty("seederCount")]
        public int SeederCount { get; set; }
    }

    /// <summary>
    /// Contains arrays of torrents and removed torrents
    /// </summary>
    public class TransmissionTorrents
    {
        /// <summary>
        /// Array of torrents
        /// </summary>
        [JsonProperty("torrents")]
        public TorrentInfo[] Torrents { get; set; }

        /// <summary>
        /// Array of torrent-id numbers of recently-removed torrents
        /// </summary>
        [JsonProperty("removed")]
        public TorrentInfo[] Removed { get; set; }
    }
}
