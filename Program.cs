using System;

class Program
{
    static void Main(string[] args)
    {
        bool keepRunning = true;

        while (keepRunning)
        {
            Console.WriteLine("=== Calculator App ===");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Power (x^y)");
            Console.WriteLine("6. Square Root");
            Console.WriteLine("7. Clear Screen");
            Console.WriteLine("8. Exit");
            Console.Write("Choose an option: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PerformOperation("add");
                    break;
                case "2":
                    PerformOperation("subtract");
                    break;
                case "3":
                    PerformOperation("multiply");
                    break;
                case "4":
                    PerformOperation("divide");
                    break;
                case "5":
                    PerformOperation("power");
                    break;
                case "6":
                    PerformSquareRoot();
                    break;
                case "7":
                    Console.Clear();
                    break;
                case "8":
                    keepRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid option, try again.");
                    break;
            }

            Console.WriteLine(); // blank line for readability
        }
    }

    static void PerformOperation(string operation)
    {
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        switch (operation)
        {
            case "add":
                result = num1 + num2;
                break;
            case "subtract":
                result = num1 - num2;
                break;
            case "multiply":
                result = num1 * num2;
                break;
            case "divide":
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Cannot divide by zero!");
                    return;
                }
                result = num1 / num2;
                break;
            case "power":
                result = Math.Pow(num1, num2);
                break;
        }

        Console.WriteLine($"Result: {result}");
    }

    static void PerformSquareRoot()
    {
        Console.Write("Enter a number: ");
        double num = Convert.ToDouble(Console.ReadLine());

        if (num < 0)
        {
            Console.WriteLine("Error: Cannot calculate square root of a negative number!");
            return;
        }

        double result = Math.Sqrt(num);
        Console.WriteLine($"Result: {result}");
    }
}
