using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MultiServerEngine.Configuration.Interfaces;
using MultiServerEngine.Peer.Server.Implementation;
using MultiServerEngine.Peer.Server.Interfaces;

namespace MultiServerEngine.Configuration.Implementation
{
    public class ServerData : IServerData
    {
        public ServerType Type { get; set; }
        public string ApplicationName { get; set; }
        public IPEndPoint MasterEndPoint { get; set; }
        public int ServerPort { get; set; }
    }
}
