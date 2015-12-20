using MultiServerEngine.Configuration.Interfaces;
using MultiServerEngine.Peer.Client.Interfaces;
using Photon.SocketServer;

namespace MultiServerEngine.Peer.Client.Implementation
{
    public class ClientPeerFactory : IClientPeerFactory
    {
        public T CreateClientPeer<T>(IServerConfiguration configuration) where T : PeerBase
        {
            return new ClientPeer(configuration.GetConfiguration<InitRequest>()) as T;
        }
    }
}