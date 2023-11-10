using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilot_FrameWork.Utils.Loggers
{
       public static class Nlogger
       {
            private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();
            public static void Log(string logLevel, string message)
            {
 
       switch (logLevel)
       {
        case "Info":
            Logger.Info(message);
            break;
        case "Error":
            Logger.Error(message);
            break;
        case "Warn":
            Logger.Warn(message);
            break;
        case "Debug":
            Logger.Debug(message);
            break;
       } 
        }

            
        }
    }


