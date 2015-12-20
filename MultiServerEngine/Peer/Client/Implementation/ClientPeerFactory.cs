using ExitGames.Logging;
using MultiServerEngine.Configuration.Interfaces;
using MultiServerEngine.Engine.Interfaces;
using MultiServerEngine.Peer.Client.Interfaces;
using Photon.SocketServer;

namespace MultiServerEngine.Peer.Client.Implementation
{
    public class ClientPeerFactory : IClientPeerFactory
    {
        private ILogger Logger { get; }
        private IServerApplication ServerApplication { get; }

        public ClientPeerFactory(ILogger logger, IServerApplication serverApplication)
        {
            Logger = logger;
            ServerApplication = serverApplication;
        }

        public T CreateClientPeer<T>(IConfiguration configuration) where T : PeerBase
        {
            return new ClientPeer(configuration.GetConfiguration<InitRequest>(), Logger, ServerApplication) as T;
        }
    }
}