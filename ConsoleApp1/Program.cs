using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
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

        }
    }
}
