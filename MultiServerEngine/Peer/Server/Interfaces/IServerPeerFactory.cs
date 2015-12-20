using MultiServerEngine.Configuration.Interfaces;
using Photon.SocketServer.ServerToServer;

namespace MultiServerEngine.Peer.Server.Interfaces
{
    public interface IServerPeerFactory
    {
        T CreateServerPeer<T>(IServerConfiguration configuration) where T : ServerPeerBase;
    }
}