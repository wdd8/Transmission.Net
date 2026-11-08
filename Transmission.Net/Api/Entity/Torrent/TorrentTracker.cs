using System.Text.Json.Serialization;
using Transmission.Net.Core.Entity;

namespace Transmission.Net.Api.Entity.Torrent;

public class TorrentTracker : ITorrentTracker
{
    [JsonConstructor]
    internal TorrentTracker(string announce, int id, string scrape, int tier)
    {
        Announce = announce;
        Id = id;
        Scrape = scrape;
        Tier = tier;
    }

    [JsonPropertyName("announce")]
    public string Announce { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("scrape")]
    public string Scrape { get; set; }

    [JsonPropertyName("tier")]
    public int Tier { get; set; }
}
