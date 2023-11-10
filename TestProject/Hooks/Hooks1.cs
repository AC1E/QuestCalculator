using Pilot_FrameWork;
using System.Drawing.Text;
using TechTalk.SpecFlow;

namespace TestProject.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        string appname = "calc1";
        private readonly ProcessesHelpers processes = new ProcessesHelpers();
        [BeforeScenario("CloseAllInstance")]
        public void BeforeScenarioWithTag()
        {
           
            processes.KillMultipleInstancesOfProcess(appname);
        }
    }
}