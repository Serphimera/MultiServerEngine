using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiServerEngine.Telegram.Interfaces
{
    public interface ITelegramHandlerList
    {
        Dictionary<ITelegramHandlerType, ITelegramHandler> HandlerList { get; set; }
        bool RegisterHandler(ITelegramHandler telegramHandler);
        ITelegramHandler GetHandlerForTelegram(ITelegram telegram);
    }
}
