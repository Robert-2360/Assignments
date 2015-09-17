// Execise 4.10: GradeBook.cs
// GradeBook class with a constructor to initialize the course name.

using System;

public class GradeBook
{
    // auto-implemented property for instance variables
    public string CourseName { get; set; }
    public string CourseInstructor { get; set; }

    // constructor initializes auto-implemented properties
    public GradeBook(string name, string instructor)
    {
        CourseName = name;
        CourseInstructor = instructor;
    }

    // display welcome message
    public void DisplayMessage()
    {
        Console.WriteLine("Welcome to the grade book for");
        Console.WriteLine(CourseName);
        Console.WriteLine("This course is presented by: {0}", CourseInstructor);
    }
}