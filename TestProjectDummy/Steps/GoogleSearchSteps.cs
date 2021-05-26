using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Test_Automation;
using TestProjectDummy.Pages;

namespace TestProjectDummy.Steps
{
    [Binding]
    public class GoogleSearchSteps
    {
        private DriverHelper _driverHelper;
        GoogleSearch googlesearch;
        public GoogleSearchSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            googlesearch = new GoogleSearch(_driverHelper.Driver);

        }

        [Given(@"I have navigated to the google serach page")]
        public void GivenIHaveNavigatedToTheGoogleSerachPage()
        {
            _driverHelper.Driver.Navigate().GoToUrl("https://www.google.com");
        }

        [Given(@"I have entered Selenium as search keyword input")]
        public void GivenIHaveEnteredSeleniumAsSearchKeywordInput()
        {
            googlesearch.searchInput();
        }

        [When(@"I have searched the input keyword")]
        public void WhenIHaveSearchedTheInputKeyword()
        {
            googlesearch.searchClick();
        }

        [Then(@"I should be navigated to seatch result page")]
        public void ThenIShouldBeNavigatedToSeatchResultPage()
        {
            Boolean result = googlesearch.searchResult();
            result.Should().BeTrue();
        }

    }
}
