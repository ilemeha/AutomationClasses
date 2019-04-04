using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareTests
{
    public class Chapter6
    {
        [Test]
        public void DayTime()
        {
            var name = "Iryna";
            var coffee = "Starbacks";
            var movieName = "PRertty";
            var time = DateTime.Now.ToString();
            string message;

            if (time.Contains("AM"))
            {
                message = $"Good Morning {name}! Have you had a cup of { coffee} coffee yet ?";
            }
            else
            {
                message = $"Good Afternoon,{name}! Let’s watch {movieName} movie tonight!";
            }
            Console.WriteLine(message);
        }


        [Test]
        public void DrivingAge()
        {
            int age = new Random().Next(100);
            if (age == 16)
            {
                Console.WriteLine("You can drive, but only with 1 passenger");
            }
            else if (age < 16)
            {
                Console.WriteLine("You can.t drive.");
            }
            else
            {
                Console.WriteLine("You can drive alone or with multiple passenger");
            }
            Console.WriteLine($"Your age is {age}");
        }

           [Test]
           public void numberComparison()
           {
            var random = new Random();
            int age1 = random.Next(100);
            int age2= random.Next(80);
            if(age1 == age2)
            {
                Console.WriteLine($"Your age 1 is {age1} and age 2 is {age2}. This numbers are equal");
            }
            else
            {
                Console.WriteLine($"Your age 1 is {age1} and age 2 is {age2}.This number are NOT equal");
            }
           
        }  
    }
}
