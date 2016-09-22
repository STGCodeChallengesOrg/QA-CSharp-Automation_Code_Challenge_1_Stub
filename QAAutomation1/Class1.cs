using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace QAAutomation1
{

    public class Class1
    {
        public IWebDriver driver;
        public Class1(IWebDriver driverArg) {
            driver = driverArg;
            
        }


        public bool GotoPage(String url, String validationString)
        {
            driver.Url = url;
            driver.Navigate();
            String title = driver.Title;
            Console.Write(title);
            //            return title == validationString.ToLower();
            return title.Contains(validationString);

        }

    }
}
