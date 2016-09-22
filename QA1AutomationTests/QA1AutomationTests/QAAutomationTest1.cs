using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
using QAAutomation1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QA1AutomationTests
{
    [TestClass]
    public class QAAutomationTest1
    {
        public IWebDriver driver;
        ChromeDriverService service;
        ChromeOptions opts;
        TimeSpan thirtySeconds;
        

        [AssemblyInitialize]
        public void Pretest()
        {
            service = ChromeDriverService.CreateDefaultService();
            opts = new ChromeOptions();
            thirtySeconds = new TimeSpan(0, 0, 30);
            driver = new ChromeDriver(service, opts, thirtySeconds);

        }

        [TestMethod]
        public void VerifyTitle()
        {
            QAAutomation1.Class1 page = new Class1(driver);
            Assert.IsTrue(page.GotoPage("http://www.skiutah.com", "Ski Utah"));
        }
    }
}
