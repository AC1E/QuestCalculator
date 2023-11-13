
using TestStack.White.UIItems.WindowItems;
using TestStack.White;
using Pilot_FrameWork.Utils.Loggers;
using Pilot_FrameWork.Items;
using System;

namespace Pilot_FrameWork.Base
{
    public class BaseForm
    {
        public static bool IsWindowOpen(string title)
        {
            var window = ZApplication.GetApplicationWindow(title);
            var bool1 = window != null && window.zWindow.IsCurrentlyActive;
            //Console.WriteLine(bool1);
            return false;
        }
    }
}




