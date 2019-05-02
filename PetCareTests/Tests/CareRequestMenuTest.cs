using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PetCarePage.Pages;
using PetCareTests.Configuration;
using PetCareTests.WebDriver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCarePage.Tests
{
    [TestFixture]
    public class CareRequestMenuTest
    {
        [Test]
        public void MenuTest()
        {
            using (var driver = DriverUtils.CreateWebDriver())
            {
                driver.Navigate().GoToUrl(Config.GetURL());
                var naviMenuPage = new NavigationMenuPage(driver);
                if (Config.GetEnviroment() == "PROD")
                {
                    naviMenuPage.OpenPicturesPage();
                }
                naviMenuPage.OpenCareRequestPage();
            }
        }
    }
}
