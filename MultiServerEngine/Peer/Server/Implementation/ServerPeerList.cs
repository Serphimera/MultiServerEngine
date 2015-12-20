using System.Collections.Generic;
using System.Linq;
using ExitGames.Logging;
using MultiServerEngine.Peer.Server.Interfaces;

namespace MultiServerEngine.Peer.Server.Implementation
{
    public class ServerPeerList : IServerPeerList
    {
        private ILogger Logger { get; }
        public Dictionary<IServerType, IServerPeer> PeerList { get; set; }

        public ServerPeerList(ILogger logger)
        {
            Logger = logger;
        }

        public bool AddServer(IServerType type, IServerPeer serverPeer)
        {
            if (PeerList.ContainsKey(type))
            {
                Logger.ErrorFormat("Server peer list already containes peer for type {0}", type);
                return false;
            }
            PeerList.Add(type, serverPeer);
            Logger.InfoFormat("Adding server peer of type {0} to list of servers.", type);
            return true;
        }

        public IServerPeer GetServerForType(IServerType type)
        {
            if (PeerList.ContainsKey(type))
            {
                Logger.InfoFormat("Found server peer for type {0}", type);
                return PeerList.FirstOrDefault(c => c.Key == type).Value;
            }

            Logger.ErrorFormat("No server peer found for type {0}", type);
            return null;
        }
    }
}