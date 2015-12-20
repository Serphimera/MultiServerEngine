using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiServerEngine.Configuration.Interfaces;
using Photon.SocketServer;

namespace MultiServerEngine.Peer.Client.Interfaces
{
    public interface IClientPeerFactory
    {
        T CreateClientPeer<T>(IConfiguration configuration) where T : PeerBase;
    }
}
