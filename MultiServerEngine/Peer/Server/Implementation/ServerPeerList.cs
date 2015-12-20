using System;
using System.Collections.Generic;
using MultiServerEngine.Peer.Server.Interfaces;

namespace MultiServerEngine.Peer.Server.Implementation
{
    public class ServerPeerList : IServerPeerList
    {
        public Dictionary<IServerType, IServerPeer> PeerList { get; set; }

        public bool AddServer(IServerType type, IServerPeer serverPeer)
        {
            throw new NotImplementedException();
        }

        public IServerPeer GetServerForType(IServerType type)
        {
            throw new NotImplementedException();
        }
    }
}