using System;

class QuadraticEquationSolver
{
     static void Main()
     {
         double a, b, c;

         // Entering coefficients of a quadratic equation
         Console.Write("Enter coefficient a: ");
         a = Convert.ToDouble(Console.ReadLine());

         Console.Write("Enter coefficient b: ");
         b = Convert.ToDouble(Console.ReadLine());

         Console.Write("Enter coefficient c: ");
         c = Convert.ToDouble(Console.ReadLine());

         // Calculate the discriminant
         double discriminant = b * b - 4 * a * c;

         // Check the discriminant value
         if (discriminant > 0)
         {
             double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
             double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
             Console.WriteLine($"The equation has two roots: {root1} and {root2}");
         }
         else if (discriminant == 0)
         {
             double root = -b / (2 * a);
             Console.WriteLine($"The equation has one root: {root}");
         }
         else
         {
             Console.WriteLine("The equation has no real roots.");
         }
     }
}
