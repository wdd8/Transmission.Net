using System.Text.Json.Serialization;
using Transmission.Net.Api.Entity;
using Transmission.Net.Api.Entity.Session;
using Transmission.Net.Api.Entity.Torrent;
using Transmission.Net.Core.Entity;
using Transmission.Net.Core.Entity.Torrent;
using Transmission.Net.Core.Enums;
using Transmission.Net.Core.Util;

namespace Transmission.Net.Api;

[JsonSourceGenerationOptions(Converters = new[]
{
    typeof(ConcreteTypeConverter<ITorrentFile, TorrentFile>),
    typeof(ConcreteTypeConverter<ITorrentFileStats, TorrentFileStats>),
    typeof(ConcreteTypeConverter<ITorrentPeers, TorrentPeers>),
    typeof(ConcreteTypeConverter<ITorrentPeersFrom, TorrentPeersFrom>),
    typeof(ConcreteTypeConverter<ITorrentTracker, TorrentTracker>),
    typeof(ConcreteTypeConverter<ITorrentTrackerStats, TorrentTrackerStats>)
})]
[JsonSerializable(typeof(TransmissionRequest))]
[JsonSerializable(typeof(TransmissionResponse))]
[JsonSerializable(typeof(Stats))]
[JsonSerializable(typeof(SessionInfo))]
[JsonSerializable(typeof(NewTorrentInfo))]
[JsonSerializable(typeof(RenameTorrentInfo))]
[JsonSerializable(typeof(TorrentsResult))]
// Targets of ConcreteTypeConverter
[JsonSerializable(typeof(TorrentFile))]
[JsonSerializable(typeof(TorrentFileStats))]
[JsonSerializable(typeof(TorrentPeers))]
[JsonSerializable(typeof(TorrentPeersFrom))]
[JsonSerializable(typeof(TorrentTracker))]
[JsonSerializable(typeof(TorrentTrackerStats))]
// Runtime types of the object values in TransmissionRequest.Parameters
[JsonSerializable(typeof(string))]
[JsonSerializable(typeof(string[]))]
[JsonSerializable(typeof(int))]
[JsonSerializable(typeof(int[]))]
[JsonSerializable(typeof(long))]
[JsonSerializable(typeof(bool))]
[JsonSerializable(typeof(double))]
[JsonSerializable(typeof(object[]))]
[JsonSerializable(typeof(Priority))]
[JsonSerializable(typeof(Units))]
internal partial class TransmissionJsonContext : JsonSerializerContext;
