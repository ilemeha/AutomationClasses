using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Shouldly;
using System;


namespace MathTasksHM
{
    [TestFixture]
    public class MathCodeShare
    {
        [Test]
        public void MathTasks()
        {
            // Guess what will be the output of this code? Then run the code and check your answer.

            string side1 = "6";
            int side2 = 8;
            int side3 = 8;

            Console.WriteLine(side1 + side2 + side3);
            //616

            // Guess what will be the output of this code? Then run the code and check your answer.

            int side4 = 6;
            int side5 = 8;
            string side6 = "8";

            Console.WriteLine(side4 + side5 + side6);
            //148

            // What will be the output of this code?
            int x = 5;
            int y = 2;
            int z = x % y;
            Console.WriteLine(z);
            //1

            //Write a code                       
            //Find the remainder of 15 divided by 9, using two variables x and y
            int a = 15;
            int b = 9;
            Console.WriteLine(a % b);

            //Write a code                       
            //Display the product of 10 * 5, using two variables x and y.
            int s = 10;
            int f = 5;
            Console.WriteLine(s * f);

            //What will be the output of this code? Investigate on your own what += operator means
            int h = 10;
            h += 5;

            Console.WriteLine(h);
            //15
            //Investigate on your own what -= operator means. Write a code                           
            // Use the -= operator to subtract a value of 5 from the variable x.
            int o = 25;
            o -= 5;
            Console.WriteLine(o);
            //What will be the output of this code?             
            int t = 5;
            int r = 5;
            int e = 6;
            Console.WriteLine(t == r);
            Console.WriteLine(t == e);
            //true
            // false

            //What will be the output of this code?                
            string text1 = "think";
            string text2 = "Think";

            bool result = text1 == text2;
            string q = result ? "The strings are the same" : "The strings are different";
            Console.WriteLine(q);
            //The strings are different

            //Challenge
            //What will be the output of this code?
            bool alreadyLoggedIn = false;
            bool isUsernameEntered = true;
            bool isPasswordEntered = true;
            bool isLoginButtonVisible = true;

            bool result1 = alreadyLoggedIn || isUsernameEntered && isPasswordEntered && isLoginButtonVisible;
            Console.WriteLine("Result 1:");
            Console.WriteLine(result1);
            //true

            isLoginButtonVisible = false;
            result1 = alreadyLoggedIn || isUsernameEntered && isPasswordEntered && isLoginButtonVisible;
            Console.WriteLine("Result 2:");
            Console.WriteLine(result1);
            //false


            alreadyLoggedIn = true;
            result1 = alreadyLoggedIn || isUsernameEntered && isPasswordEntered && isLoginButtonVisible;
            Console.WriteLine("Result 3:");
            Console.WriteLine(result1);
            //true
        }
    }
}