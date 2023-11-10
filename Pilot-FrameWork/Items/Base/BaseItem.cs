
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems;
using Pilot_FrameWork.Items;
using NLog;
using System;

namespace Pilot_FrameWork.Base
{
    public class BaseItem
    {
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();
        private SearchCriteria _searchCriteria;
        private string _friendlyName;
        public BaseItem(SearchCriteria searchCriteria, string friendlyName)
        {
            _searchCriteria = searchCriteria;
            _friendlyName = friendlyName;
        }
        public IUIItem UIGetElement()
        {
            try
            {
                return ZApplication.GetApplicationWindow().zWindow.Get(_searchCriteria);
            }
            catch (Exception ex)
            {
                Logger.Error($"Error retrieving UI element {_friendlyName}: {ex.Message}");
                return null;
            }
        }
        
        public void Click()
        {
            try
            {
                Logger.Info($"Clicked {_friendlyName} button successfully.");
                var clickButton = UIGetElement();
                clickButton?.Click();
                
            }
            catch (Exception ex)
            {
                Logger.Error($"Error clicking {_friendlyName} button: {ex.Message}");
            }
        }
        public void DoubleClick()
        {
            try
            {
                Logger.Info($"Double-clicked {_friendlyName} element successfully.");
                var clickMenu = UIGetElement();
                clickMenu?.DoubleClick();  
            }
            catch (Exception ex)
            {
                Logger.Error($"Error double-clicking {_friendlyName} element: {ex.Message}");
            }
        }
    }
}





