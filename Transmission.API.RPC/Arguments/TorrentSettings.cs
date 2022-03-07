using Transmission.API.RPC.Common;

namespace Transmission.API.RPC.Arguments
{
    /// <summary>
    /// Torrent settings
    /// </summary>
    public class TorrentSettings : ArgumentsBase
    {
        /// <summary>
        /// This torrent's bandwidth tr_priority_t
        /// </summary>
        public int? BandwidthPriority { get => GetValue<int?>("bandwidthPriority"); set => this["bandwidthPriority"] = value; }

        /// <summary>
        /// Maximum download speed (KBps)
        /// </summary>
        public int? DownloadLimit { get => GetValue<int?>("downloadLimit"); set => this["downloadLimit"] = value; }

        /// <summary>
        /// Download limit is honored
        /// </summary>
        public bool? DownloadLimited { get => GetValue<bool?>("downloadLimited"); set => this["downloadLimited"] = value; }

        /// <summary>
        /// Session upload limits are honored
        /// </summary>
        public bool? HonorsSessionLimits { get => GetValue<bool?>("honorsSessionLimits"); set => this["honorsSessionLimits"] = value; }

        /// <summary>
        /// Torrent id array
        /// </summary>
        public object[] IDs { get => GetValue<object[]>("ids"); set => this["ids"] = value; }

        /// <summary>
        /// New location of the torrent's content
        /// </summary>
        public string Location { get => GetValue<string>("location"); set => this["location"] = value; }

        /// <summary>
        /// Maximum number of peers
        /// </summary>
        public int? PeerLimit { get => GetValue<int?>("peer-limit"); set => this["peer-limit"] = value; }

        /// <summary>
        /// Position of this torrent in its queue [0...n)
        /// </summary>
        public int? QueuePosition { get => GetValue<int?>("queuePosition"); set => this["queuePosition"] = value; }

        /// <summary>
        /// Torrent-level number of minutes of seeding inactivity
        /// </summary>
        public int? SeedIdleLimit { get => GetValue<int?>("seedIdleLimit"); set => this["seedIdleLimit"] = value; }

        /// <summary>
        /// Which seeding inactivity to use
        /// </summary>
        public int? SeedIdleMode { get => GetValue<int?>("seedIdleMode"); set => this["seedIdleMode"] = value; }

        /// <summary>
        /// Torrent-level seeding ratio
        /// </summary>
        public double? SeedRatioLimit { get => GetValue<double?>("seedRatioLimit"); set => this["seedRatioLimit"] = value; }

        /// <summary>
        /// Which ratio to use. 
        /// </summary>
        public int? SeedRatioMode { get => GetValue<int?>("seedRatioMode"); set => this["seedRatioMode"] = value; }

        /// <summary>
        /// Maximum upload speed (KBps)
        /// </summary>
        public int? UploadLimit { get => GetValue<int?>("uploadLimit"); set => this["uploadLimit"] = value; }

        /// <summary>
        /// Upload limit is honored
        /// </summary>
        public bool? UploadLimited { get => GetValue<bool?>("uploadLimited"); set => this["uploadLimited"] = value; }

        /// <summary>
        /// Strings of announce URLs to add
        /// </summary>
        [Obsolete("TrackerAdd is obsolete since Transmission 4.0.0, use TrackerList instead.")]
        public string[] TrackerAdd { get => GetValue<string[]>("trackerAdd"); set => this["trackerAdd"] = value; }

        /// <summary>
        /// Ids of trackers to remove
        /// </summary>
        [Obsolete("TrackerRemove is obsolete since Transmission 4.0.0, use TrackerList instead.")]
        public int[] TrackerRemove { get => GetValue<int[]>("trackerRemove"); set => this["trackerRemove"] = value; }

        /// <summary>
        /// String of announce URLs, one per line, with a blank line between tiers
        /// </summary>
        public string[] TrackerList { get => GetValue<string[]>("trackerList"); set => this["trackerAdd"] = value; }

        /// <summary>
        /// Files wanted
        /// </summary>
        public string[] FilesWanted { get => GetValue<string[]>("files-wanted"); set => this["files-wanted"] = value; }

        /// <summary>
        /// Files unwanted
        /// </summary>
        public string[] FilesUnwanted { get => GetValue<string[]>("files-unwanted"); set => this["files-unwanted"] = value; }

        /// <summary>
        /// High priority files
        /// </summary>
        public string[] PriorityHigh { get => GetValue<string[]>("priority-high"); set => this["priority-high"] = value; }

        /// <summary>
        /// Low priority files
        /// </summary>
        public string[] PriorityLow { get => GetValue<string[]>("priority-low"); set => this["priority-low"] = value; }

        /// <summary>
        /// Normal priority files
        /// </summary>
        public string[] PriorityNormal { get => GetValue<string[]>("priority-normal"); set => this["priority-normal"] = value; }

        //TODO: Add and test
        //"trackerReplace"      | array      pairs of <trackerId/new announce URLs>
        //public [] trackerReplace;

    }
}
