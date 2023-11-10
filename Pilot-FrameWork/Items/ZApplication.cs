using System.Configuration;
using System;
using TestStack.White;
using Configuration = Pilot_FrameWork.Utils.Configuration.Configuration;
using System.Xml;
using System.IO;
using NLog;
using Pilot_FrameWork.Utils.Loggers;

namespace Pilot_FrameWork.Items
{
    public class ZApplication
    {

        public static Application application;
        public static void LaunchApplication(string appName)
        {
            try
            {
                Nlogger.Log("Info", $"Application '{appName}' launched successfully.");
                var appPath = Configuration.Path(appName);
                application = Application.Launch(appPath);
            }
            catch (Exception ex)
            {
                Nlogger.Log("Error", $"Failed launching application '{appName}'");
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
                Nlogger.Log("Error", $"Error getting the application window:");
                return null;
            }
        }
    }



}
       