using Transmission.Net.Api;
using Transmission.Net.Api.Entity;
using Transmission.Net.Api.Entity.Session;
using Transmission.Net.Arguments;

namespace Transmission.Net.Core;

/// <summary>
/// Interface for transmission client
/// </summary>
public interface ITransmissionClient
{
    /// <summary>
    /// Current tag
    /// </summary>
    int CurrentTag { get; }

    /// <summary>
    /// Session ID
    /// </summary>
    string? SessionID { get; }

    /// <summary>
    /// Host url
    /// </summary>
    string Url { get; }


    /// <summary>
    /// Update blocklist (API: blocklist-update)
    /// </summary>
    /// <returns>Blocklist size</returns>
    Task<int?> BlocklistUpdateAsync();

    /// <summary>
    /// Close current session (API: session-close)
    /// </summary>
    Task CloseSessionAsync();

    /// <summary>
    /// Get free space is available in a client-specified folder.
    /// </summary>
    /// <param name="path">The directory to query</param>
    Task<long?> FreeSpaceAsync(string path);

    /// <summary>
    /// Get information of current session (API: session-get)
    /// </summary>
    /// <returns>Session information</returns>
    Task<SessionInfo?> GetSessionInformationAsync();

    /// <summary>
    /// Get session stat
    /// </summary>
    /// <returns>Session stat</returns>
    Task<Stats?> GetSessionStatisticAsync();

    /// <summary>
    /// See if your incoming peer port is accessible from the outside world (API: port-test)
    /// </summary>
    /// <returns>Accessible state</returns>
    Task<bool?> PortTestAsync();

    /// <summary>
    /// Set information to current session (API: session-set)
    /// </summary>
    /// <param name="settings">New session settings</param>
    Task SetSessionSettingsAsync(SessionSettings settings);

    /// <summary>
    /// Add torrent (API: torrent-add)
    /// </summary>
    /// <returns>Torrent info (ID, Name and HashString)</returns>
    Task<NewTorrentInfo?> TorrentAddAsync(NewTorrent torrent);

    /// <summary>
    /// Get <paramref name="fields"/> of torrents from <paramref name="ids"/> (API: torrent-get)
    /// </summary>
    /// <param name="ids">IDs of torrents (<see langword="null"/> or empty for get all torrents)</param>
    /// <param name="fields">Fields of torrents (empty for <see cref="TorrentFields.ALL_FIELDS"/>)</param>
    /// <returns>Torrents info</returns>
    Task<TorrentsResult?> TorrentGetAsync(int[]? ids = null, params string[] fields);

    /// <summary>
    /// Move torrents to bottom in queue  (API: queue-move-bottom)
    /// </summary>
    /// <param name="ids"></param>
    Task TorrentQueueMoveBottomAsync(int[] ids);

    /// <summary>
    /// Move down torrents in queue (API: queue-move-down)
    /// </summary>
    /// <param name="ids"></param>
    Task TorrentQueueMoveDownAsync(int[] ids);

    /// <summary>
    /// Move torrents in queue on top (API: queue-move-top)
    /// </summary>
    /// <param name="ids">Torrents id</param>
    Task TorrentQueueMoveTopAsync(int[] ids);

    /// <summary>
    /// Move up torrents in queue (API: queue-move-up)
    /// </summary>
    /// <param name="ids"></param>
    Task TorrentQueueMoveUpAsync(int[] ids);

    /// <summary>
    /// Remove torrents
    /// </summary>
    /// <param name="ids">Torrents id</param>
    /// <param name="deleteData">Remove local data</param>
    Task TorrentRemoveAsync(int[] ids, bool deleteData = false);

    /// <summary>
    /// Rename a file or directory in a torrent (API: torrent-rename-path)
    /// </summary>
    /// <param name="id">The torrent whose path will be renamed</param>
    /// <param name="path">The path to the file or folder that will be renamed</param>
    /// <param name="name">The file or folder's new name</param>
    Task<RenameTorrentInfo?> TorrentRenamePathAsync(int id, string path, string name);

    /// <summary>
    /// Set torrent params (API: torrent-set)
    /// </summary>
    /// <param name="settings">Torrent settings</param>
    Task TorrentSetAsync(TorrentSettings settings);

    /// <summary>
    /// Set new location for torrents files (API: torrent-set-location)
    /// </summary>
    /// <param name="ids">Torrent ids</param>
    /// <param name="location">The new torrent location</param>
    /// <param name="move">Move from previous location</param>
    Task TorrentSetLocationAsync(int[] ids, string location, bool move);

    /// <summary>
    /// Start recently active torrents (API: torrent-start)
    /// </summary>
    Task TorrentStartAsync();

    /// <summary>
    /// Start torrents (API: torrent-start)
    /// </summary>
    /// <param name="ids">A list of torrent id numbers, sha1 hash strings, or both</param>
    Task TorrentStartAsync(object[] ids);

    /// <summary>
    /// Start now recently active torrents (API: torrent-start-now)
    /// </summary>
    Task TorrentStartNowAsync();

    /// <summary>
    /// Start now torrents (API: torrent-start-now)
    /// </summary>
    /// <param name="ids">A list of torrent id numbers, sha1 hash strings, or both</param>
    Task TorrentStartNowAsync(object[] ids);

    /// <summary>
    /// Stop recently active torrents (API: torrent-stop)
    /// </summary>
    Task TorrentStopAsync();

    /// <summary>
    /// Stop torrents (API: torrent-stop)
    /// </summary>
    /// <param name="ids">A list of torrent id numbers, sha1 hash strings, or both</param>
    Task TorrentStopAsync(object[] ids);

    /// <summary>
    /// Verify recently active torrents (API: torrent-verify)
    /// </summary>
    Task TorrentVerifyAsync();

    /// <summary>
    /// Verify torrents (API: torrent-verify)
    /// </summary>
    /// <param name="ids">A list of torrent id numbers, sha1 hash strings, or both</param>
    Task TorrentVerifyAsync(object[] ids);
}
