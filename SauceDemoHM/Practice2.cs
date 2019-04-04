using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Shouldly;
using System;

namespace SauceDemoHM
{
    [TestFixture]
    public class Practice2
    {
        //Unit test starts here
        [Test]
        public void SauceTest()
        {
            //using as a loop to close Chrome browser after Unit test ran
            using (var driver = new ChromeDriver())
            {
                //find a website by URL
                driver.Navigate().GoToUrl("https://www.saucedemo.com/");

                // all var is using to decrale a variables by finding a specific HTML elemnets by ID, CalssName, or xPath,
                //and  asigning to this var 
                var nameInput = driver.FindElement(By.Id("user-name"));
                nameInput.SendKeys("standard_user");
                //.SendKeys() method uses for typing nessesary content in input HTML element

                var passwordInput = driver.FindElement(By.Id("password"));
                passwordInput.SendKeys("secret_sauce");

                var loginButton = driver.FindElement(By.ClassName("login-button"));
                loginButton.Click();
                //.Click() method uses to perform submit on button

                var addCart = driver.FindElement(By.XPath("//button[contains(@class,'add-to-cart-button')][1]"));
                addCart.Click();

                var shoppingCart = driver.FindElement(By.Id("shopping_cart_container"));
                shoppingCart.Click();

                var checkOut = driver.FindElement(By.ClassName("cart_checkout_link"));
                checkOut.Click();

                var firstName = driver.FindElement(By.XPath("//input[@type='text'][1]"));
                firstName.SendKeys("Iryna");

                var lastName = driver.FindElement(By.XPath("//input[@type='text'][2]"));
                lastName.SendKeys("Lemeha");

                var zipCode = driver.FindElement(By.XPath("//input[@type='text'][3]"));
                zipCode.SendKeys("60622");

                var continueButton = driver.FindElement(By.XPath("//input[@type='submit']"));
                continueButton.Click();

                var finishButton = driver.FindElement(By.XPath("//a[.='FINISH']"));
                finishButton.Click();

                //driver.Title.ShouldBe("Swag Labs");
               // driver.
                //driver.Quit();
            }
        }
    }
}
