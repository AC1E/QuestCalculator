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

namespace TestProject.Forms
{
        public class CalculatorForm : BaseItem
        {
        public CalculatorForm(SearchCriteria searchCriteria, string friendlyName) : base(searchCriteria, friendlyName)
        {
        }
        private ZButtons button1 = new ZButtons(SearchCriteria.ByAutomationId("131"), "Number1");
        private ZButtons ButtonPlus   => new ZButtons(SearchCriteria.ByAutomationId("93"), "Number");
        private ZButtons ButtonMPlus  => new ZButtons(SearchCriteria.ByAutomationId("125"), "Number");
        private ZButtons ButtonEqual  => new ZButtons(SearchCriteria.ByAutomationId("121"), "Number");
        private ZButtons ButtonSquare => new ZButtons(SearchCriteria.ByAutomationId("111"), "Number");

        
        public void EnterPlus()
        {
            ButtonPlus.Click();
        }
        public void EnterMPlus()
        {
            ButtonMPlus.Click();
        }
        public void EnterEqual()
        {
            ButtonEqual.Click();
        }
        public void EnterSquare()
        {
            ButtonSquare.Click();
        }

        public ZButtons getButton(string number)
        {
            return new ZButtons(SearchCriteria.ByAutomationId($"13{number}"), "number");
        }
        public void EnterNumber(string number)
        {
            number.Select(c => Char.ToString(c))
                  .ToList()
                  .ForEach(value =>
                  {
                       ZButtons button = getButton(value);
                       button.Click();
                  });
        }
       
        public void EnterMode(string Mode)
        {
             ZMenu clickView = new ZMenu(SearchCriteria.ByText("View"), "Option");
             clickView.DoubleClick();
             ZMenu clickScientific = new ZMenu(SearchCriteria.ByText(Mode), "Mode");
             clickScientific.Click();
        }

        public static bool CompareResult(string expectedValue)
        {

               ZLabels appLabel = new ZLabels(SearchCriteria.ByAutomationId("158"), "lsbel");
                var ObtainedResult = appLabel.GetLabelText();
                Console.WriteLine(ObtainedResult);
                bool result = false;
                if (ObtainedResult != null)
                {
                    if (ObtainedResult == expectedValue)
                        result = true;
                    return result;
                }
                return result;
        }

           

        }
}



