namespace Transmission.Net.Core.Entity.Torrent;

public interface ITorrentFile
{
    /// <summary>
    /// The current size of the file, i.e. how much we've downloaded
    /// </summary>
    long? BytesCompleted { get; set; }

    /// <summary>
    /// The total size of the file
    /// </summary>
    long? Length { get; set; }

    /// <summary>
    /// This file's name. Includes the full subpath in the torrent.
    /// </summary>
    string? Name { get; set; }

    /// <summary>
    /// Starting piece index
    /// </summary>
    long? BeginPiece { get; set; }

    /// <summary>
    /// Ending piece index
    /// </summary>
    long? EndPiece { get; set; }
}
