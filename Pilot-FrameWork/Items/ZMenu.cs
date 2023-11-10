using NUnit.Framework;
using Pilot_FrameWork.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems.Finders;

namespace Pilot_FrameWork.Items
{
    public class ZMenu : BaseItem
    {
        public ZMenu(SearchCriteria searchCriteria, string friendlyname) : base(searchCriteria, friendlyname)
        {
        }
        public void ClickMenuItem(string Mode)
        {
            DoubleClick();
            ZMenu clickscientific = new ZMenu(SearchCriteria.ByText(Mode), "Mode");
            clickscientific.Click();
        }
        
    }
}
