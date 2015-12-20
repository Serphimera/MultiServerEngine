using ExitGames.Logging;
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

        public ServerPeer(IRpcProtocol protocol, IPhotonPeer unmanagedPeer, ILogger logger,
            IServerApplication serverApplication) : base(protocol, unmanagedPeer)
        {
            Logger = logger;
            ServerApplication = serverApplication;
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