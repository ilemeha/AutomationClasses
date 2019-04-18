using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareTests.Methods
{
    public class LoginMethods
    {
        public static void Login(IWebDriver driver)
        {
            driver.FindElement(By.Id("loginInput:")).SendKeys("testusername");
            driver.FindElement(By.Id("passwordInput:")).SendKeys("mypassword");
            driver.FindElement(By.Id("loginButton:")).Click();
        }
    }

    public class LoginUtilsNonStatic
    {


        public void LoginNonStatic(IWebDriver driver)
        {
            driver.FindElement(By.Id("loginInput:")).SendKeys("testusername");
            driver.FindElement(By.Id("passwordInput:")).SendKeys("mypassword");
            driver.FindElement(By.Id("loginButton:")).Click();
        }
    }
    
}
