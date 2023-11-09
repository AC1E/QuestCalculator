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
        string smode;

        [Given(@"Open the Calculator Application")]
        public void GivenOpenTheCalculatorApplication()
        {
            ZApplication.LaunchApplication("calcualtor");
        }

        [Given(@": Select the Mode '([^']*)'")]
        public void GivenSelectTheMode(string mode)
        {
            smode= mode;    
            calculator.EnterMode(mode);
        }

        [Then(@": I Enter on '([^']*)'")]
        public void ThenIEnterOn(string p0)
        {
            string num3 = p0.ToString();
            calculator.EnterNumber(num3);
        }

        [Then(@": I Enter '([^']*)' '([^']*)' and perform add operation")]
        public void ThenIEnterAndPerformAddOperation(string p0, string p1)
        {
            string num1 = p0.ToString();
            Console.WriteLine(num1);    
            string num2 = p1.ToString();

            calculator.EnterNumber(num1);
            calculator.EnterPlus();
            calculator.EnterNumber(num2);
            calculator.EnterPlus();
        }

        [Then(@": Then I Click M\+")]
        public void ThenThenIClickM()
        {
            calculator.EnterMPlus();
        }

        [Then(@": Use square root if its scientific '([^']*)'")]
        public void ThenUseSquareRootIfItsScientific(string p0)
        {

            if (smode == "Scientific")
            {
                calculator.EnterClear();
                calculator.EnterNumber(p0);
                calculator.EnterSquare();
                calculator.EnterEqual();
            }
            else
            {
                calculator.EnterNumber(p0);
                calculator.EnterEqual();
            }
        }

        

        [Then(@": The Result should be '([^']*)'")]
        public void ThenTheResultShouldBe(string p0)
        {
            string num4 = p0.ToString();

            bool compareReslt = CalculatorForm.CompareResult(num4);

            if (compareReslt == true)
            {
                Console.WriteLine("The obtained result matches the expected value.");
            }
            else
            {
                Console.WriteLine("The obtained result does not match the expected value.");
            }

        }
    }
}