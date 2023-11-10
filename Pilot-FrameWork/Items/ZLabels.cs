using Pilot_FrameWork.Base;
using System.Windows.Automation;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace Pilot_FrameWork.Items
{
    public class ZLabels : BaseItem
    {
        public ZLabels(SearchCriteria searchCriteria, string friendlyname) : base(searchCriteria, friendlyname)
        {

        }
        public  string GetLabelText()
        {
            var uiItem = UIGetElement();
            if (uiItem is Label labelElement)
            {
                return labelElement.Text;
            }
            return null;
        }

    }   
}
