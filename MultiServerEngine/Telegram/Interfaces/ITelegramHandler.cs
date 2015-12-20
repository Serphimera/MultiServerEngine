using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiServerEngine.Peer.Server.Interfaces;

namespace MultiServerEngine.Telegram.Interfaces
{
    public interface ITelegramHandler
    {
        ITelegramHandlerType HandlerType { get; set; }
        bool HandleTelegram(ITelegram telegram, IServerPeer serverPeer);
        void OnHandleTelegram(ITelegram telegram);
    }
}
