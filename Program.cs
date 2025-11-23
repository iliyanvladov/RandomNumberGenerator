using System.Net.Mime;

namespace RandomNumberGenerator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Random Number Generator");
        string command = "";
        while (command != "3")
        {
            Console.WriteLine("\nSubmit one of the following commands");
            Console.WriteLine("1 - generate a number");
            Console.WriteLine("2 - options");
            Console.WriteLine("3 - end");
            command = Console.ReadLine();
            if (command == "1")
            {
                GenerateOneNumber();
            }
            else if (command == "2")
            {
                Options();
            }
            else if (command == "3")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid command!");
                continue;
            }
        }
    }

    static void GenerateOneNumber()
    {
        Random rnd = new Random();
        Console.Write("\nStart number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("End number: ");
        int b = int.Parse(Console.ReadLine());
        int randomNumber = rnd.Next(a, b);
        Console.WriteLine($"Result: {randomNumber}");
    }

    static void GenerateMultipleNumbers(int counts)
    {
        for (int i = 1; i <= counts; i++)
        {
            Console.WriteLine($"\nExecution {i}/{counts}");
            GenerateOneNumber();
        }
    }

    static void Options()
    {
        Console.WriteLine("\nOptions:");
        Console.WriteLine("1 - Choose how many numbers to generate");
        Console.WriteLine("2 - Go back");
        string optionsCommand = Console.ReadLine();
        if (optionsCommand == "1")
        {
            Console.WriteLine("\nHow many numbers to generate:");
            int numbersToGenerate = int.Parse(Console.ReadLine());
            GenerateMultipleNumbers(numbersToGenerate);
        }
        else if (optionsCommand == "2")
        {
            return;
        }
        else
        {
            Console.WriteLine("Invalid command!");
            Options();
        }
    }
}