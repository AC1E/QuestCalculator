using NUnit.Framework;
using Pilot_FrameWork.Items;
using TechTalk.SpecFlow;
using TestProject.Forms;
using TestStack.White.UIItems.Finders;


namespace TestProject.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        CalculatorForm calculator = new CalculatorForm(SearchCriteria.All, "");

            [Given(@"Calculator is Opened")]
            public void GivenCalculatorIsOpened()
            {
                ZApplication.LaunchApplication("calcualtor");
            }

            [When(@": I Select the Mode '([^']*)'")]
            public void WhenISelectTheMode(string mode)
            {
                calculator.EnterMode(mode);
            }

            [Then(@": I Input (.*)")]
            public void ThenIInput(int number)
            {
                string numb = number.ToString();
                calculator.EnterNumber(numb);
            }

            [Then(@": I perform '(.*)' action")]
            public void ThenIPerformAction(string action)
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
            [Then(@": The Result is '(.*)'")]
            public void ThenTheResultIs(string p0)
            {
                var result = CalculatorForm.GetResult();
                Assert.AreEqual(p0, result);
            }

    }
}