using Cook_Book;
using System;
using static System.Net.Mime.MediaTypeNames; 
using System.Diagnostics;
// Initialize ingredianr delegate.
delegate void IngredientDelegate(string name, int quantity, string unit);
class Program
{
    static void Main(string[] args)
    {


        // Display menu options
        Console.WriteLine("Select an option:");
        Console.WriteLine("1. New Recipe.");
        Console.WriteLine("2. Display Recipe.");
        Console.WriteLine("3. Change Serving Size.");
        Console.WriteLine("4. Reset Scale.");
        Console.WriteLine("5. Clear All Recipes.");
        Console.WriteLine("6. Close.");

        // Read user input
        string input = Console.ReadLine();
        Ingrediant ingrediant = new Ingrediant();

        // Process user input using switch statement
        switch (input)
        {
            case "1":
                Console.WriteLine("New Recipe selected");
                ingrediant.IngrediantCapture();
                Console.WriteLine("New ingrediant created!");
                Main(args);
                break;
            case "2":
                IngredientDelegate ingredientDelegate = new IngredientDelegate(DisplayIngredient);
                ingredientDelegate("Sugar", 2, "cups");
                // Method for Option 2: Display Ingrediant delagate.
                static void DisplayIngredient(string name, int quantity, string unit)
                {
                    Console.WriteLine("{0} {1} {2}", name, quantity, unit);
                }
                Main(args);
                break;
            case "3":
                Console.WriteLine("Change Serving Size selected");
                break;
            case "4":
                Console.WriteLine("Reset Scale selected");
                // Reset the delegate values
                static void ResetValues(string name, int quantity, string unit)
                {
                // Reset the values here
                static void ResetValues(string name, int quantity, string unit)
                {
                    name = "";
                    quantity = 0;
                    unit = "";
                }
                }
                break;
            case "5":
                Console.WriteLine("Clear All Recipes selected");
                break;
            case "6":
                Console.WriteLine("Closing application..." +
                    "\nGoodbye." +
                    "\n:)");
                System.Environment.Exit(1);
                break;
            default:
                Console.WriteLine("Invalid selection");
                break;
        }
    }
}
