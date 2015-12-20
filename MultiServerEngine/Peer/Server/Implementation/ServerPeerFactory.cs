using ExitGames.Logging;
using MultiServerEngine.Configuration.Interfaces;
using MultiServerEngine.Engine.Interfaces;
using MultiServerEngine.Peer.Server.Interfaces;
using Photon.SocketServer;
using Photon.SocketServer.ServerToServer;

namespace MultiServerEngine.Peer.Server.Implementation
{
    public class ServerPeerFactory : IServerPeerFactory
    {
        private ILogger Logger { get; }
        private IServerApplication ServerApplication { get; }

        public ServerPeerFactory(ILogger logger, IServerApplication serverApplication)
        {
            Logger = logger;
            ServerApplication = serverApplication;
        }

        public T CreateServerPeer<T>(IConfiguration configuration) where T : ServerPeerBase
        {
            InitResponse initResponse = configuration.GetConfiguration<InitResponse>();
            return new ServerPeer(initResponse.Protocol, initResponse.PhotonPeer, Logger, ServerApplication) as T;
        }
    }
}