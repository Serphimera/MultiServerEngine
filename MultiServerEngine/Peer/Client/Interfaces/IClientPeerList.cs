using System;
using System.Collections.Generic;

namespace MultiServerEngine.Peer.Client.Interfaces
{
    public interface IClientPeerList
    {
        Dictionary<Guid, IClientPeer> PeerList { get; set; }
        bool AddClientPeer(IClientPeer clientPeer);
        IClientPeer GetClientPeer(Guid peerId);
    }
}