using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var ran = new Random();
            var favoriteNum = ran.Next(1, 100);

            Console.WriteLine("Enter a number to try and guess the same as me!");
            var userInput = int.Parse(Console.ReadLine());
                
                if (userInput > favoriteNum)
                {
                    Console.WriteLine("Sorry! That number is too high!");
                }
                else if (userInput == favoriteNum)
                {
                    Console.WriteLine("That's it! you got it! Nice Guess!");
                }
                else if (userInput < favoriteNum)
                {
                    Console.WriteLine("Sorry! That number is too low!");
                }
                else
                {
                    Console.WriteLine("NeverMind");
                }
                

            Console.WriteLine("What is your favorite coding language!:");
            string favSubj = Console.ReadLine();

            switch (favSubj)
            {
                case "C#":
                    Console.WriteLine("Seems like you're in the right place!");
                    break;
                case "Java":
                    Console.WriteLine("Java? ew...");
                    break;
                case "JavaScript":
                    Console.WriteLine("Ahh a man of class i see...");
                    break;
                case "HTML":
                    Console.WriteLine("So when is facebook2 releasing?");
                    break;
                case "Python":
                    Console.WriteLine("You run a mile in over 10 minutes don't you?");
                    break;
                default:
                    Console.WriteLine("C# is where to be around these parts...");
                    break;
            }
        }
    }
}
