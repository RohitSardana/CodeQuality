using System;
using App.BL;
using App.Service;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Calculator.");
            ConsoleKey keyPressed = ConsoleKey.Escape;
            do
            {
                Console.WriteLine("Specify first number");
                string number1 = Console.ReadLine();
                Console.WriteLine("Specify second number");
                string number2 = Console.ReadLine();
                Console.WriteLine(
                    "Choose the operation to be performed \r\n Type A for Addition, Type S for Subtraction");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                ICalService calService = new CalService(new CalculatorBl());
                int result;
                switch (keyInfo.Key)
                {
                    case ConsoleKey.A:
                    {
                        result = calService.Add(number1, number2);
                        break;
                    }
                    case ConsoleKey.S:
                    {
                        result = calService.Subtract(number1, number2);
                        break;
                    }
                    default:
                        throw new NotSupportedException("The operation specified is not supported.");
                }
                Console.WriteLine($"Result:  {result}");
                Console.WriteLine("Escape to exit.");
                keyPressed = Console.ReadKey().Key;
            }
            while (keyPressed != ConsoleKey.Escape);     
        }
    }
}