

/// Chapter No. 1		Exercise No. 2
/// File Name: Homework1-Lab2
/// @author: Balaji Venkataraman
/// Date:  August 26, 2021
///
/// Problem Statement: Write a program that displays a simple picture of your choice. 
/// 
/// 
/// Overall Plan:
/// 1) Write a sequence of WriteLine statements that display lines of asterisks or other characters and blanks. 
/// 2) PrintScreen the results.
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1_Lab2
{
    class FavoritePicture
    {
        static void Main(string[] args)
        {
            // print a message to the screen
            Console.WriteLine("Hello there. I will print (1) a simple Diode or (2) a Zener Diode");
            Console.WriteLine("Which one do you want? Enter 1 or 2. Any other number will not print diodes.");

            // declare an integer variable for user choice
            int nUserChoice;

            // Read userchoice as a string, and then convert it to an integer
            string userInput;
            userInput = Console.ReadLine();
            nUserChoice = Int32.Parse(userInput);

            Console.WriteLine("");
            Console.WriteLine("");

            if (nUserChoice == 1 || nUserChoice == 2)
            {
                if (nUserChoice == 1)
                    Console.WriteLine("Simple Diode");
                else
                    Console.WriteLine("Zener Diode");
                Console.WriteLine("");

                //print the diode of user's choice on the screen               
                for (int i = 0; i < 3; i++)
                    Console.WriteLine("      |");

                if (nUserChoice == 1)
                {
                    for (int i = 0; i < 12; i++)
                        Console.Write("_");
                }
                else
                {
                    Console.Write("\\");
                    for (int i = 0; i < 10; i++)
                        Console.Write("_");

                }
                Console.WriteLine("");

                for (int i = 0; i < 5; i++)
                {
                    for (int j = i; j < 5; j++)
                        Console.Write(" ");
                    Console.Write("/");

                    for (int k = 0; k < 2 * i; k++)
                        Console.Write(" ");
                    Console.Write("\\");

                    if (nUserChoice == 2 && i == 0)
                    {
                        Console.Write("    \\");
                    }

                    Console.WriteLine("");
                }

                Console.Write(" ");
                for (int i = 0; i < 10; i++)
                    Console.Write("-");
                Console.WriteLine("");

                for (int i = 0; i < 4; i++)
                    Console.WriteLine("      |");
                Console.WriteLine("");

                //pause the screen
                Console.ReadLine();
            }
        }
    }
}
