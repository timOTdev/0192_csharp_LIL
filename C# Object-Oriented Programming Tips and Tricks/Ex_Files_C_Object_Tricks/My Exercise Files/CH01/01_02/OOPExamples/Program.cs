using OOPExamples;
using System;

class Program
{
    static void Main(string[] args)
    {

        var comp = new Computer();

        Console.WriteLine("Computer Type - " + comp.GetType());
        // OUTPUT <> Computer Type - OOPExamples.Computer
        // OOPExamples is the namespace
        // Computer is the class

        // Determine if a variable is a particular type of class
        // Returns a boolean
        var isComputer = comp is Computer;

        Console.WriteLine("Is computer - " + isComputer);
        // OUTPUT <> "Is computer - true"

        Console.Read(); // Keeps window open

    }
}

