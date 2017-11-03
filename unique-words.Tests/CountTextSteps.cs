using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace unique_words.Tests
{

    [Binding]
    public class CountTextSteps
    {
        [BeforeTestRun]
        private static void _before()
        {
            /*var applicationPath = GetApplicationPath(_applicationName);
            var programFiles = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            _iisProcess = new Process();
            _iisProcess.StartInfo.FileName = programFiles + "\\IIS Express\\iisexpress.exe";
            _iisProcess.StartInfo.Arguments = $"/path:{applicationPath} /port:{iisPort}";
            */
        }

        private readonly IWebDriver _driver = new ChromeDriver();
        [HostType("ASP.NET")]
        [UrlToTest("http://localhost:4675/Default.aspx")]
        [AspNetDevelopmentServerHost(@"C:TestSelenium", "/")]
        [Given(@"I am on the page")]
        public void GivenIAmOnThePage()
        {
            _driver.Url = "localhost:4675";
            //            driver.Navigate();
        }

        [Given(@"I enter text ""(.*)""")]
        public void GivenIEnterText(string text)
        {
            var input = _driver.FindElement(By.Id("InputText"));
            input.SendKeys(text);
        }


        [When(@"I press submit")]
        public void WhenIPressSubmit()
        {
            var submit = _driver.FindElement(By.Id("SubmitButton"));
            submit.Click();
        }

        [Then(@"the output should contain ""(.*)""")]
        public void ThenTheOutputShouldContain(string expected)
        {
            Assert.IsTrue(_driver.PageSource.Contains(expected));
        }



    }
}
