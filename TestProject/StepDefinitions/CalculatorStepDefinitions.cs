using NUnit.Framework;
using Pilot_FrameWork.Items;
using TechTalk.SpecFlow;
using TestProject.Forms;
using TestStack.White.UIItems.Finders;
using Pilot_FrameWork.Base;
using System.Diagnostics;
using Pilot_FrameWork;

namespace TestProject.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        CalculatorForm calculator = new CalculatorForm(SearchCriteria.All, "");
        private readonly ProcessesHelpers processes = new ProcessesHelpers();
        [Given(@"Calculator is Opened")]
        public void GivenCalculatorIsOpened()
        {
            if (BaseForm.IsWindowOpen("Calculator"))
            {
                processes.KillMultipleInstancesOfProcess("calc1");
            }
            else
            {
                ZApplication.LaunchApplication("calcualtor");
            }

        }
        [When(@"I Select the Mode '(.*)'")]
        public void WhenISelectTheMode(string mode)
        {
            calculator.EnterMode(mode);
        }

        [When(@"I Input '(.*)'")]
        public void WhenIInput(string number)
        {
            calculator.EnterNumber(number);
        }

        [When(@"I perform '(.*)' action")]
        public void WhenIPerformAction(string action)
        {
            switch (action)
            {
                case "add":
                    calculator.EnterPlus();
                    break;
                case "equal":
                    calculator.EnterEqual();
                    break;
                case "StoreinMemory":
                    calculator.EnterMPlus();
                    break;
                case "Square":
                    calculator.EnterSquare();
                    break;
            }
        }

   

        [Then(@"The Result is '(.*)'")]
        public void ThenTheResultIs(string p0)
        {
            var result = CalculatorForm.GetResult();
            Assert.AreEqual(p0, result);
        }

    }
}