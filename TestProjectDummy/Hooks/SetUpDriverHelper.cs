using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Test_Automation;

namespace TestProjectDummy.Hooks
{
    [Binding]
    public class SetUpDriverHelper
    {
        private DriverHelper _driverHelper;
        public SetUpDriverHelper(DriverHelper driverHelper) => _driverHelper = driverHelper;

        [BeforeScenario]
        public void BeforeScenario()
        {
            _driverHelper.Driver = new FirefoxDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driverHelper.Driver.Quit();
        }
    }
}
