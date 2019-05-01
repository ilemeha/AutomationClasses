using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Chapter7
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
    class Caller
    {
        static void Main()
        {
            Console.WriteLine($"The total price of your two numbers is {Chapter7.TotalPrice("$35.80", "$67.87")}");
            Console.ReadKey();
            Console.WriteLine($"The restangle Area is {Chapter7.RectangArea(23, 12)}");
            Console.ReadKey();
            Console.WriteLine($" {Chapter7.LoginMatches("Iryna", "Chicago1")}");
            Console.ReadKey();
            Console.WriteLine($"The smallest number is { Chapter7.SmallOfThree(23, 12, 34)}");
            Console.ReadKey();


        }
    }
}
    /*
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Program.Method1();
             Program.Method2("Ira");
              Program.Method2("Ira", 8);
             * /
            /*Console.WriteLine("Please Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Please Enter your age:");
            string myAge= Console.ReadLine();

            Console.WriteLine("What is your favorite band number 1:");
            string band1 = Console.ReadLine();
            
            Console.WriteLine("What is your favorite band number 2:");
            string band2 = Console.ReadLine();

            string greetng = $"My name is {name} . I am {myAge}. My favorite music bands are {band1} and {band2}.";
            Console.WriteLine(greetng);

            int length = greetng.Length;
            Console.WriteLine(length + "characheters long");


            Console.ReadLine();*/

    /* Console.WriteLine("Please Enter your name:");
     string name = Console.ReadLine();

     string greetng = $"Hello {name} !";
     Console.WriteLine(greetng);
     bool containsIra = greetng.ToLower().Contains("ira");
     Console.WriteLine(containsIra);*/

    /*Console.WriteLine("Please Enter your name:");
    string name = Console.ReadLine();

    string greetng = $"Hello {name} !";

    string chunck = greetng.Substring(0,5);
    Console.WriteLine(chunck);*/

    /*
    Console.WriteLine("Please Enter price1:");
    string price1 = Console.ReadLine();

    Console.WriteLine("Please Enter price2:");
    string price2 = Console.ReadLine();

    decimal price1Parsed = decimal.Parse(price1.Substring(1));
   // decimal price1Parsed = decimal.Parse(price1.Contains("$") ? price1.Substring(1) : price1));
    decimal price2Parsed = decimal.Parse(price2.Substring(2));
    // decimal price1Parsed = decimal.Parse(price2.Contains("$") ? price1.Substring(1) : price2));

    Console.WriteLine("Price Sum:");
    Console.WriteLine(price1Parsed + price2Parsed);*/

    /* Console.WriteLine("Please Enter price1:");
     string price1 = Console.ReadLine();

     Console.WriteLine("Please Enter price2:");
     string price2 = Console.ReadLine();

     var price1Norm = price1.Replace("$", " ");
     var price2Norm = price1.Replace("$", " ");

     decimal price1Parsed = decimal.Parse(price1Norm);
     decimal price2Parsed = decimal.Parse(price1Norm);
     // decimal price1Parsed = decimal.Parse(price2.Contains("$") ? price1.Substring(1) : price2));

     Console.WriteLine("Price Sum:");
     Console.WriteLine(price1Parsed + price2Parsed);
     */
     /*
    Console.WriteLine("Please Enter price1:");
            string price1 = Console.ReadLine();

            Console.WriteLine("Please Enter price2:");
            string price2 = Console.ReadLine();

            Console.WriteLine("Pricr are the same?:");
            bool compareResult = price1.Equals(price2);
           // bool compareResult = price1 == price2);

            // Console.WriteLine(price1.Equals(price2));
            Console.WriteLine(compareResult);

            //var modelText = modal.Text;

            //modalText.ShoudlyContain("lemeha.iryna@gmail.com");
            */

