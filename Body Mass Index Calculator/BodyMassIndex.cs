// Exercise 3.31: Body Mass Index Calculator
// Calculate the Body Mass Index from console input

using System;

public class BodyMassIndex
{
    public static void Main(string[] args)
    {
        // Input user's weight
        Console.Write("Enter your weight in pounds: ");
        int weight = Convert.ToInt32(Console.ReadLine());

        // Input user's height
        Console.Write("Enter your height in inches: ");
        int height = Convert.ToInt32(Console.ReadLine());
        
        // Calculate BMI
        double bmi = weight * 703.0 / (height * height);

        // Display results
        Console.WriteLine();
        Console.WriteLine("Your Body Mass Index is: {0:F1}", bmi);

        // Display BMI table
        Console.WriteLine();
        Console.WriteLine("BMI VALUES");
        Console.WriteLine("Underweight: \t less than 18.5");
        Console.WriteLine("Normal: \t between 18.5 and 24.9");
        Console.WriteLine("Overweight: \t between 25 and 29.9");
        Console.WriteLine("Obese: \t\t 30 or greater");

        // Determine user's BMI status
        string bmiStatus = "";
        if (bmi < 18.5) bmiStatus = "Underweight";
        else if (bmi <= 24.9) bmiStatus = "Normal";
        else if (bmi <= 29.9) bmiStatus = "Overweight";
        else bmiStatus = "Obese";

        // Display user's BMI status
        Console.WriteLine();
        Console.WriteLine("Based on the table above");
        Console.WriteLine("Your BMI status is {0}", bmiStatus);     

        // Freeze console window
        Console.ReadLine();
    }
}