using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiServerEngine.Peer.Server.Interfaces
{
    public interface IServerPeerList
    {
        Dictionary<IServerType, IServerPeer> PeerList { get; set; }
        bool AddServer(IServerType type, IServerPeer serverPeer);
        IServerPeer GetServerForType(IServerType type);
    }
}
