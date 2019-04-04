using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Shouldly;
using System;
using System.Threading;

namespace NitroDuckHM
{
    [TestFixture]
    public class PracticeNitro
    {
        [Test]
        //Unit test starts here
        public void PracticeNitroDuck()
        {
            //using as a loop to close Chrome browser after Unit test performed
            using (var driver = new ChromeDriver())
            {
                //find a website by URL
                // var driver = new ChromeDriver();
                driver.Navigate().GoToUrl("http://nitro.duckdns.org/Pets.QA/index.html");

                // all var is using to decrale a variables by finding a specific HTML elemnets by ID, CalssName, or xPath,
                //and  asigning to this var 
                //.SendKeys() method uses for typing nessesary content in input HTML element

                // clikc on menu button "Care Request"
                var careRequest = driver.FindElement(By.XPath("//ul/li[5]/a"));
                careRequest.Click();
                //Fill out all input elements form
                var firstName = driver.FindElement(By.XPath("//input[@id='firstName']"));
                firstName.SendKeys("Iryna");
                var lastName = driver.FindElement(By.XPath("//input[@name='lastName']"));
                lastName.SendKeys("Lemeha");
                var phoneNumber = driver.FindElement(By.XPath("//input[@class='phoneNumber']"));
                phoneNumber.SendKeys("7733969481");
                var emailNumber = driver.FindElement(By.XPath("//div[@id='emailContainer']//input"));
                emailNumber.SendKeys("lemeha.iryna@gmail.com");

                //choose an anymal by checking checkbox
                var checkAnimals = driver.FindElement(By.XPath("//input[@id='dog']"));
                checkAnimals.Click();
                //choose animals quanity from radio button
                var dogQty = driver.FindElement(By.XPath("//div[@class='input']//select[@id='dogQuantity']//option[@value='3+']"));
                dogQty.Click();

                //choose number of visit on chechbox
                var daysTotal = driver.FindElement(By.XPath("//div[@class='firstColumn input']//input[@id='visitSeveralTimesPerDay']"));
                daysTotal.Click();
                //choose how many days from radio button
                var manyDays = driver.FindElement(By.XPath("//div[@class='input']//select[@id='visitsPerDay']//option[@value='4']"));
                manyDays.Click();
                //type additionl comments
                var yourComments = driver.FindElement(By.XPath("//div[@class='firstColumn input']//textarea[@id='comments']"));
                yourComments.SendKeys("I would like to hire a person for 1-2 years.");
                //submit your request
                var requestButton = driver.FindElement(By.Id("requestButton"));
                requestButton.Click();
                Thread.Sleep(1000);
                //tryed to Click on "Close" button - NOT WOrk
                var closeWind = driver.FindElement(By.XPath("//button[.='Close']"));

                closeWind.Click();
                //driver.Quit();
            }
        }
    }
}
