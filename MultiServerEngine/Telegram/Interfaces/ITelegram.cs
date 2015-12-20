using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
