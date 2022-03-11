using Transmission.API.RPC.Core.Entity.Torrent;

namespace Transmission.API.RPC.Api.Entity.Torrent;

public class TorrentPeersFrom : ITorrentPeersFrom
{
    public int FromDHT { get; set; }
    public int FromIncoming { get; set; }
    public int FromLPD { get; set; }
    public int FromLTEP { get; set; }
    public int FromPEX { get; set; }
    public int FromTracker { get; set; }
}
