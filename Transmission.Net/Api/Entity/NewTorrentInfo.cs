using System.Text.Json.Serialization;

namespace Transmission.Net.Api.Entity;

/// <summary>
/// Information of added torrent
/// </summary>
public class NewTorrentInfo
{
    public NewTorrentInfo(int id, string name, string hashString)
    {
        Id = id;
        Name = name;
        HashString = hashString;
    }

    /// <summary>
    /// Torrent ID
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// Torrent name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Torrent Hash
    /// </summary>
    [JsonPropertyName("hash_string")]
    public string HashString { get; set; }

}
