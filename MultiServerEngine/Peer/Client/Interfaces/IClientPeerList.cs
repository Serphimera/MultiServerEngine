using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiServerEngine.Peer.Client.Interfaces
{
    public interface IClientPeerList
    {
        Dictionary<Guid, IClientPeer> PeerList { get; set; }
        bool AddClientPeer(IClientPeer clientPeer);
        IClientPeer GetClientPeer(Guid peerId);
    }
}
