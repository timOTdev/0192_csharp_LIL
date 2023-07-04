using System;

namespace PassCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // Passcode Challenge
            Console.WriteLine("What is your passcode?");
            var passcode = Console.ReadLine();

            if (passcode == "secret")
            {
                Console.WriteLine("You are authenticated.");
            }
            else
            {
                Console.WriteLine("We could not authenticate you.");
            }
        }
    }
}
