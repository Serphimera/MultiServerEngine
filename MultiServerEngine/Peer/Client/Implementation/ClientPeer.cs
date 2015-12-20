using ExitGames.Logging;
using MultiServerEngine.Engine.Interfaces;
using MultiServerEngine.Peer.Client.Interfaces;
using Photon.SocketServer;
using PhotonHostRuntimeInterfaces;

namespace MultiServerEngine.Peer.Client.Implementation
{
    public class ClientPeer : PeerBase, IClientPeer
    {
        private ILogger Logger { get; set; }
        private IServerApplication ServerApplication { get; set; }

        public ClientPeer(InitRequest initRequest, ILogger logger, IServerApplication serverApplication)
            : base(initRequest)
        {
            Logger = logger;
            ServerApplication = serverApplication;
        }

        public ClientPeer(IRpcProtocol protocol, IPhotonPeer unmanagedPeer, ILogger logger,
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