using System.Collections.Generic;

namespace MultiServerEngine.Peer.Server.Interfaces
{
    public interface IServerPeerList
    {
        Dictionary<IServerType, IServerPeer> PeerList { get; set; }
        bool AddServer(IServerType type, IServerPeer serverPeer);
        IServerPeer GetServerForType(IServerType type);
    }
}