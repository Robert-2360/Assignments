// Exercise 12.10: Shape Hierarchy

using System;

//Grade: 10
namespace Shape_Hierarchy
{
   public abstract class Shape
   {
   }

   public abstract class TwoDimensionalShape : Shape
   {
      public abstract double Area { get; }
   }

   public abstract class ThreeDimensionalShape : Shape
   {
      public abstract double Area { get; }
      public abstract double Volume { get; }
   }

   public class Circle : TwoDimensionalShape
   {
      private double Radius { get; set; }

      public Circle(double radius)
      {
         Radius = radius;
      }

      public override double Area
      {
         get { return Math.PI * Radius * Radius; }
      }
   }

   public class Square : TwoDimensionalShape
   {
      private double Length { get; set; }

      public Square(double length)
      {
         Length = length;
      }

      public override double Area
      {
         get { return Length * Length; }
      }
   }

   public class Sphere : ThreeDimensionalShape
   {
      private double Radius { get; set; }

      public Sphere(double radius)
      {
         Radius = radius;
      }

      public override double Area
      {
         get { return 4.0 * Math.PI * Radius * Radius; }
      }

      public override double Volume
      {
         get { return 4.0 / 3.0 * Math.PI * Radius * Radius * Radius; }
      }
   }

   public class Cube : ThreeDimensionalShape
   {
      private double Length { get; set; }

      public Cube(double length)
      {
         Length = length;
      }

      public override double Area
      {
         get { return 6.0 * Length * Length; }
      }

      public override double Volume
      {
         get { return Length * Length * Length; }
      }
   }

   public class TestShapeHierarchy
   {
      static void Main(string[] args)
      {
         Circle circle = new Circle(1.0);
         Square square = new Square(1.0);
         Sphere sphere = new Sphere(1.0);
         Cube cube = new Cube(1.0);

         Shape[] shapes = new Shape[4];

         shapes[0] = circle;
         shapes[1] = square;
         shapes[2] = sphere;
         shapes[3] = cube;

         foreach (Shape shape in shapes)
         {
            Console.WriteLine(shape);

            if (shape is TwoDimensionalShape)
            {
               TwoDimensionalShape twoDimensionalShape = (TwoDimensionalShape)shape;

               Console.WriteLine("Area: {0}", twoDimensionalShape.Area);
               Console.WriteLine();
            }

            if (shape is ThreeDimensionalShape)
            {
               ThreeDimensionalShape threeDimensionalShape = (ThreeDimensionalShape)shape;

               Console.WriteLine("Surface Area: {0}", threeDimensionalShape.Area);
               Console.WriteLine("Volume: {0}", threeDimensionalShape.Volume);
               Console.WriteLine();
            }
         }
      }
   }
}