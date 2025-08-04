using System;

class TicketPriceCalculator
{
   static void Main()
   {
      while (true)
      {
         Console.Clear();
         Console.WriteLine("=== TICKET PRICE CALCULATOR ===");
         Console.Write("Enter your age: ");

         bool validInput = int.TryParse(Console.ReadLine(), out int age);

         if (!validInput || age < 0 || age > 150)
         {
            Console.WriteLine("Invalid input. Please enter a valid age.");
         }
         else
         {
            double price = (age <= 12 || age >= 65) ? 7.00 : 10.00;
            Console.WriteLine($"Ticket Price: GHC{price}");
         }

         Console.WriteLine("\nWould you like to calculate another ticket? (Y/N): ");
         string choice = Console.ReadLine()?.Trim().ToLower();

         if (choice != "y")
         {
            Console.WriteLine("Thank you! Goodbye.");
            break;
         }
      }
   }
}
