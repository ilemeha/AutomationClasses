using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Shouldly;
using System;
using System.Threading;

namespace CalculateHM
{
    [TestFixture]
    public class CalcMathHM
    {
        [Test]
        public void CalculateHM()
        {
            //1.Calculate perimeter of a triangle
            int x = 6;
            int y = 9;
            int d = 8;
            int P = x + y + d;
            Console.WriteLine(P);

            //2.Write a converter which takes number in inches and converts it to meters
            //Inch to meters Formula m = in/39.370
            double conveInch = 150 ;
            double m = conveInch / 39.370;
            Console.WriteLine(Math.Round(m));


            //3. Write a program that takes three numbers as input to calculate and print the average of the numbers
            int number1 = 18, number2 = 12, number3 = 5;
            decimal aver = (number1 + number2 + number3) / 3;
            Console.WriteLine(Math.Round(aver));

            /*Console.Write("What is your number 1? ");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is your number 2? ");
            number2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is your number 3? ");
            number3 = Convert.ToDouble(Console.ReadLine());
            double aveargeNum = (number1 + number2 + number3) / 3;
            Console.WriteLine(" The average of your numbers "  + number1 + ", " + number2 + ", " + number3 + "is :" + Convert.ToString(aveargeNum));
            */


            //4. Write a program to calculate the sum of two integers 
            //and return true if the sum is equal to a third integer and false if it’s not
            int apple1 = 5;
            int apple2 = 6;
            int apple3 = 11;
            Console.WriteLine((apple1 + apple2) == apple3);

       
        }
    }
}
