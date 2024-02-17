using System;

class Program
{
    static void Main()
    {
        string userInput = "";
        string totalInput = "";
        Console.WriteLine("Enter text (type 'exit' to end program):");

        while ((userInput = Console.ReadLine()) != "exit")
        {
            totalInput += userInput + " ";
            Console.WriteLine("You entered: " + totalInput);
        }
        Console.WriteLine("Program terminated.");
    }
}
