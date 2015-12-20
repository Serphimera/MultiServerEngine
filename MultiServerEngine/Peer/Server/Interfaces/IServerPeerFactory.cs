using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.Configuration;
using MultiServerEngine.Configuration.Interfaces;
using Photon.SocketServer.ServerToServer;

namespace MultiServerEngine.Peer.Server.Interfaces
{
    public interface IServerPeerFactory
    {
        T CreateServerPeer<T>(IConfiguration configuration) where T : ServerPeerBase;
    }
}
