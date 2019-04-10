using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomewrokCH6
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var random = new Random();
            int number = random.Next(-100, 100);

            string message;
            if (number < 0)
            {
                message = $"{number}.  This is negative number";
            }
            else
            {
                message = $" {number}. This is positive number ";
            }

            Console.WriteLine(message);
        }
    
    }
}
