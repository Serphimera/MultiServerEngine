using MultiServerEngine.Configuration.Interfaces;
using MultiServerEngine.Peer.Server.Interfaces;
using Photon.SocketServer;
using Photon.SocketServer.ServerToServer;

namespace MultiServerEngine.Peer.Server.Implementation
{
    public class ServerPeerFactory : IServerPeerFactory
    {
        public T CreateServerPeer<T>(IServerConfiguration configuration) where T : ServerPeerBase
        {
            InitResponse initResponse = configuration.GetConfiguration<InitResponse>();
            return new ServerPeer(initResponse.Protocol, initResponse.PhotonPeer) as T;
        }
    }
}