using System.Configuration;
using System;
using TestStack.White;
using Pilot_FrameWork.Utils.Configuration;
using Configuration = Pilot_FrameWork.Utils.Configuration.Configuration;
using System.Xml;
using System.IO;
using NLog;

namespace Pilot_FrameWork.Items
{
    public class ZApplication
    {

        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();
        public static Application application;
        public static void LaunchApplication(string appName)
        {
            try
            {
                Logger.Info($"Application '{appName}' launched successfully.");
                var appPath = Configuration.Path(appName);
                application = Application.Launch(appPath);
                    
            }
            catch (Exception ex)
            {
                Logger.Error($"Error launching application '{appName}': {ex.Message}");
            }
        }
        public static ZWindow GetApplicationWindow(string title = "")
        {
            try
            {
                var windowTitle = string.IsNullOrEmpty(title) ? "Calculator" : title;
                var window = application.GetWindow(windowTitle);
                return new ZWindow(window);
            }
            catch (Exception ex)
            {
                Logger.Error($"Error getting the application window: {ex.Message}");
                return null;
            }
        }
    }



}
       