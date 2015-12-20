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
            if (configuration.GetConfiguration<InitResponse>() != null)
            {
                Logger.InfoFormat("Received request for creating a server peer");
                InitResponse initResponse = configuration.GetConfiguration<InitResponse>();
                return new ServerPeer(initResponse.Protocol, initResponse.PhotonPeer, Logger, ServerApplication, configuration) as T;
            }

            if (configuration.GetConfiguration<InitRequest>() != null)
            {
                Logger.InfoFormat("Received request for creating a subserver peer");
                InitRequest initRequest = configuration.GetConfiguration<InitRequest>();
                return new ServerPeer(initRequest.Protocol, initRequest.PhotonPeer, Logger, ServerApplication, configuration) as T;
            }

            return null;
        }
    }
}