using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Shouldly;
using System;
using System.Threading;

namespace HMFormulas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculate perimeter of a triangle
            int x = 6;
            int y = 9;
            int d = 8;
            int P = x + y + d;
            Console.WriteLine(P);

            //Write a converter which takes number in inches and converts it to meters

            //Inch to meters formula m = in/39.370
            // double conveInch = 5 ;

            //double divider = 39.370;
            //decimal m = conveInch / divider;
            // Console.WriteLine(m);


            //Write a program that takes three numbers as input to calculate and print the average of the numbers
            double number1, number2, number3;

            Console.Write("What is your number 1? ");
            number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is your number 2? ");
            number2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is your number 3? ");
            number3 = Convert.ToDouble(Console.ReadLine());

            double aveargeNum = (number1 + number2 + number3) / 3;

            Console.WriteLine(" The average of your numbers " + number1 + ", " + number2 + ", " + number3 + "is :" + Convert.ToString(aveargeNum));

        }
    }
}
