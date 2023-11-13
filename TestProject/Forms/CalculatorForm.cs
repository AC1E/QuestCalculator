using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems;
using Pilot_FrameWork.Base;
using Pilot_FrameWork.Items;
using TestStack.White.UIItems.MenuItems;
using NLog;

namespace TestProject.Forms
{
    public class CalculatorForm : BaseItem
     {
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();
        public CalculatorForm(SearchCriteria searchCriteria, string friendlyName) : base(searchCriteria, friendlyName)
        {
        }
        private ZButtons ButtonPlus   => new ZButtons(SearchCriteria.ByAutomationId("93"), "Number");
        private ZButtons ButtonMPlus  => new ZButtons(SearchCriteria.ByAutomationId("125"), "Number");
        private ZButtons ButtonEqual  => new ZButtons(SearchCriteria.ByAutomationId("121"), "Number");
        private ZButtons ButtonSquare => new ZButtons(SearchCriteria.ByAutomationId("111"), "Number");
        private ZButtons ClearButton => new ZButtons(SearchCriteria.ByAutomationId("81"), "Number");

        public void EnterPlus()
        {
            ButtonPlus.Click();
        }
        public void EnterMPlus()
        {  
                ButtonPlus.Click(); 
        }

        public void EnterEqual()
        {
    
            ButtonPlus.Click();
        }
        public void EnterSquare()
        {  
            ButtonSquare.Click();
        }
        public void EnterClear()
        {
             ClearButton.Click();
        }
        public ZButtons getButton(string number)
        {
            return new ZButtons(SearchCriteria.ByAutomationId($"13{number}"), "number");

        }

        public void EnterNumber(string number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                 var value = Char.ToString(number[i]);
                 ZButtons button = getButton(value);
                 button.Click();
            }
        }
        public void EnterMode(string Mode)
        {
            ZMenu ClickView = new ZMenu(SearchCriteria.ByText("View"), "Option");
            ClickView.ClickMenuItem(Mode);
            
            ZMenu clickView = new ZMenu(SearchCriteria.ByText("View"), "Option");
            clickView.DoubleClick();
            ZMenu clickScientific = new ZMenu(SearchCriteria.ByText(Mode), "Mode");
            clickScientific.Click();
        }
        public static string GetResult()
        {
            ZLabels appLabel = new ZLabels(SearchCriteria.ByAutomationId("158"), "lsbel");
            var ObtainedResult = appLabel.GetLabelText();
            return ObtainedResult;
        }
    }
}
