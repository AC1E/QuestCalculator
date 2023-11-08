using System.Configuration;
using System;
using TestStack.White;
using Pilot_FrameWork.Utils.Configuration;
using Configuration = Pilot_FrameWork.Utils.Configuration.Configuration;
using System.Xml;
using System.IO;

namespace Pilot_FrameWork.Items
{
    public class ZApplication
    {
        public static Application application;

        public static void LaunchApplication(string appName)
        {
            //  var appPath = Configuration.path();
            var appPath = Configuration.path(appName);
            Console.WriteLine(appPath);
            application = Application.Launch(appPath);

        }

        public static ZWindow GetApplicationWindow(string title = "")
        {
            
            return new ZWindow(application.GetWindow(string.IsNullOrEmpty(title) ? "Calculator" : title));
        }

    }
}


