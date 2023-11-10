
using TestStack.White.UIItems.WindowItems;
using TestStack.White;
using Pilot_FrameWork.Utils.Loggers;

namespace Pilot_FrameWork.Base
{
    public class BaseForm
    {
        protected static Application _application;
      
        public BaseForm(Application application)
        {
            _application = application;
        }
        protected Window GetWindow(string title)
        {
            try
            {
                Nlogger.Log("Info",$"Retrieving window: {title}");
                return _application.GetWindow(title);
            }
            catch (AutomationException ex)
            {
                Nlogger.Log("Error",$"Error while getting the window '{title}'");
            }
            return null;
        }
        protected bool IsWindowOpen(string title)
        {
            Window window = GetWindow(title);
            return window != null && window.IsCurrentlyActive;
        }
    }
}

   

