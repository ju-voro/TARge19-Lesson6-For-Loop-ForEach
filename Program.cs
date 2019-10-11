using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1. Multiplication Table
            /*int userNumber;
            Console.WriteLine("Please, enter a number: ");
            userNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{userNumber} X {i} = {userNumber * i}");
            }

            Console.ReadLine();*/

            /* string name;
             Console.WriteLine("Enter your name: ");
             name = Console.ReadLine();

             int counter = 0;

             foreach(char letter in name)
             {
                 counter++;
             }

             Console.WriteLine($"Your name is {counter} letters long.");
             Console.ReadLine();*/

            /*string name;
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();

            bool letterFound = false;

            foreach(char letter in name)
            {
                if(letter == 'a')
                {
                    letterFound = true;
                    break;
                }
            }

            /*if(letterFound)
            {
                Console.WriteLine("Found an A!");
            }
            else
            {
                Console.WriteLine("There is no A in your name");
            }*/

            /* string result = letterFound ? "Includes an A" : "Doesn't include an A";
             Console.WriteLine(result);*/

            /*int aTotal = 0;
            string name;
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();

            for(int i = 0; i < name.Length; i++)
            {
                if(name[i] == 'a' || name[i] == 'A')
                {
                    aTotal++;
                }
            }


            Console.WriteLine($"There are {aTotal} \"A\" letters in your name.");*/

            /*string name;
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();*/

            /*foreach(char letter in name)
            {
                Console.Write($"{letter} ");
            }
            */

            /*for(int i = 0; i < name.Length; i++)
            {
                if (i == name.Length-1)
                {
                    Console.Write($"{name[i]}#");
                    break;
                }
                Console.Write($"{name[i]}*");

            }*/

            /*int i = 1;

            while(i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }*/

            string hello = "hello";
            int i = 0;

            while(i < hello.Length)
            {
                Console.WriteLine($"{hello[i]}*");
                i++;
            }

           

            Console.ReadLine();
        }
    }
}
