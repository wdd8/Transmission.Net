using Transmission.API.RPC.Core.Entity;

namespace Transmission.API.RPC.Api.Entity.Torrent;

public class TorrentTracker : ITransmissionTorrentTracker
{
    public string Announce { get; set; }
    public int Id { get; set; }
    public string Scrape { get; set; }
    public int Tier { get; set; }
}
