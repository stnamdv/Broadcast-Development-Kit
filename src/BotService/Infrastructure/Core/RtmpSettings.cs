using BotService.Application.Core;
using Domain.Enums;

namespace BotService.Infrastructure.Core
{
    public class RtmpSettings: ProtocolSettings
    {
        public RtmpSettings()
        {
            base.Type = Protocol.RTMP;
        }
        public RtmpMode Mode { get; set; }
        public string StreamUrl { get; set; }
        public string StreamKey { get; set; }
        public bool EnableSsl { get; set; }
    }
}