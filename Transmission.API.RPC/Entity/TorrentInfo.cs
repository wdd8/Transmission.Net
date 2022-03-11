using Newtonsoft.Json;
using Transmission.API.RPC.Common;

namespace Transmission.API.RPC.Entity
{
    /// <summary>
    /// Torrent information
    /// </summary>
    public class TorrentInfo : ITorrentInfo
    {
        public TorrentInfo() { }

        [JsonConstructor]
        internal TorrentInfo(
            TransmissionTorrentFile[] files,
            TransmissionTorrentFileStats[] fileStats,
            TransmissionTorrentPeers[] peers,
            TransmissionTorrentPeersFrom peersFrom,
            TransmissionTorrentTrackers[] trackers,
            TransmissionTorrentTrackerStats[] trackerStats)
        {
            Files = files;
            FileStats = fileStats;
            Peers = peers;
            PeersFrom = peersFrom;
            Trackers = trackers;
            TrackerStats = trackerStats;
        }

        public int Id { get; set; }
        public long ActivityDate { get; set; }
        public long AddedDate { get; set; }
        public Priority? BandwidthPriority { get; set; }
        public string Comment { get; set; }
        public int CorruptEver { get; set; }
        public string Creator { get; set; }
        public long DateCreated { get; set; }
        public long DesiredAvailable { get; set; }
        public long DoneDate { get; set; }
        public string DownloadDir { get; set; }
        public long DownloadedEver { get; set; }
        public int? DownloadLimit { get; set; }
        public bool? DownloadLimited { get; set; }
        public long EditDate { get; set; }
        public TorrentError Error { get; set; }
        public string ErrorString { get; set; }
        public int Eta { get; set; }
        public int EtaIdle { get; set; }
        public int FileCount { get; set; }
        public ITransmissionTorrentFile[] Files { get; set; }
        public ITransmissionTorrentFileStats[] FileStats { get; set; }
        public string HashString { get; set; }
        public int HaveUnchecked { get; set; }
        public long HaveValid { get; set; }
        public long Have => HaveUnchecked + HaveValid;
        public bool? HonorsSessionLimits { get; set; }
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
        public int? PeerLimit { get; set; }
        public ITransmissionTorrentPeers[] Peers { get; set; }
        public int PeersConnected { get; set; }
        public ITransmissionTorrentPeersFrom PeersFrom { get; set; }
        public int PeersGettingFromUs { get; set; }
        public int PeersSendingToUs { get; set; }
        public double PercentComplete { get; set; }
        public double PercentDone { get; set; }
        public string Pieces { get; set; }
        public int PieceCount { get; set; }
        public long PieceSize { get; set; }
        public Priority[] Priorities { get; set; }
        public string PrimaryMimeType { get; set; }
        public int? QueuePosition { get; set; }
        public int RateDownload { get; set; }
        public int RateUpload { get; set; }
        public double RecheckProgress { get; set; }
        public int SecondsDownloading { get; set; }
        public int SecondsSeeding { get; set; }
        public int? SeedIdleLimit { get; set; }
        public int? SeedIdleMode { get; set; }
        public double? SeedRatioLimit { get; set; }
        public int? SeedRatioMode { get; set; }
        public long SizeWhenDone { get; set; }
        public long StartDate { get; set; }
        public TorrentStatus Status { get; set; }
        public ITransmissionTorrentTracker[] Trackers { get; set; }
        public string TrackerList { get; set; }
        public ITransmissionTorrentTrackerStats[] TrackerStats { get; set; }
        public long TotalSize { get; set; }
        public string TorrentFile { get; set; }
        public long UploadedEver { get; set; }
        public int? UploadLimit { get; set; }
        public bool? UploadLimited { get; set; }
        public double UploadRatio { get; set; }
        public bool[] Wanted { get; set; }
        public string[] Webseeds { get; set; }
        public int WebseedsSendingToUs { get; set; }
    }

    public class TransmissionTorrentFile : ITransmissionTorrentFile
    {
        public long BytesCompleted { get; set; }
        public long Length { get; set; }
        public string Name { get; set; }
    }

    public class TransmissionTorrentFileStats : ITransmissionTorrentFileStats
    {
        public double BytesCompleted { get; set; }
        public bool Wanted { get; set; }
        public Priority Priority { get; set; }
    }

    public class TransmissionTorrentPeers : ITransmissionTorrentPeers
    {
        public string Address { get; set; }
        public string ClientName { get; set; }
        public bool ClientIsChoked { get; set; }
        public bool ClientIsInterested { get; set; }
        public string FlagStr { get; set; }
        public bool IsDownloadingFrom { get; set; }
        public bool IsEncrypted { get; set; }
        public bool IsUploadingTo { get; set; }
        public bool IsUTP { get; set; }
        public bool PeerIsChoked { get; set; }
        public bool PeerIsInterested { get; set; }
        public int Port { get; set; }
        public double Progress { get; set; }
        public int RateToClient { get; set; }
        public int RateToPeer { get; set; }
    }

    public class TransmissionTorrentPeersFrom : ITransmissionTorrentPeersFrom
    {
        public int FromDHT { get; set; }
        public int FromIncoming { get; set; }
        public int FromLPD { get; set; }
        public int FromLTEP { get; set; }
        public int FromPEX { get; set; }
        public int FromTracker { get; set; }
    }

    public class TransmissionTorrentTrackers : ITransmissionTorrentTracker
    {
        public string Announce { get; set; }
        public int Id { get; set; }
        public string Scrape { get; set; }
        public int Tier { get; set; }
    }

    public class TransmissionTorrentTrackerStats : ITransmissionTorrentTrackerStats
    {
        public string Announce { get; set; }
        public TrackerState AnnounceState { get; set; }
        public int DownloadCount { get; set; }
        public bool HasAnnounced { get; set; }
        public bool HasScraped { get; set; }
        public string Host { get; set; }
        public bool IsBackup { get; set; }
        public int LastAnnouncePeerCount { get; set; }
        public int Id { get; set; }
        public string LastAnnounceResult { get; set; }
        public bool LastAnnounceSucceeded { get; set; }
        public long LastAnnounceStartTime { get; set; }
        public string LastScrapeResult { get; set; }
        public bool LastAnnounceTimedOut { get; set; }
        public long LastAnnounceTime { get; set; }
        public bool LastScrapeSucceeded { get; set; }
        public int LastScrapeStartTime { get; set; }
        public bool LastScrapeTimedOut { get; set; }
        public int LastScrapeTime { get; set; }
        public string Scrape { get; set; }
        public int Tier { get; set; }
        public int LeecherCount { get; set; }
        public int NextAnnounceTime { get; set; }
        public int NextScrapeTime { get; set; }
        public TrackerState ScrapeState { get; set; }
        public int SeederCount { get; set; }
    }

    public class TransmissionTorrents : ITransmissionTorrents
    {
        public TorrentInfo[] Torrents { get; set; }
        public TorrentInfo[] Removed { get; set; }
    }
}
