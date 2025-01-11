using System;

class Calculator
{
    static void Main()
    {
        double firstNum, secondNum, result;
        string operation;

        Console.WriteLine("Welcome to the Console Calculator!");
        
        while (true)
        {
            // Get first number from the user
            Console.Write("Enter the first number: ");
            firstNum = Convert.ToDouble(Console.ReadLine());

            // Get the operator
            Console.Write("Enter the operator (+, -, *, /): ");
            operation = Console.ReadLine();

            // Get the second number
            Console.Write("Enter the second number: ");
            secondNum = Convert.ToDouble(Console.ReadLine());

            // Perform the calculation based on the operator
            switch (operation)
            {
                case "+":
                    result = firstNum + secondNum;
                    break;
                case "-":
                    result = firstNum - secondNum;
                    break;
                case "*":
                    result = firstNum * secondNum;
                    break;
                case "/":
                    if (secondNum != 0)
                    {
                        result = firstNum / secondNum;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        continue;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator. Please try again.");
                    continue;
            }

            // Display the result
            Console.WriteLine($"Result: {firstNum} {operation} {secondNum} = {result}");

            // Ask if the user wants to continue
            Console.Write("Do you want to perform another calculation? (y/n): ");
            string answer = Console.ReadLine();
            if (answer.ToLower() != "y")
            {
                break;
            }
        }

        Console.WriteLine("Thank you for using the calculator! Goodbye!");
    }
}
