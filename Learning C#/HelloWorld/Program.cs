using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            var age = Console.ReadLine();

            Console.WriteLine("What month were you born in?");
            var birth_month = Console.ReadLine();

            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your birth month is: {0}", birth_month);

            if (birth_month == "march")
            {
                Console.WriteLine("You are an Aries.");
            }
            else if (birth_month == "april")
            {
                Console.WriteLine("you are a Taurus.");
            }
            else if (birth_month == "may")
            {
                Console.WriteLine("you are a Gemini.");
            }
        }
    }
}
