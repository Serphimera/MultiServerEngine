using System;
using MultiServerEngine.Configuration.Implementation;
using MultiServerEngine.Configuration.Interfaces;
using MultiServerEngine.Peer.Server.Interfaces;
using Photon.SocketServer;
using Photon.SocketServer.ServerToServer;

namespace MultiServerEngine.Engine.Implementation
{
    public class ServerEngine : ApplicationBase
    {
        private IServerPeerFactory ServerFactory { get; set; }

        protected override PeerBase CreatePeer(InitRequest initRequest)
        {
            throw new NotImplementedException();
        }

        protected override ServerPeerBase CreateServerPeer(InitResponse initResponse, object state)
        {
            IServerConfiguration conf = new ServerConfiguration();
            conf.AddConfigutation(initResponse);
            return ServerFactory.CreateServerPeer<ServerPeerBase>(conf);
        }

        protected override void Setup()
        {
            throw new NotImplementedException();
        }

        protected override void TearDown()
        {
            throw new NotImplementedException();
        }

        protected override void OnStopRequested()
        {
            base.OnStopRequested();
        }

        protected override void OnServerConnectionFailed(int errorCode, string errorMessage, object state)
        {
            base.OnServerConnectionFailed(errorCode, errorMessage, state);
        }
    }
}