using System;

namespace DisplayInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your firstname?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your lastname");
            string lasttName = Console.ReadLine();
            Console.WriteLine("what is your favorite number?");
            int favoriteNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your favorite animal?");
            string favoriteAnimal = Console.ReadLine();
            Console.WriteLine("Any other information you want to ask about?");
            Console.WriteLine(firstName + " " + lasttName);
            Console.WriteLine(favoriteNumber + " " + favoriteAnimal);
            if (favoriteNumber > 10)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(favoriteNumber);
            }
            else if (favoriteNumber <5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(favoriteNumber);
            }
        }

    }
}
