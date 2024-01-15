using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using FluentAssertions;

namespace SpecFlowBrowserStack
{
    [Binding]
    public class SampleLocalTest
    {
        private readonly IWebDriver _driver;

        public SampleLocalTest()
        {
            _driver = BrowserStackSpecFlowTest.ThreadLocalDriver.Value;
            new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
        }

        [Given(@"I navigate to local website")]
        public void GivenINavigatedTowebsite()
        {
            _driver.Navigate().GoToUrl("http://bs-local.com:45454/");
        }

        [Then(@"title should contain (.*)")]
        public void ThenIShouldSeeTitle(string localString)
        {
            Thread.Sleep(5000);
            localString.Should().Contain(_driver.Title);
        }
    }
}
