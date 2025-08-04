using System;

class TriangleTypeIdentifier
{
   static void Main()
   {
      while (true)
      {
         Console.Clear();
         Console.WriteLine("=== TRIANGLE TYPE IDENTIFIER ===");

         // Get 3 valid sides from the user
         double a = GetSide("A");
         double b = GetSide("B");
         double c = GetSide("C");

         // Check if it forms a valid triangle
         if (IsValidTriangle(a, b, c))
         {
            if (a == b && b == c)
               Console.WriteLine("Triangle Type: Equilateral");
            else if (a == b || b == c || a == c)
               Console.WriteLine("Triangle Type: Isosceles");
            else
               Console.WriteLine("Triangle Type: Scalene");
         }
         else
         {
            Console.WriteLine("This is not a valid triangle.");
         }

         Console.WriteLine("\nWould you like to check another triangle? (Y/N): ");
         string choice = Console.ReadLine()?.Trim().ToLower();

         if (choice != "y")
         {
            Console.WriteLine("Goodbye!");
            break;
         }
      }
   }

   static double GetSide(string name)
   {
      double side;
      while (true)
      {
         Console.Write($"Enter side {name}: ");
         bool valid = double.TryParse(Console.ReadLine(), out side);

         if (valid && side > 0)
            return side;
         else
            Console.WriteLine("Invalid input. Please enter a positive number.");
      }
   }

   static bool IsValidTriangle(double a, double b, double c)
   {
      return a + b > c && a + c > b && b + c > a;
   }
}
