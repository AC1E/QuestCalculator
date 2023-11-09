﻿using Pilot_FrameWork;
using System.Drawing.Text;
using TechTalk.SpecFlow;

namespace TestProject.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        private readonly ProcessesHelpers processes = new ProcessesHelpers();
        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
            string appname = "calc1";
            processes.KillMultipleInstancesOfProcess(appname);
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
        }

        [AfterScenario]
        public void AfterScenario()
        {
           
        }
    }
}