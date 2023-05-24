using Cook_Book;
using System;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;

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
                Console.WriteLine("Display Recipe selected");
                break;
            case "3":
                Console.WriteLine("Change Serving Size selected");
                ingrediant.DisplayIngredient();.
                break;
            case "4":
                Console.WriteLine("Reset Scale selected");
                break;
            case "5":
                Console.WriteLine("Clear All Recipes selected");
                break;
            case "6":
                Console.WriteLine("Close selected");
                break;
            default:
                Console.WriteLine("Invalid selection");
                break;
        }
    }
}