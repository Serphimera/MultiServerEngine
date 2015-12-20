using MultiServerEngine.Configuration.Interfaces;
using Photon.SocketServer.ServerToServer;

namespace MultiServerEngine.Peer.Server.Interfaces
{
    public interface IServerPeerFactory
    {
        T CreateServerPeer<T>(IConfiguration configuration) where T : ServerPeerBase;
    }
}