// Exercise 3.15: Arithmetic
// Input two integers from the console window
//    and perform basic integer math operations on them.

using System;

public class Arithmetic
{
    public static void Main(string[] args)
    {
        // Input first integer
        Console.Write("Enter first integer: ");
        int integer1 = Convert.ToInt32(Console.ReadLine());

        // Input second integer
        Console.Write("Enter second integer: ");
        int integer2 = Convert.ToInt32(Console.ReadLine());

        // Perform basic integer math operations
        int sum = integer1 + integer2;
        int product = integer1 * integer2;
        int difference = integer1 - integer2;
        int quotient = integer1 / integer2;
        int remainder = integer1 % integer2;

        // Display results
        Console.WriteLine();
        Console.WriteLine("integer1 + integer2 = {0}", sum);
        Console.WriteLine("integer1 * integer2 = {0}", product);
        Console.WriteLine("integer1 - integer2 = {0}", difference);
        Console.WriteLine("integer1 / integer2 = {0}", quotient);
        Console.WriteLine("integer1 % integer2 = {0}", remainder);


        // Freeze console window
        Console.ReadLine();
    }
}