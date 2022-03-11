using Transmission.API.RPC.Core.Entity.Torrent;
using Transmission.API.RPC.Core.Enums;

namespace Transmission.API.RPC.Api.Entity.Torrent;

public class TorrentFileStats : ITorrentFileStats
{
    public double BytesCompleted { get; set; }
    public bool Wanted { get; set; }
    public Priority Priority { get; set; }
}
