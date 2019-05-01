using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using PetCareTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareTests.Tests
{
    [TestFixture]
    public class PracticalCh7Test
    {
        [Test]
        public static void Main(string[] arg)
        {

            /*using (var driver = new Pages())
            {

                var practicalTests = new PracticalTasksCh7(driver);
               

                    /* PracticalTasksC.TotalPrice("$35.80", "$67.87");
                     PracticalTasksCh7.LoginMatches("Iryna", "Chicago1");
                     PracticalTasksCh7.SmallOfThree(23, 45, 56);
                     PracticalTasksCh7.RectangArea(23, 12);*/
               
            
        }
    }
}