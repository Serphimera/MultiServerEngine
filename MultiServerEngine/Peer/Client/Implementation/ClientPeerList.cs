using System;
using System.Collections.Generic;
using MultiServerEngine.Peer.Client.Interfaces;

namespace MultiServerEngine.Peer.Client.Implementation
{
    public class ClientPeerList : IClientPeerList
    {
        public Dictionary<Guid, IClientPeer> PeerList { get; set; }

        public bool AddClientPeer(IClientPeer clientPeer)
        {
            throw new NotImplementedException();
        }

        public IClientPeer GetClientPeer(Guid peerId)
        {
            throw new NotImplementedException();
        }
    }
}