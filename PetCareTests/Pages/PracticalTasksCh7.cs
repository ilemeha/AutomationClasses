using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace PetCarePage.Pages
{
    public class PracticalTasksCh7
    {
        /* 1. Create a static method which takes two strings (prices) in this format:
         * $XX.XX and returns a total price. Call this method from a different class */
        public static double TotalPrice(string num1, string num2)
        {
            
            return (Convert.ToDouble(num1.Replace("$", String.Empty)) + Convert.ToDouble(num2.Replace("$", String.Empty)));
        }

        /* 2. Created a method which would take two integers and calculate the area of a rectangle.
         * Call the method from another class */
        public static int RectangArea(int length, int width)
        {
            
            return length * width;
        }

        /* 3. Write a method to find the smallest number among three numbers.
         *  The number should be passed into the method as parameters */
        public static int SmallOfThree(int number1, int number2, int number3)
        {
           
            int smallNumber = Math.Min(number1, number2);
            int smallNumber2 = Math.Min(smallNumber, number3);
            return smallNumber2;
        }

        /* 4. Create a method, which takes two parameters - username and password.
         * If the username matches your name and password matches "Chicago1",
         * the method prints out a message: "Hello, your name! You are logged in".
         * If not - "Incorect username or password" */
        public static string LoginMatches(string username, string password)
        {
           
            string loginStatus;
            if (username == "Iryna" && password == "Chicago1")
            {
                loginStatus = $"Hello, {username}! You are logged in!";
            }
            else
            {
                loginStatus = $"Incorect username or password!Please try again";
            }

            return loginStatus;
        }
    }
}
