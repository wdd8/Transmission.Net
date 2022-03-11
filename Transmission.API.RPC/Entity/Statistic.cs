using Newtonsoft.Json;

namespace Transmission.API.RPC.Entity
{
    /// <summary>
    /// Statistic
    /// </summary>
    public class Statistic
    {
        /// <summary>
        /// Active torrent count
        /// </summary>
        [JsonProperty("activeTorrentCount")]
        public int ActiveTorrentCount { get; set; }

        /// <summary>
        /// Download speed
        /// </summary>
        [JsonProperty("downloadSpeed")]
        public int DownloadSpeed { get; set; }

        /// <summary>
        /// Paused torrent count
        /// </summary>
        [JsonProperty("pausedTorrentCount")]
        public int PausedTorrentCount { get; set; }

        /// <summary>
        /// Torrent count
        /// </summary>
        [JsonProperty("torrentCount")]
        public int TorrentCount { get; set; }

        /// <summary>
        /// Upload speed
        /// </summary>
        [JsonProperty("uploadSpeed")]
        public int UploadSpeed { get; set; }

        /// <summary>
        /// Cumulative stats
        /// </summary>
        [JsonProperty("cumulative-stats")]
        public CommonStatistic CumulativeStats { get; set; }

        /// <summary>
        /// Current stats
        /// </summary>
        [JsonProperty("current-stats")]
        public CommonStatistic CurrentStats { get; set; }
    }

    /// <summary>
    /// Common statistic
    /// </summary>
    public class CommonStatistic
    {
        /// <summary>
        /// Uploaded bytes
        /// </summary>
        [JsonProperty("uploadedBytes")]
        public double UploadedBytes { get; set; }

        /// <summary>
        /// Downloaded bytes
        /// </summary>
        [JsonProperty("downloadedBytes")]
        public double DownloadedBytes { get; set; }

        /// <summary>
        /// Files added
        /// </summary>
        [JsonProperty("filesAdded")]
        public int FilesAdded { get; set; }

        /// <summary>
        /// Session count
        /// </summary>
        [JsonProperty("SessionCount")]
        public int SessionCount { get; set; }

        /// <summary>
        /// Seconds active
        /// </summary>
        [JsonProperty("SecondsActive")]
        public int SecondsActive { get; set; }
    }
}
