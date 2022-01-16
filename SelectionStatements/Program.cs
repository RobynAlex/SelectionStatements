using System;

namespace SelectionStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var r = new Random();
            var favenumber = r.Next(1, 1000);

            Console.WriteLine("Pick a number 1 through 1000");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favenumber)
            {
                Console.WriteLine($"{userInput} is too low");
            }
            else if (userInput > favenumber)
            {
                Console.WriteLine($"{userInput} is too high");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
                

            //SWITCH CASE
            Console.WriteLine("What is your favorite school subject?");

            var subject = Console.ReadLine();

            switch(subject)
            {
                case "art":
                    Console.WriteLine("Art class is awesome!");
                    break;

                case "math":
                case "mathematics":
                    Console.WriteLine("I hate math, ew!");
                    break;

                case "science":
                    Console.WriteLine("Science is pretty cool.");
                    break;

                case "history":
                    Console.WriteLine("History is very intersting to learn.");
                    break;

                case "english":
                case "literature":
                    Console.WriteLine("That's boring but do you.");
                    break;
                default:
                    Console.WriteLine("I don't know that subject.");
                    break;
            }





        }
    }
}
