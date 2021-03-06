﻿using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using PetCarePage.Pages;
using PetCareTests.Configuration;
using PetCareTests.WebDriver;
using Shouldly;

namespace PetCarePage.Tests
{
    [TestFixture]
    public class ContactPageTest
    {
        [Test]
        public void ContactMePageTest()
        {
            using (var driver = DriverUtils.CreateWebDriver())
            {
                driver.Navigate().GoToUrl(Config.GetURL());
                var contactMenuPage = new ContactMePage(driver);
                
                contactMenuPage.OpenContactPage();
                    
                contactMenuPage.GeContactPagetHeaderText().ShouldBe("Contact Me");

                contactMenuPage.GetPageText().ShouldContain("If you want");
                contactMenuPage.GetPagePhone().ShouldBe("773-800-9646");
                contactMenuPage.GetPageEmail().ShouldBe("vova64@gmail.com");
                contactMenuPage.OpenCareRequestPage();
                contactMenuPage.GetCareRequestTitle().ShouldBe("Care Request");
            }
            
        }

    }
}
