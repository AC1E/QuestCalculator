
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems;
using Pilot_FrameWork.Items;

namespace Pilot_FrameWork.Base
{
    public class BaseItem
    {
        static SearchCriteria _searchCriteria;
        private string _friendlyname;
        public BaseItem(SearchCriteria searchCriteria, string friendlyname)
        {
            _searchCriteria = searchCriteria;
            _friendlyname = friendlyname;
        }

        public IUIItem UIGetElement()
        {
            return ZApplication.GetApplicationWindow().zWindow.Get(_searchCriteria);
        }

        public string GetLabelText()
        {
            var uIItem = UIGetElement();
            if (uIItem is Label labelElement)
            {
                return labelElement.Text;
            }

            return null;
        }

        public void Click()
        {
            var ClickButton = UIGetElement();
            ClickButton.Click();
        }

        public void DoubleClick()
        {
            var ClickMenu = UIGetElement();
            ClickMenu.DoubleClick();
        }


    }
}



