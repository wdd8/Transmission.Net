﻿using Newtonsoft.Json;

namespace Transmission.API.RPC.Core.Entity;

/// <summary>
/// Torrent trackers
/// </summary>
public interface ITransmissionTorrentTracker
{
    /// <summary>
    /// Full announce URL
    /// </summary>
    [JsonProperty("announce")]
    public string Announce { get; set; }

    /// <summary>
    /// Full scrape URL
    /// </summary>
    [JsonProperty("scrape")]
    public string Scrape { get; set; }

    /// <summary>
    /// Unique transmission-generated ID for use in libtransmission API
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// Which tier this tracker is in
    /// </summary>
    [JsonProperty("tier")]
    public int Tier { get; set; }
}