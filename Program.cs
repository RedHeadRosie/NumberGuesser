using System;
using System.Collections.Generic;

namespace NumberGuesser
{
    class Program
    {
        static void ShowGreeting()
        {
            Console.WriteLine("Greetings. I am the Number Guesser.");
            Console.WriteLine();
            Console.WriteLine("Please think of, but DO NOT tell me, a number between 1 and 1024.");
            Console.WriteLine();
            Console.WriteLine("Using my amazing computer power, I will figure out your number...");
            Console.WriteLine();
        }

        static void BragWhenCorrect()
        {
            Console.WriteLine();
            Console.WriteLine("Nice one! I managed to outsmart you and guessed your number correctly!");
            Console.WriteLine();
            Console.WriteLine("Better luck next time!");
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            ShowGreeting();
            var BigLittleMiddleList = new List<int>() { 0, 1024, 0 };
            int guess = 0;
            string feedback = "";
            int range = BigLittleMiddleList[1] - BigLittleMiddleList[0];
            int middle = 0;
            guess = range / 2;
            BigLittleMiddleList[2] = guess;
            Console.WriteLine($"the int guess is currently {BigLittleMiddleList[2]}");


            while (feedback != "CORRECT")
            {
                Console.Write($"My guess is {BigLittleMiddleList[2]}. Is your number HIGHER, LOWER or am I CORRECT? ");
                feedback = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine($"You answered {feedback}");
                Console.WriteLine();

                if (feedback == "HIGHER")
                {
                    BigLittleMiddleList[0] = BigLittleMiddleList[2];
                    range = BigLittleMiddleList[1] - BigLittleMiddleList[0];
                    middle = range / 2;
                    guess = BigLittleMiddleList[2];
                    BigLittleMiddleList[2] = guess + middle;

                }
                else if (feedback == "LOWER")
                {
                    BigLittleMiddleList[1] = BigLittleMiddleList[2];
                    range = BigLittleMiddleList[1] - BigLittleMiddleList[0];
                    middle = range / 2;
                    guess = BigLittleMiddleList[2];
                    BigLittleMiddleList[2] = guess - middle;
                }
                else if (feedback != "HIGHER" & feedback != "LOWER" & feedback != "CORRECT")
                {
                    Console.WriteLine("Your answer is not clear, please write either HIGHER, LOWER or CORRECT");
                    Console.WriteLine();
                    //then enter loop again
                }
            }

            BragWhenCorrect();

        }


    }
}
