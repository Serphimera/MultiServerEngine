using MultiServerEngine.Configuration.Interfaces;
using Photon.SocketServer;

namespace MultiServerEngine.Peer.Client.Interfaces
{
    public interface IClientPeerFactory
    {
        T CreateClientPeer<T>(IServerConfiguration configuration) where T : PeerBase;
    }
}