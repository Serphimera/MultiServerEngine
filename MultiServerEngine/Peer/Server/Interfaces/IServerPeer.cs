using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiServerEngine.Peer.Server.Interfaces
{
    public interface IServerPeer
    {
        bool Register();
        bool Connect();
        bool Disconnect();
    }
}
