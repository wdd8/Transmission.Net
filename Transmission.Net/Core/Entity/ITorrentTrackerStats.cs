using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Transmission.Net.Core.Enums;

namespace Transmission.Net.Core.Entity;

/// <summary>
/// Torrent tracker stats
/// </summary>
public interface ITorrentTrackerStats
{
    /// <inheritdoc cref="ITorrentTracker.Announce"/>
    [JsonProperty("announce")]
    string? Announce { get; set; }

    /// <inheritdoc cref="ITorrentTracker.Scrape"/>
    [JsonProperty("scrape")]
    string? Scrape { get; set; }

    /// <summary>
    /// Uniquely-identifying tracker name ({host}:{port})
    /// </summary>
    [JsonProperty("host")]
    string? Host { get; set; }


    /// <summary>
    /// If <see cref="HasAnnounced"/>, the human-readable result of latest announce
    /// </summary>
    [JsonProperty("last_announce_result")]
    string? LastAnnounceResult { get; set; }

    /// <summary>
    /// If <see cref="HasScraped"/>, the human-readable result of the latest scrape
    /// </summary>
    [JsonProperty("last_scrape_result")]
    string? LastScrapeResult { get; set; }


    /// <summary>
    /// If <see cref="HasAnnounced"/>, when the latest announce request was sent
    /// </summary>
    [JsonProperty("last_announce_start_time"), JsonConverter(typeof(UnixDateTimeConverter))]
    DateTime? LastAnnounceStartTime { get; set; }

    /// <summary>
    /// If <see cref="HasAnnounced"/>, when the latest announce reply was received
    /// </summary>
    [JsonProperty("last_announce_time"), JsonConverter(typeof(UnixDateTimeConverter))]
    DateTime? LastAnnounceTime { get; set; }

    /// <summary>
    /// If <see cref="AnnounceState"/> == <see cref="TrackerState.Waiting"/>, time of next announce
    /// </summary>
    [JsonProperty("next_announce_time"), JsonConverter(typeof(UnixDateTimeConverter))]
    DateTime? NextAnnounceTime { get; set; }

    /// <summary>
    /// If <see cref="HasScraped"/>, when the latest scrape request was sent
    /// </summary>
    [JsonProperty("last_scrape_start_time"), JsonConverter(typeof(UnixDateTimeConverter))]
    DateTime? LastScrapeStartTime { get; set; }

    /// <summary>
    /// If <see cref="HasScraped"/>, when the latest scrape reply was received
    /// </summary>
    [JsonProperty("last_scrape_time"), JsonConverter(typeof(UnixDateTimeConverter))]
    DateTime? LastScrapeTime { get; set; }

    /// <summary>
    /// If <see cref="ScrapeState"/> == <see cref="TrackerState.Waiting"/>, time of next scrape
    /// </summary>
    [JsonProperty("next_scrape_time"), JsonConverter(typeof(UnixDateTimeConverter))]
    DateTime? NextScrapeTime { get; set; }


    /// <summary>
    /// Number of times this torrent's been downloaded, or -1 if unknown
    /// </summary>
    [JsonProperty("download_count")]
    int? DownloadCount { get; set; }

    /// <summary>
    /// If <see cref="HasAnnounced"/>, the number of peers the tracker gave us
    /// </summary>
    [JsonProperty("last_announce_peer_count")]
    int? LastAnnouncePeerCount { get; set; }

    /// <summary>
    /// Number of leechers the tracker knows of, or -1 if unknown
    /// </summary>
    [JsonProperty("leecher_count")]
    int? LeecherCount { get; set; }

    /// <summary>
    /// Number of seeders the tracker knows of, or -1 if unknown
    /// </summary>
    [JsonProperty("seeder_count")]
    int? SeederCount { get; set; }


    /// <inheritdoc cref="ITorrentTracker.Tier"/>
    [JsonProperty("tier")]
    int? Tier { get; set; }

    /// <inheritdoc cref="ITorrentTracker.Id"/>
    [JsonProperty("id")]
    int? Id { get; set; }


    /// <summary>
    /// Whether we're announcing, waiting to announce, etc.
    /// </summary>
    [JsonProperty("announce_state")]
    TrackerState? AnnounceState { get; set; }

    /// <summary>
    /// Whether we're scraping, waiting to scrape, etc.
    /// </summary>
    [JsonProperty("scrape_state")]
    TrackerState? ScrapeState { get; set; }


    /// <summary>
    /// <see langword="true"/> if we've announced to this tracker during this session
    /// </summary>
    [JsonProperty("has_announced")]
    bool? HasAnnounced { get; set; }

    /// <summary>
    /// <see langword="true"/> if we've scraped this tracker during this session
    /// </summary>
    [JsonProperty("has_scraped")]
    bool? HasScraped { get; set; }

    /// <summary>
    /// Only one tracker per tier is used; the others are kept as backups
    /// </summary>
    [JsonProperty("is_backup")]
    bool? IsBackup { get; set; }

    /// <summary>
    /// If <see cref="HasAnnounced"/>, whether or not the latest announce succeeded
    /// </summary>
    [JsonProperty("last_announce_succeeded")]
    bool? LastAnnounceSucceeded { get; set; }

    /// <summary>
    /// <see langword="true"/> if the latest announce request timed out
    /// </summary>
    [JsonProperty("last_announce_timed_out")]
    bool? LastAnnounceTimedOut { get; set; }

    /// <summary>
    /// If <see cref="HasScraped"/>, whether or not the latest scrape succeeded
    /// </summary>
    [JsonProperty("last_scrape_succeeded")]
    bool? LastScrapeSucceeded { get; set; }

    /// <summary>
    /// <see langword="true"/> if the latest scrape request timed out
    /// </summary>
    [JsonProperty("last_scrape_timed_out")]
    bool? LastScrapeTimedOut { get; set; }
}
