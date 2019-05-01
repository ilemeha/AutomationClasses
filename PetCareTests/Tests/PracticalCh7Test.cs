using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using PetCarePage.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCarePage.Tests
{
    [TestFixture]
    public class PracticalCh7Test
    {
        [Test]
        public static void Main()
        {
            /* PetCarePage.Pages.PracticalTasksCh7 hwork7 = new PetCarePage.Pages.PracticalTasksCh7();*/

            PracticalTasksCh7.TotalPrice("$35.80", "$67.87");
            PracticalTasksCh7.LoginMatches("Iryna", "Chicago1");
            PracticalTasksCh7.SmallOfThree(23, 45, 56);
            PracticalTasksCh7.RectangArea(5, 12);


        }
    }
}