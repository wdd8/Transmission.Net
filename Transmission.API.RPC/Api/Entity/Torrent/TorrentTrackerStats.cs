using Transmission.API.RPC.Core.Entity;
using Transmission.API.RPC.Core.Enums;

namespace Transmission.API.RPC.Api.Entity.Torrent;

public class TorrentTrackerStats : ITorrentTrackerStats
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
