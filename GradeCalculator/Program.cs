using System;

class GradeCalculator
{
   static void Main()
   {
      while (true)
      {
         Console.Clear();
         Console.WriteLine("=== GRADE CALCULATOR ===");
         Console.Write("Enter your grade (0-100): ");

         bool validInput = int.TryParse(Console.ReadLine(), out int grade);

         if (!validInput || grade < 0 || grade > 100)
         {
            Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
         }
         else
         {
            if (grade >= 90)
               Console.WriteLine("Your grade is: A");
            else if (grade >= 80)
               Console.WriteLine("Your grade is: B");
            else if (grade >= 70)
               Console.WriteLine("Your grade is: C");
            else if (grade >= 60)
               Console.WriteLine("Your grade is: D");
            else
               Console.WriteLine("Your grade is: F");
         }

         Console.WriteLine("\nWould you like to calculate another grade? (Y/N): ");
         string choice = Console.ReadLine()?.Trim().ToLower();

         if (choice != "y")
         {
            Console.WriteLine("Goodbye!");
            break;
         }
      }
   }
}
