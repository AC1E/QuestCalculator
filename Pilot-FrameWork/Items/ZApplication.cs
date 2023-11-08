using System.Configuration;
using System;
using TestStack.White;
using Pilot_FrameWork.Utils.Configuration;
using Configuration = System.Configuration.Configuration;

namespace Pilot_FrameWork.Items
{
    public class ZApplication
    {
        public static Application application;
        public static void LaunchApplication(string appName)
        {
            string path = "";
            application = Application.Launch(path);
        }

        public static ZWindow GetApplicationWindow(string title = "")
        {
            return new ZWindow(application.GetWindow(string.IsNullOrEmpty(title) ? "Calculator" : title));
        }

    }
}


