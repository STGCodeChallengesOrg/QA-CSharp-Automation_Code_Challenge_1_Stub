using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QAAutomation1;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace QA1AutomationTests
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver drv;
        
        [TestMethod]
        public void TestMethod1()
        {
            //ChromeOptions co = new ChromeOptions();
            
            drv = new ChromeDriver();
            QAAutomation1.Class1 page = new Class1(drv);
            String title = drv.Title;
            Console.Write(title);
            Assert.IsTrue(page.GotoPage("http://www.skiutah.com","Ski Utah-Ski Utah"));
        }
    }
}
