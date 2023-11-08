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
        
        [Given(@"launch the application")]
        public void GivenLaunchTheApplication()
        {
            ZApplication.LaunchApplication("calcualtor");
        }

    }

}