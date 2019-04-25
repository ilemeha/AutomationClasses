using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using PetCareTests.Pages;
using Shouldly;

namespace PetCareTests.Tests
{
    [TestFixture]
    public class ContactPageTest
    {
        [Test]
        public void ContactMePageTest()
        {
           // var textNumber = "7733969481";
           // var textEmail = "lemeha.iryna@gmail.com";
           // var textFName = "First Name";
            //var textLName = "Lemeha";


            using (var driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://nitro.duckdns.org/Pets.QA/index.html");
                var contactMenuPage = new ContactMePage(driver);
                
                contactMenuPage.OpenContactPage();
                    
                contactMenuPage.GeContactPagetHeaderText().ShouldBe("Contact Me");

                contactMenuPage.GetPageText().ShouldContain("If you want");
                contactMenuPage.GetPagePhone();
                contactMenuPage.GetPageEmail();
                contactMenuPage.OpenCareRequestPage();


              

            }
            
        }

    }
}
