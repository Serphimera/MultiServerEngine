using MultiServerEngine.Configuration.Interfaces;
using Photon.SocketServer;

namespace MultiServerEngine.Peer.Client.Interfaces
{
    public interface IClientPeerFactory
    {
        T CreateClientPeer<T>(IConfiguration configuration) where T : PeerBase;
    }
}