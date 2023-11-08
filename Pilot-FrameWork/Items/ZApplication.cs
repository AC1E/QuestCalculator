using System.Configuration;
using System;
using TestStack.White;
using Pilot_FrameWork.Utils.Configuration;
using Configuration = Pilot_FrameWork.Utils.Configuration.Configuration;
using System.Xml;

namespace Pilot_FrameWork.Items
{
    public class ZApplication
    {
        public static Application application;

        
        public static void LaunchApplication(string appName)
        {
           var apppath=Configuration.path();
            // var Path = ConfigurationManager.AppSettings["AppPath"];

            application = Application.Launch(apppath);
        }

        public static ZWindow GetApplicationWindow(string title = "")
        {
            return new ZWindow(application.GetWindow(string.IsNullOrEmpty(title) ? "Calculator" : title));
        }

    }
}


