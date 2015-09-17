// Exercise 4.10: GradeBookTest.cs
// Test program for the GradeBook class

using System;

public class GradeBookTest
{
   public static void Main(string[] args)
   {

      // initialize reference using constructor
      GradeBook gradeBook = new GradeBook("COP 2360  C# Programming", "April Graves");

      // display gradeBook with get property
      Console.WriteLine("gradeBook.CourseName value is: {0}", gradeBook.CourseName);
      Console.WriteLine("gradeBook.CourseInstructor value is: {0}", gradeBook.CourseInstructor);
      Console.WriteLine();

      // display gradeBook with method call
      gradeBook.DisplayMessage();

      // Freeze console window
      Console.ReadLine();
   }
}