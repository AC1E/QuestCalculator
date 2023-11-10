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
        string smode;

        [Given(@": Open the Calculator Application")]
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

   
        [Then(@": I Enter '([^']*)' '([^']*)' and perform add operation")]
        public void ThenIEnterAndPerformAddOperation(string p0, string p1)
        { 

            calculator.EnterNumber(p0);
            calculator.EnterPlus();
            calculator.EnterNumber(p1);
            calculator.EnterEqual();    

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
                calculator.EnterNumber(p0);
                calculator.EnterSquare(); 
            }
            else
            {
                calculator.EnterPlus();
                calculator.EnterNumber(p0);
                calculator.EnterEqual();
            }
        }

        [Then(@": The Result should is '([^']*)'")]
        public void ThenTheResultShouldIs(string p0)
        {
            var result = CalculatorForm.GetResult();
            Assert.AreEqual(p0, result);
        }

    }
}