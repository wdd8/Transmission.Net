using System.Text.Json.Serialization;
using Transmission.Net.Core.Entity;
using Transmission.Net.Core.Enums;
using Transmission.Net.Core.Util;

namespace Transmission.Net.Api.Entity.Torrent;

public class TorrentTrackerStats : ITorrentTrackerStats
{
    [JsonPropertyName("announce")]
    public string? Announce { get; set; }

    [JsonPropertyName("announce_state")]
    public TrackerState? AnnounceState { get; set; }

    [JsonPropertyName("download_count")]
    public int? DownloadCount { get; set; }

    [JsonPropertyName("has_announced")]
    public bool? HasAnnounced { get; set; }

    [JsonPropertyName("has_scraped")]
    public bool? HasScraped { get; set; }

    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("is_backup")]
    public bool? IsBackup { get; set; }

    [JsonPropertyName("last_announce_peer_count")]
    public int? LastAnnouncePeerCount { get; set; }

    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("last_announce_result")]
    public string? LastAnnounceResult { get; set; }

    [JsonPropertyName("last_announce_succeeded")]
    public bool? LastAnnounceSucceeded { get; set; }

    [JsonPropertyName("last_announce_start_time"), JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime? LastAnnounceStartTime { get; set; }

    [JsonPropertyName("last_scrape_result")]
    public string? LastScrapeResult { get; set; }

    [JsonPropertyName("last_announce_timed_out")]
    public bool? LastAnnounceTimedOut { get; set; }

    [JsonPropertyName("last_announce_time"), JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime? LastAnnounceTime { get; set; }

    [JsonPropertyName("last_scrape_succeeded")]
    public bool? LastScrapeSucceeded { get; set; }

    [JsonPropertyName("last_scrape_start_time"), JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime? LastScrapeStartTime { get; set; }

    [JsonPropertyName("last_scrape_timed_out")]
    public bool? LastScrapeTimedOut { get; set; }

    [JsonPropertyName("last_scrape_time"), JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime? LastScrapeTime { get; set; }

    [JsonPropertyName("scrape")]
    public string? Scrape { get; set; }

    [JsonPropertyName("tier")]
    public int? Tier { get; set; }

    [JsonPropertyName("leecher_count")]
    public int? LeecherCount { get; set; }

    [JsonPropertyName("next_announce_time"), JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime? NextAnnounceTime { get; set; }

    [JsonPropertyName("next_scrape_time"), JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime? NextScrapeTime { get; set; }

    [JsonPropertyName("scrape_state")]
    public TrackerState? ScrapeState { get; set; }

    [JsonPropertyName("seeder_count")]
    public int? SeederCount { get; set; }
}
