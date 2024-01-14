using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        // Uncomment any function and then run it.

        //PrintToConsole();
        //VariablesAndDataTypes();
        //MathOperators();
        //ComparisonOperators();
        //LogicalOperators();
        //ConditionalStatements();
        Loops();
    }

    static void PrintToConsole()
    {
        // Prints a simple message to the console.
        Console.WriteLine("Hello World!!");
    }

    // Variables and Data Types
    static void VariablesAndDataTypes()
    {
        // Working with numbers
        int age = 30;  // Declares and initializes an integer variable.
        Console.WriteLine(age);

        int quantity;  // Declares an integer variable without initializing it.

        float temperature = 20.4f;  // Declares and initializes a float variable.
        Console.WriteLine(temperature);

        double interest = 5.53;  // Declares and initializes a double variable.
        Console.WriteLine("Interest: " + interest);

        decimal stockPrice = 5.34765344M;  // Declares and initializes a decimal variable.
        Console.WriteLine("Stock Price: " + stockPrice);

        // Working with Strings
        char letter = 'A';  // Declares and initializes a character variable.
        Console.WriteLine(letter);

        string name = "Diego";  // Declares and initializes a string variable.
        string activity = "Walk";
        Console.WriteLine($"My name is {name}, and I like to {activity}");  // Formatted string with placeholders.

        string product;  // Declares a string variable without initializing it.

        // Working with booleans
        bool isStudent = true;  // Declares and initializes a boolean variable.
        Console.WriteLine(isStudent);

        // Variable assignment at a later time
        quantity = 5;
        product = "bananas";
        Console.WriteLine($"We have {quantity} of the {product}");

        const double Pi = 3.14;  // Declares and initializes a constant variable.
        Console.WriteLine(Pi);
    }

    static void MathOperators()
    {
        int num1 = 34;
        int num2 = 15;

        int addition = num1 + num2;  // Adds two integers.
        Console.WriteLine("This is an addition: " + addition);

        int multiply = num1 * num2;  // Multiplies two integers.
        Console.WriteLine("This is a multiplication: " + multiply);

        int divide = num1 / num2;  // Divides two integers.
        Console.WriteLine("I'm dividing num1 by num2: " + divide);

        int subtract = num1 - num2;  // Subtracts two integers.
        Console.WriteLine("I'm subtracting num1 by num2: " + subtract);

        // Calculates the remainder when dividing num1 by num2.
        int modulus = num1 % num2;
        Console.WriteLine("Here I'm getting the remainder: " + modulus);

        // Handling division by zero using try-catch block
        try
        {
            int quotient = num1 / num2;
            Console.WriteLine(quotient);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }

        int num3 = 105;
        double num3AsDouble = (Double)num3;  // Converts an integer to a double.
        Console.WriteLine(num3AsDouble);
    }

    static void ComparisonOperators()
    {
        int a = 10;
        int b = 15;

        bool isEqual = (a == b);  // Checks if two values are equal.
        Console.WriteLine(isEqual);

        bool notEqual = (a != b);  // Checks if two values are not equal.
        Console.WriteLine(notEqual);

        bool isGreater = (a > b);  // Checks if a is greater than b.
        Console.WriteLine(isGreater);

        bool isLess = (a < b);  // Checks if a is less than b.
        Console.WriteLine(isLess);

        bool isLessOrEqual = (a <= b);  // Checks if a is less than or equal to b.
        Console.WriteLine(isLessOrEqual);

        bool isGreaterOrEqual = (a >= b);  // Checks if a is greater than or equal to b.
        Console.WriteLine(isGreaterOrEqual);
    }

    static void LogicalOperators()
    {
        bool x = true;
        bool y = false;

        bool andResult = (x && y);  // Logical AND - true if both x and y are true.
        Console.WriteLine(andResult);

        bool orResult = (x || y);  // Logical OR - true if either x or y is true.
        Console.WriteLine(orResult);

        bool notResult1 = (x && !y);  // Logical NOT - negates the value of y.
        Console.WriteLine(notResult1);

        bool notResult2 = !x;  // Logical NOT - negates the value of x.
        Console.WriteLine(notResult2);
    }

    static void ConditionalStatements()
    {
        // Working with the if, else if, and else statement.
        int age = 24;

        if (age >= 18 && age <= 45)
        {
            Console.WriteLine("You can drive in our city");
        }
        else if (age >= 46)
        {
            Console.WriteLine("You are too old to drive in our city.");
        }
        else
        {
            Console.WriteLine("You are not old enough to drive in our city.");
        }

        // Working with the switch statement.
        int day = 5;

        string dayName;

        switch (day)
        {
            case 1:
                dayName = "Monday";
                break;
            case 2:
                dayName = "Tuesday";
                break;
            case 3:
                dayName = "Wednesday";
                break;
            case 4:
                dayName = "Thursday";
                break;
            case 5:
                dayName = "Friday";
                break;
            default:
                dayName = "Weekend";
                break;
        }

        Console.WriteLine("Today is " + dayName);
    }

    // Working with Loops in C#
    static void Loops()
    {
        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine("Number: " + i);  // Prints numbers from 0 to 5.
        }

        int count = 0;

        while (count < 5)
        {
            Console.WriteLine("While count " + count);  // Prints numbers using a while loop.
            count++;
        }

        count = 0;

        do
        {
            Console.WriteLine("Do-while count: " + count);  // Prints numbers using a do-while loop.
            count++;
        } while (count < 10);

        int[] numbers = { 1, 2, 3, 4, 5, 6, };

        foreach (int number in numbers)
        {
            Console.WriteLine("Number in array: " + number);  // Prints numbers from an array using a foreach loop.
        }
    }
}