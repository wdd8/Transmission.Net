using Newtonsoft.Json;

namespace Transmission.Net.Api.Entity;

/// <summary>
/// Information of added torrent
/// </summary>
public class NewTorrentInfo
{
    public NewTorrentInfo(int id, string name, [JsonProperty("hash_string")] string hashString)
    {
        Id = id;
        Name = name;
        HashString = hashString;
    }

    /// <summary>
    /// Torrent ID
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// Torrent name
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// Torrent Hash
    /// </summary>
    [JsonProperty("hash_string")]
    public string HashString { get; set; }

}
