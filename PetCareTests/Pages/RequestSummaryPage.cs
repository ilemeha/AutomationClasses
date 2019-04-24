using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PetCareTests.Pages
{
    public class RequestSummaryPage
    {
        private IWebDriver _driver;
        public RequestSummaryPage(IWebDriver outsidedriver)
        {
            _driver = outsidedriver;
        }
        private IWebElement CloseSubmitButton=> _driver.FindElement(By.XPath("//button[.='Close']"));
        private IWebElement OrderVerification => _driver.FindElement(By.ClassName("modal-body"));

      
    }
}
