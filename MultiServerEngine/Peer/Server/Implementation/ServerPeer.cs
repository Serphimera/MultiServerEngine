using ExitGames.Logging;
using MultiServerEngine.Configuration.Interfaces;
using MultiServerEngine.Engine.Interfaces;
using MultiServerEngine.Peer.Server.Interfaces;
using Photon.SocketServer;
using Photon.SocketServer.ServerToServer;
using PhotonHostRuntimeInterfaces;

namespace MultiServerEngine.Peer.Server.Implementation
{
    public class ServerPeer : ServerPeerBase, IServerPeer
    {
        private ILogger Logger { get; set; }
        private IServerApplication ServerApplication { get; set; }
        private IConfiguration Configuration { get; set; }

        public ServerPeer(IRpcProtocol protocol, IPhotonPeer unmanagedPeer, ILogger logger,
            IServerApplication serverApplication, IConfiguration configuration) : base(protocol, unmanagedPeer)
        {
            Logger = logger;
            ServerApplication = serverApplication;
            Configuration = configuration;

            Logger.InfoFormat("Server peer created for {0} on local ip {1}:{2} connected to remote ip {3}:{4} - {5}",
                Configuration.GetConfiguration<InitResponse>() != null
                    ? Configuration.GetConfiguration<InitResponse>().ApplicationId
                    : Configuration.GetConfiguration<InitRequest>().ApplicationId
                , Configuration.GetConfiguration<InitResponse>() != null
                    ? Configuration.GetConfiguration<InitResponse>().LocalIP
                    : Configuration.GetConfiguration<InitRequest>().LocalIP,
                Configuration.GetConfiguration<InitResponse>() != null
                    ? Configuration.GetConfiguration<InitResponse>().LocalPort
                    : Configuration.GetConfiguration<InitRequest>().LocalPort,
                Configuration.GetConfiguration<InitResponse>() != null
                    ? Configuration.GetConfiguration<InitResponse>().RemoteIP
                    : Configuration.GetConfiguration<InitRequest>().RemoteIP,
                Configuration.GetConfiguration<InitResponse>() != null
                    ? Configuration.GetConfiguration<InitResponse>().RemotePort
                    : Configuration.GetConfiguration<InitRequest>().RemotePort,
                unmanagedPeer.GetUserData());
        }

        protected override void OnOperationRequest(OperationRequest operationRequest, SendParameters sendParameters)
        {
        }

        protected override void OnDisconnect(DisconnectReason reasonCode, string reasonDetail)
        {
        }

        protected override void OnEvent(IEventData eventData, SendParameters sendParameters)
        {
        }

        protected override void OnOperationResponse(OperationResponse operationResponse, SendParameters sendParameters)
        {
        }

        public bool Register()
        {
            if (LocalPort == (Configuration.GetConfiguration<InitResponse>() != null
                ? Configuration.GetConfiguration<InitResponse>().LocalPort
                : Configuration.GetConfiguration<InitRequest>().LocalPort))
            {
                Logger.ErrorFormat("Cannot register to self!");
                return false;
            }

            return true;

        }

        public bool Connect()
        {
            return true;
        }

        public new bool Disconnect()
        {
            base.Disconnect();
            return true;
        }
    }
}