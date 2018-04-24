using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the name you wish to be called: ");
            string name = Console.ReadLine();

            

            while (true)
            {
                Console.WriteLine($"Hello {name}! Now please enter a number between 1 and 100 below or \"quit\" to exit ");
                string input = Console.ReadLine().ToLower();

                if(input == "quit")
                {
                    break;
                }

                bool converted = int.TryParse(input, out int number);

                if (converted)
                {
                    if (number <= 100 && number >= 1)
                    {
                        if (number % 2 == 0 && number >= 2 && number <= 25)
                        {
                            Console.WriteLine("Even and less than 25.");
                        }
                        else if (number % 2 == 0 && number >= 26 && number <= 60)
                        {
                            Console.WriteLine("Even");
                        }
                        else if (number % 2 == 0 && number > 60)
                        {
                            Console.WriteLine($"{number} is Even.");
                        }
                        else if (number % 2 != 0 && number > 60)
                        {
                            Console.WriteLine($"{number} is Odd.");
                        }
                        else if (number % 2 != 0)
                        {
                            Console.WriteLine($"{number} is Odd.");
                        }
                        else
                        {
                            Console.WriteLine("You have broke the system somehow!");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"The inputted number {number} is not within the bounds of 1-100");
                    }
                }
                else
                {
                    Console.WriteLine("Not a valid input");
                }
            }
            
        }
    }
}
