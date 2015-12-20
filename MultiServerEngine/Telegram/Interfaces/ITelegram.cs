using System.Collections.Generic;

namespace MultiServerEngine.Telegram.Interfaces
{
    public interface ITelegram
    {
        ITelegramType Type { get; set; }
        byte TelegramCode { get; set; }
        int? TelegramSubCode { get; set; }
        Dictionary<byte, object> TelegramParameters { get; set; }
    }
}