using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilot_FrameWork.Utils.Loggers
{
    public class Logger
    {
        public class NLogReporter
        {

            private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();
            public void LogInfo(string message)
            {
                Logger.Info(message);
            }
            public void LogError(string message)
            {
                Logger.Error(message);
            }
            public void LogWarning(string message)
            {
                Logger.Warn(message);
            }
            public void LogDebug(string message)
            {
                Logger.Debug(message);
            }
        }
    }
}
