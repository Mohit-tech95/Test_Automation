using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjectDummy.Pages
{
    public class GoogleSearch
    {

        private IWebDriver Driver;

        public GoogleSearch(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebElement searchPage => Driver.FindElement(By.XPath("//input[@title='Search']"));
        public IWebElement searchedResult => Driver.FindElement(By.XPath("(//h2[@data-attrid='title'])[1]/span"));

        public void searchInput() => searchPage.SendKeys("Selenium");

        public void searchClick() => searchPage.SendKeys(Keys.Enter);

        public Boolean searchResult() => searchedResult.Displayed;

    }
}
