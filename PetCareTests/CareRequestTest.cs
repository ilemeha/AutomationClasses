using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using PetCareTests.Methods;
using Shouldly;


namespace PetCareTests
{
    [TestFixture]
    public class CareRequestTest
    {
        [Test]
        public void SecondTest()
        {
            using (var driver = new ChromeDriver())
            {
                LoginMethods.Login(driver);

                LoginUtilsNonStatic myLoginClass;
                myLoginClass = new LoginUtilsNonStatic();
                myLoginClass.LoginNonStatic(driver);

            }
        }
        [Test]
        public void CareRequestPageTest()
        {
            var testPhoneNumber = "7733969481";
            var testEmail = "lemeha.iryna@gmail.com";

            using (var driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://nitro.duckdns.org/Pets.QA/index.html");

                LoginMethods.Login(driver);
                driver.FindElement(By.LinkText("Care Request")).Click();

                //Fill out the form
                IWebElement firstName = driver.FindElement(By.Id("firstName"));
                firstName.SendKeys("Iryna");
                IWebElement lastName = driver.FindElement(By.Name("lastName"));
                lastName.SendKeys("Lemeha");
                var phoneNumber = driver.FindElement(By.ClassName("phoneNumber"));
                phoneNumber.SendKeys(testPhoneNumber);
                var id = "emailContainer";
                var emailNumber = driver.FindElement(By.XPath($"//div[@id='{id}']//input"));
                emailNumber.SendKeys(testEmail);

                //choose an animal by checking checkbox
                var checkAnimals = driver.FindElement(By.Id("dog"));
                checkAnimals.Click();

                //choose animals quanity from radio button
                IWebElement dogQtySelect = driver.FindElement(By.Id("dogQuantity"));
                SelectElement dogAmount = new SelectElement(dogQtySelect);
                dogAmount.SelectByText("3+");

                //choose number of visit on chechbox
                var daysTotal = driver.FindElement(By.Id("visitSeveralTimesPerDay"));
                daysTotal.Click();

                //choose how many days from radio button
                var timesPerDay = new SelectElement(driver.FindElement(By.Id("visitsPerDay")));
                timesPerDay.SelectByText("4");

                //type additionl comments
                var yourComments = driver.FindElement(By.Id("comments"));
                yourComments.SendKeys("I would like to hire a person for 1-2 years.");

                //submit your request
                var requestButton = driver.FindElement(By.Id("requestButton"));
                requestButton.Click();
                Thread.Sleep(1000);
                var closeButton = driver.FindElementByXPath("//button[.='Close']");
                var modal = driver.FindElement(By.ClassName("modal-body"));
                var modalText = modal.Text;
                Console.WriteLine(modalText);
                modalText.ShouldContain($"Phone #: {testPhoneNumber}");
                modalText.ShouldContain($"Email: {testEmail}");

                closeButton.Click();
            }
        }
    }
}
