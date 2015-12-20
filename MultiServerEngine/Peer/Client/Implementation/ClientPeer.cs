using System;
using MultiServerEngine.Peer.Client.Interfaces;
using Photon.SocketServer;
using PhotonHostRuntimeInterfaces;

namespace MultiServerEngine.Peer.Client.Implementation
{
    public class ClientPeer : PeerBase, IClientPeer
    {
        public ClientPeer(InitRequest initRequest) : base(initRequest)
        {
        }

        public ClientPeer(IRpcProtocol protocol, IPhotonPeer unmanagedPeer) : base(protocol, unmanagedPeer)
        {
        }

        protected override void OnOperationRequest(OperationRequest operationRequest, SendParameters sendParameters)
        {
            throw new NotImplementedException();
        }

        protected override void OnDisconnect(DisconnectReason reasonCode, string reasonDetail)
        {
            throw new NotImplementedException();
        }

        public bool Connect()
        {
            throw new NotImplementedException();
        }

        public new bool Disconnect()
        {
            base.Disconnect();
            return true;
        }
    }
}