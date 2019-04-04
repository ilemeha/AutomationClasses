using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class HMChapter5
    {
        static void Main(string[] args)
        {
            //1-2.Concatenate one string to the end of another string. Make sure you have space sign between them.
            Console.WriteLine("Tasks 1-2. Concatenate one string to the end of another string. Make sure you have space sign between them. ");
            Console.WriteLine(" ");
            Console.WriteLine("What is your first name:");
            string name = Console.ReadLine();

            Console.WriteLine("What is your last lanme:");
            string lastName = Console.ReadLine();

            Console.WriteLine("What is your favorite face sckin cream:");
            string band1 = Console.ReadLine();

            Console.WriteLine("What is your favorite brand of a foundation cream:");
            string band2 = Console.ReadLine();

            string clientAnswers = $"Dear {name} {lastName}. Your favorite sckin care cream is {band1} and the best foundation cream is {band2}.";
            Console.WriteLine(clientAnswers);

            //Write a code to get the length of a string. 
            int length = clientAnswers.Length;
            Console.WriteLine(length + " characheters long");
            Console.WriteLine("**************************************************** ");
            Console.WriteLine(" ");
            Thread.Sleep(2000);

            //3.“The quick brown fox jumps over the lazy dog”. Change fox to cat; change dog to frog. 

            Console.WriteLine("Task 3. This is old sentence. You have to change it. ");
            Console.WriteLine(" ");
            Console.WriteLine("The quick brown fox jumps over the lazy dog");
            Console.WriteLine("First change fox to cat");
            string oldSentense = "The quick brown fox jumps over the lazy dog";

            Console.WriteLine(oldSentense.Replace("fox", "cat").Replace("dog", "frog"));

            Console.WriteLine("**************************************************** ");
            Console.WriteLine(" ");
            Thread.Sleep(2000);

            //4.	The Quick BroWn FoX! Convert to lover
            Console.WriteLine("Task 4. The Quick BroWn FoX! Convert to lover ");
            Console.WriteLine(" ");
            Console.WriteLine("The Quick BroWn FoX! ");
            string smallLetters = "The Quick BroWn FoX! ";
            Thread.Sleep(2000);
            Console.WriteLine(smallLetters.ToLower());
            Console.WriteLine("**************************************************** ");
            Console.WriteLine(" ");
            Thread.Sleep(2000);

            //5.Remove any leading or trailing whitespace from a string. Use Trim() method.
            string cutSpace = "     The quick brown fox jumps over the lazy dog.  ";
            Console.WriteLine("Task 5. Remove any leading or trailing whitespace from a string. Use Trim() method ");
            Console.WriteLine("Before:");
            Console.WriteLine(cutSpace);
            Thread.Sleep(2000);

            Console.WriteLine("After:");
            Console.WriteLine(cutSpace.Trim());
            Console.WriteLine("**************************************************** ");
            Console.WriteLine(" ");
            Thread.Sleep(2000);

            //6.Your starbacks coffee costs $3 (var price = “$3”;).
            //How much do you spend per month if you drink coffee every day? 
            // Use int x = int.Parse(yourString); to convert string into an integer. 
            //But first, you will have to get rid of the dollar sign somehow

            Console.WriteLine(" Task 6. Now convert string into an integer and cut $ symbol");
            Console.WriteLine(" ");
            var price = "$3";
            Console.WriteLine("The ice cream cost price is" + price + " and it is a string");

            Thread.Sleep(2000);
            int priceToNumber = Int32.Parse(price.Replace("$",string.Empty));
            Console.WriteLine(priceToNumber *30);
            Console.WriteLine("**************************************************** ");
            Console.WriteLine(" ");
            Thread.Sleep(2000);

            //7.DateTime.Now.ToString() returns a string like “6/16/2018 8:57:42 AM. 
            Console.WriteLine("Task 7. DateTime.Now.ToString() returns a string like “6/16/2018 8:57:42 AM. Use ternary operator ");
            Console.WriteLine(" ");
            Console.WriteLine("What is your name:");
            string nameFirst = Console.ReadLine();
            Console.WriteLine("What is your favorite coffe brand:");
            string coffeBrand = Console.ReadLine();

            Console.WriteLine("What is your favorite movie:");
            string movieName = Console.ReadLine();

            string todayDay = DateTime.Now.ToString();
            Console.WriteLine($"Chicago time now {todayDay}");
            Thread.Sleep(2000);

            Console.WriteLine(todayDay.Contains("AM") ? $"Good Morning {nameFirst}! Have you had a cup of { coffeBrand} coffee yet ?"
            :  $"Good Afternoon,{name}! Let’s watch {movieName} movie tonight!");

            Console.WriteLine("**************************************************** ");
            Console.WriteLine(" ");
            Thread.Sleep(2000);

            //8.Output of this code?
            var s1 = "somelongstring";
            Console.WriteLine(s1.Substring(2, 4));
            Console.WriteLine(s1.Substring(2));
            //melo
            //melostring
            Thread.Sleep(2000);



        }
    }
}
