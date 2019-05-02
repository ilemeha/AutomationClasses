using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareTests.ClassWork
{
    public class ClassWork9
    {
        [Test]
        public void Loops()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"#{i}Tanya, I am sorry");
                if (i == 5)
                {
                    break; //continue;
                }
                Console.WriteLine($"Done For");
            }
            int counter = 0;
            while (counter < 10)//==for(;true;)
            {
                counter++;
                Console.WriteLine($"Tanya, I am sorry");
            }
            Console.WriteLine($"Done While");

            int counter1 = 0;
            do
            {
                counter1++;
                Console.WriteLine($"#{counter1}Tanya, I am sorry");
            } while (counter1 < 1);

            Console.WriteLine($"Done DO..While");
        }

        [Test]
        public void Test1()
        {
            for (int i = 1; i <= 20 ; i++)
            {
                Console.WriteLine($"#{i}");
            }
        }
        [Test]
        public void Test2()
        {
            for (int i = 2; i <= 20; i = i+2)
            {
             
                Console.WriteLine($"#{i}");
            }
        }

        [Test]
        public void Test3()
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"{i} {IsEven(i)}");
                if (IsEven(i) )
                {
                  Console.WriteLine($"#{i}");
                }
               
            }
        }
        
        public bool IsEven(int number)
        {     
         return number % 2 == 0;   
        }
        [Test]
        public void AddNumber()
        {
            int x = 0;
            for (int index = 1; index < 10; index++)
            {        
                x = x + index;  
            }
            Console.WriteLine($"#{x}");
        }


    }
}
