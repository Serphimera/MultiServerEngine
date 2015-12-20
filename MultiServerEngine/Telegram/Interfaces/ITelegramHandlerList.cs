using System.Collections.Generic;

namespace MultiServerEngine.Telegram.Interfaces
{
    public interface ITelegramHandlerList
    {
        Dictionary<ITelegramHandlerType, ITelegramHandler> HandlerList { get; set; }
        bool RegisterHandler(ITelegramHandler telegramHandler);
        ITelegramHandler GetHandlerForTelegram(ITelegram telegram);
    }
}