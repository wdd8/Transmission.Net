using Transmission.Net.Core.Enums;

namespace Transmission.Net.Core.Entity.Torrent;

public interface ITorrentFileStats
{
    /// <summary>
    /// <inheritdoc cref="ITorrentFile.BytesCompleted"/>
    /// </summary>
    double BytesCompleted { get; set; }

    /// <summary>
    /// Do we want this file?
    /// </summary>
    bool Wanted { get; set; }

    /// <summary>
    /// The file's priority
    /// </summary>
    Priority Priority { get; set; }
}
