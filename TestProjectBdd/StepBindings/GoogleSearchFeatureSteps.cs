using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;

namespace TestProjectBdd.StepBindings
{
    [Binding]
    public class GoogleSearchFeatureSteps
    {
        IWebDriver driver = new FirefoxDriver();
        IWebElement we;
        [Given(@"I have navigated to the google serach page")]
        public void GivenIHaveNavigatedToTheGoogleSerachPage()
        {
            driver.Url = "https://www.google.com";
        }

        [Given(@"I have entered Selenium as search keyword input")]
        public void GivenIHaveEnteredSeleniumAsSearchKeywordInput()
        {
            we = driver.FindElement(By.XPath("//input[@title='Search']"));
            we.SendKeys("Selenium");

        }

        [When(@"I have searched the input keyword")]
        public void WhenIHaveSearchedTheInputKeyword()
        {
            we.SendKeys(Keys.Enter);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        
        [Then(@"I should be navigated to seatch result page")]
        public void ThenIShouldBeNavigatedToSeatchResultPage()
        {
            we = driver.FindElement(By.XPath("(//h2[@data-attrid='title'])[1]/span"));
            String result = we.GetAttribute("innerHTML");
            Assert.AreEqual("Selenium", result);

            driver.Quit();
        }
    }
}
