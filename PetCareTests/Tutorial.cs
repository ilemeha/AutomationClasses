using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Shouldly;
using System;

namespace PetCarePage
{
    [TestFixture]
    public class Tutorial
    {
        [Test]
        public void GoogleTest()
        {
            using (var driver = new ChromeDriver())
            { 
                driver.Navigate().GoToUrl("https://google.com");
                var searchInput = driver.FindElement(By.Name("q"));
                searchInput.SendKeys("spring");
                searchInput.SendKeys(Keys.Enter);

                driver.Title.ShouldBe("spring - Google Search");
            }
        }

        [Test]
        public void StringTutoral()
        {
            string myFirstStringVaraible1 = "Hello Word?";
            string myFirstStringVaraible2= "";
            string myFirstStringVaraible3 = " ";
            string myFirstStringVaraible4 = " 88gdge?";

        }
        [Test]
        public void StringTutoral2()
        {
            string name = "Hello Word?";
            string lastName = "HHGFFD";
            string dayofWeek = "Sunday";
            string sentense = "Hello" + name + " " + lastName + "!What are you doing on " + dayofWeek + "?" ;
            string sentense2 = $"Hello {name} {lastName}!What are you doing on {dayofWeek}?";

        }


    }
 }
