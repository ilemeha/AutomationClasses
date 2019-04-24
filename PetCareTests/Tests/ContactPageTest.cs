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
                
                contactMenuPage.OpenWebsitePage();
                Thread.Sleep(1000);
                contactMenuPage.GetHeaderText();
                contactMenuPage.GetPageText();
                contactMenuPage.GetPagePhone();
                contactMenuPage.GetPageEmail();
                contactMenuPage.OpenCareRequestPage();


                Thread.Sleep(1000);

                //var verifyCareRequestPageOpened = driver.FindElement(By.XPath("//h1[contains(.,'Care Request'"));

                //var modal = driver.FindElement(By.ClassName("page-home"));
                //var modalText = modal.Text;

               // Console.WriteLine(modalText);
               // modalText.ShouldContain($"Phone #: {textNumber}");
               // modalText.ShouldContain($"Email: {textEmail}");
               // modalText.ShouldContain($"First Name: {textFName}");
               // modalText.ShouldContain($"Last Name: {textLName}");

            }
            
        }

    }
}
