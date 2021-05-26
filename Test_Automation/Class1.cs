// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace Test_Automation
{
    [TestFixture]
    public class TestClass
    {
        IWebDriver driver = new FirefoxDriver();
        IWebElement we;
        //WebDriverWait wait;
        [SetUp]
        public void TestSetup()
        {
            // TODO: Add your test code here
            //var answer = 42;
            //Assert.That(answer, Is.EqualTo(42), "Some useful error message");
            driver.Url = "https://www.google.com";
        }

        [Test]
        public void TestMethod1()
        {
            // TODO: Add your test code here
            //var answer = 42;
            //Assert.That(answer, Is.EqualTo(42), "Some useful error message");
            we = driver.FindElement(By.XPath("//input[@title='Search']"));
            Boolean result = we.Displayed;
            Assert.AreEqual(true, result);
        }

        [Test]
        public void TestMethod2()
        {

            we = driver.FindElement(By.XPath("(//input[@aria-label='Google Search'])[2]"));
            Boolean result = we.Displayed;
            Assert.AreEqual(true, result);
        }

        [Test]
        public void TestMethod3()
        {
            we = driver.FindElement(By.XPath("//input[@title='Search']"));
            we.SendKeys("Selenium");
            we.SendKeys(Keys.Enter);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            // we = driver.FindElement(By.XPath("(//input[@aria-label='Google Search'])[1]"));
            // we.Click();
            we = driver.FindElement(By.XPath("(//h2[@data-attrid='title'])[1]/span"));
            String result = we.GetAttribute("innerHTML");
            Assert.AreEqual("Selenium", result);

            driver.Quit();
        }


    }
}
