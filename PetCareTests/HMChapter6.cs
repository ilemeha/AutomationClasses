using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareTests
{
    public class HMChapter6
    {
        [Test]
        public void PositNegative()
        {
            //1.Get a number from the user and print whether it is positive or negative. 
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

        //2.Write code to read the age of a person and determine whether the person is eligible for voting. 
        [Test]
        public void VoterAge()
        {
            var random1 = new Random();
            int voterAge = random1.Next(100);
            string summary;
            if (voterAge < 18)
            {
                var eligToVote = 18 - voterAge;
                summary = $"Your age is {voterAge}.  You should wait {eligToVote} years to be eligible to vote.";
            }
            else
            {
                summary = $"Your age is {voterAge}.You are eligible to vote.";
            }
            Console.WriteLine(summary);
        }

        //3.	Write a program to check whether a given number is even or odd. 
        [Test]
        public void EvenOdd()
        {
            var random2 = new Random();
            int evenOdd = random2.Next(100);
            string result;

            if (evenOdd % 2 == 0)
            {
                result = $"The number {evenOdd} is even.";
            }
            else
            {
                result = $"The number {evenOdd} is odd.";
            }
            Console.WriteLine(result);
        }
        //4.Write a program which takes a number between 1 and 7 and prints out the name of the weekday. 
        [Test]
        public void NumberRange()
        {
            var random4 = new Random();
            int numberOfday = random4.Next(10);
            string dayToday;
            if (numberOfday == 1)
            {
                dayToday = $"Your number is {numberOfday}.  Today is Monday.";
            }
            else if (numberOfday == 2)
            {
                dayToday = $"Your number is {numberOfday}.  Today is Tuesday.";
            }
            else if (numberOfday == 3)
            {
                dayToday = $"Your number is {numberOfday}.  Today is Wednesday.";
            }
            else if (numberOfday == 4)
            {
                dayToday = $"Your number is {numberOfday}.  Today is Thursday.";
            }
            else if (numberOfday == 5)
            {
                dayToday = $"Your number is {numberOfday}.  Today is Friday.";
            }
            else if (numberOfday == 6)
            {
                dayToday = $"Your number is {numberOfday}.  Today is Saturday.";
            }
            else if (numberOfday == 7)
            {
                dayToday = $"Your number is {numberOfday}.  Today is Sunday.";
            }
            else
            {
                dayToday = $"Please enter a number between 1 and 7.";
            }
            Console.WriteLine(dayToday);
        }

        //5.	Come up with a year and print whether that year is a leap year or not
        [Test]
        public void LeapYear()
        {
            var randomYear = new Random();
            int year = randomYear.Next(2020);
            //chekc Else If a year is divisible by 4 and and not divisible by 100 OR year divisible by 400
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"{year} is a Leap Year");
            }
            else
            {
                Console.WriteLine($"{year} is not a Leap Year");
            }
        }
        //6.	A company decided to give bonus of 5% to employee if his/her year of service is more than 5 years.
        //Come up with a salary and year of service and print the net bonus amount.
        [Test]
        public void EmploueeBenefits()
        {
            var random6 = new Random();
            int yearStartJob = random6.Next(1990, 2019);
            string todayIs = DateTime.Now.ToString("yyyy");
            int salary = 75000;
            string notice;
            var totalYearsInJob = System.Convert.ToInt32(todayIs) - yearStartJob;
            if (totalYearsInJob >= 5)
            {
                notice = $"You are working {totalYearsInJob} years in the company. You get 5% extra bonus {salary * 0.05}.";
            }
            else
            {
                notice = $"You are working {totalYearsInJob} years in the company. You are NOT eligible for bonus. ";
            }
            Console.WriteLine(notice);
        }

        //7.	A school has following rules for grading system:
        //Ask user to enter marks and print the corresponding grade.
        //If the grade is greater than 60 – print out “Good Job!”, if it’s greater than 80 – print “Excellent!!!”
        [Test]
        public void GradingSystem()
        {
            var random7 = new Random();
            int grades = random7.Next(100);

            if (grades <= 25)
            {
                Console.WriteLine($"Your grade is F. You are fail. ");
            }
            else if (grades > 25 && grades < 45)
            {
                Console.WriteLine($"Your grade is E.  ");
            }
            else if (grades > 45 && grades < 50)
            {
                Console.WriteLine($"Your grade is D. ");
            }
            else if (grades > 50 && grades < 60)
            {
                Console.WriteLine($"Your grade is C. ");
            }
            else if (grades > 60 && grades < 80)
            {
                Console.WriteLine($"Your grade is B. GOOD JOB");
            }
            else
            {
                Console.WriteLine($"Your grade is A. Excellent!!! ");
            }

         }
        [Test]
        public void BMICalculate()
        {
            var random8 = new Random();
            double weight = random8.Next(75);
            double height = random8.Next(10);
            //Console.WriteLine("Please Enter your weight in  kg:");
            //double weight = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("Please Enter your height in meters:");
            //double height = Convert.ToDouble(Console.ReadLine());
            // double yourBMI = weight/ (height * height ) * 703(for lb and inch)

            double yourBMI = weight / (height / 100) * (height / 100);
            if (yourBMI < 18.5)
            {
                Console.WriteLine("You are undeweight.");
            }
            else if (yourBMI > 18.5 && yourBMI < 24.9)
            {
                Console.WriteLine("You are normal.");
            }
            else if (yourBMI > 25 && yourBMI < 29.9)
            {
                Console.WriteLine("You are overweight.");
            }
            else
            {
                Console.WriteLine("Obese");
            }
        }
        // Additional: 1.Write a program to print out an absolute value of a number
        [Test]
        public void Taks1()
        {
            int numberNegat = -10;
            int numberPositiv = 25;
            Console.WriteLine($"Your negative number {numberNegat} and absolute value of it number is : {Math.Abs(numberNegat)}.");
            Console.WriteLine($"Your positive number {numberPositiv} and absolute value of it number is : {Math.Abs(numberPositiv)}.");
        }
        // Additional: 2.	Write a program that accepts three numbers and prints "
        [Test]
        public void Task2()
        {
            int numb1 = 7;
            int numb2 = 7;
            int numb3 = 7;
            if (numb1 == numb2 && numb2 ==numb3 && numb3==numb1)
            {
                Console.WriteLine($"All numbers are equal");
            }
            else if (numb1 != numb2 && numb2 != numb3 && numb3 != numb1)
            {
                Console.WriteLine($"All numbers are NOT equal");
            }
            else
            {
                Console.WriteLine($"Neither all are equal or different");
            }
        }
        // Additional: 3 "increasing" if the numbers are in increasing order, "decreasing
        [Test]
        public void Task3()
        {
            int numb5 = 7;
            int numb6 = 8;
            int numb7 = 5;
            if (numb5 < numb6 && numb6 < numb7)
            {
                Console.WriteLine($"All numbers increasing");
            }
            else if (numb5 > numb6 && numb6 > numb7)
            {
                Console.WriteLine($"All numbers decreasing");
            }
            else
            {
                Console.WriteLine($"Neither increasing or decreasing order");
            }
        }
        // Additional: 4 4.	Take a phone number in format 888888 8888 and format it to (888) 888-8888
        
        [Test]
        public void Task4()
        {
            string phoneNumber = "1234567890";
           //double phone = Double.Parse(phoneNumber);
            Console.WriteLine($"Correct Phone number is {String.Format("{0:(###) ###-####}", Convert.ToInt64(phoneNumber))}");
        }
        // Additional: 5. Capitalize a first letter of a string
        [Test]
        public void Task5()
        {
            string firstLetter = "tomorrow will be colder";
            string remainLetter = string.Empty;
            string upperLetter = string.Empty;
            //TextInfo myTI = new CultureInfo("en-US").TextInfo;myTI.ToTitleCase
            {
                upperLetter = firstLetter.Substring(0, 1).ToUpper();
                if (firstLetter.Length > 1)
                {
                    remainLetter = firstLetter.Substring(1, firstLetter.Length - 1);
                }
            }
            Console.WriteLine($"You corrected sentence:  {upperLetter + remainLetter}");
        }

        // Additional: 5. Capitalize a first letter of a string
        [Test]
        public void Task6()
        {
            string firstLetter = "please take a warm jacket";
           
            string upperLetter = string.Empty;
            Console.WriteLine(char.ToUpper(firstLetter[0]) + ((firstLetter.Length > 1) ? firstLetter.Substring(1).ToLower() : string.Empty));

        }
    }
}
