using System;

class Program
{
    static void Main()
    {
        string userInput = "";
        Console.WriteLine("Enter text (type 'exit' to end program):");

        while ((userInput = Console.ReadLine()) != "exit")
        {
            Console.WriteLine("You entered: " + userInput);
        }
        Console.WriteLine("Program terminated.");
    }
}
