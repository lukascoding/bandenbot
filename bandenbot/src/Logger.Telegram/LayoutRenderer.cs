using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using NLog.Layouts;

namespace Logger.Telegram
{
    public class LayoutRenderer : NLog.LayoutRenderers.LayoutRenderer
    {
        protected override void Append(StringBuilder builder, LogEventInfo logEvent)
        {
            builder.AppendLine($"Level: {logEvent.Level}");
            builder.AppendLine($"Message: {logEvent.Message}");
        }
    }
}
