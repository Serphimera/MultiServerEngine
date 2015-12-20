using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MultiServerEngine.Peer.Server.Implementation;
using MultiServerEngine.Peer.Server.Interfaces;

namespace MultiServerEngine.Configuration.Interfaces
{
    public interface IServerData
    {
        ServerType Type { get; set; }
        string ApplicationName { get; set; }
        IPEndPoint MasterEndPoint { get; set; }
        int ServerPort { get; set; }
    }
}
