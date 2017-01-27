using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NLog;
using NLog.Common;
using NLog.Targets;

namespace Logger.Telegram
{
    [Target("Channel")]
    public class Target : TargetWithLayout
    {
        private readonly string _bottoken;
        private readonly string _channelname;
        private Bot _bot;

        public Target(string bottoken, string channelname)
        {
            _bottoken = bottoken;
            _channelname = channelname;
            this._bot = new Bot(bottoken, _channelname);
            
        }

        protected override void Write(LogEventInfo logEvent)
        {
            
            base.Write(logEvent);
        }

        protected override void Write(AsyncLogEventInfo logEvent)
        {
            base.Write(logEvent);
        }

        protected override void Write(AsyncLogEventInfo[] logEvents)
        {
            base.Write(logEvents);
        }

        protected override void CloseTarget()
        {
            base.CloseTarget();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        protected override void FlushAsync(AsyncContinuation asyncContinuation)
        {
            base.FlushAsync(asyncContinuation);
        }

        protected override void InitializeTarget()
        {
            base.InitializeTarget();
        }

        protected override void WriteAsyncThreadSafe(AsyncLogEventInfo logEvent)
        {
            base.WriteAsyncThreadSafe(logEvent);
        }

        protected override void WriteAsyncThreadSafe(AsyncLogEventInfo[] logEvents)
        {
            base.WriteAsyncThreadSafe(logEvents);
        }
    }
}
