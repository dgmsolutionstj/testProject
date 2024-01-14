using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        //PrintToConsole();
        //VariablesAndDataTypes();
        //MathOperators();
        //ComparisonOperators();
        //LogicalOperators();
        ConditionalStatements();
    }

    static void PrintToConsole()
    {
        Console.WriteLine("Hello World!!");
    }

    // Variables and Data Types
    static void VariablesAndDataTypes()
    {
        //Working with numbers
        int age = 30;
        Console.WriteLine(age);

        int quantity; // you can also asign integers without the value. This variable is latter asign a value.

        float temperature = 20.4f;
        Console.WriteLine(temperature);

        double interest = 5.53;
        Console.WriteLine("Interest: " + interest);

        decimal stockPrice = 5.34765344M; // Remember to add the "M" in the end of the number when using decimal.
        Console.WriteLine("Stock Price: " + stockPrice);

        // Working with Strings
        char letter = 'A'; // This is use for a single character. char always goes with single quotes ''.
        Console.WriteLine(letter);

        string name = "Diego";
        string activity = "Walk";
        Console.WriteLine($"My name is {name}, and I like to {activity}"); // formated string with place holder {}.

        string product; // you can also asign strings without the value. This variable is latter asign a value.

        // Working with booloeans
        bool isStudent = true;
        Console.WriteLine(isStudent);

        // This is how to asign variables in a latter time.
        quantity = 5;
        product = "bananas";
        Console.WriteLine($"We have {quantity} of the {product}");

        const double Pi = 3.14;
        Console.WriteLine(Pi);
    }

    static void MathOperators()
    {
        int num1 = 34;
        int num2 = 15;

        int adition = num1 + num2;
        Console.WriteLine("This is a adition: " + adition); 

        int multiply = num1 * num2;
        Console.WriteLine("This is a multiply: " + multiply);

        int divide = num1 / num2;
        Console.WriteLine("I'm dividing num1 by num2: " + divide);

        int substract = num1 - num2;
        Console.WriteLine("I'm substraction num1 by num2: " + substract);

        // This is how you divide num1 by num2 but intead of getting the division, you are getting the reminder of the total
        int modulus = num1 % num2;
        Console.WriteLine("Here I'm getting the remainder: " + modulus);  

        // The way to handle error and to prevent that the program crash, add this to the program. How to Handle Errors

        try
        {
            int quotient = num1 / num2;
            Console.WriteLine(quotient);
        } catch (DivideByZeroException ex)
        {
            Console.WriteLine("An erreo ocurred: " + ex.Message);
        }

        int num3 = 105;
        double num3AsDouble = (Double) num3;
        Console.WriteLine(num3AsDouble);

    }

    static void ComparisonOperators()
    {
        int a = 10;
        int b = 15;

        bool isEqual = (a == b);
        Console.WriteLine(isEqual);

        bool notEqual = (a != b);
        Console.WriteLine(notEqual);

        bool isGreater = (a > b);
        Console.WriteLine(isGreater);

        bool isLess = (a < b);
        Console.WriteLine(isLess);

        bool isLessOrEqual = (a <= b);
        Console.WriteLine(isLessOrEqual);

        bool isGreaterOrEqual = (a >= b);   
        Console.WriteLine(isGreaterOrEqual);

    }

    static void LogicalOperators()
    {
        bool x = true;
        bool y = false;

        bool andResult = (x && y);
        Console.WriteLine(andResult);

        bool orResult = (x || y);
        Console.WriteLine(orResult);

        bool notResult1 = (x && !y);
        Console.WriteLine(notResult1);

        bool notResult2 = !x;
        Console.WriteLine(notResult2);
    }

    static void ConditionalStatements()
    {
        // Working with the if, else if, and else statement.
        int age = 24;

        if(age >= 18 && age <= 45)
        {
            Console.WriteLine("You can drive in our city");
        } else if (age >= 46)
        {
            Console.WriteLine("You are too old to drive in our city.");
        }
        else
        {
            Console.WriteLine("You are not old enough to drive in our city.");
        }

        // Working with the switch statement.


    }
}