using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Initialize ingredianr delegate.
delegate void IngredientDelegate(string name, int quantity, string unit);

namespace Cook_Book
{
    class Ingrediant

    {
        public void IngrediantCapture()
        {

            // Prompt the user to enter the number of ingredients.
            Console.WriteLine("Enter the number of ingredients:");

            // Read the number of ingredients entered by the user.
            int numIngredients = int.Parse(Console.ReadLine());

            // Create an instance of the IngredientDelegate delegate and assign it to a variable called ingredientDelegate.
            IngredientDelegate ingredientDelegate = new IngredientDelegate(AddIngredient);

            // Loop through each ingredient and prompt the user to enter its name, quantity, and unit of measurement.
            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine("Enter the name of ingredient " + (i + 1) + ":");
                string name = Console.ReadLine();

                Console.WriteLine("Enter the quantity of ingredient " + (i + 1) + ":");
                int quantity = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the unit of measurement for ingredient " + (i + 1) + ":");
                string unit = Console.ReadLine();

                // Call the AddIngredient method using the ingredientDelegate delegate and pass in the name, quantity, and unit of measurement for each ingredient.
                ingredientDelegate(name, quantity, unit);
            }

            // Prompt the user to enter the number of steps.
            Console.WriteLine("Enter the number of steps:");

            // Read the number of steps entered by the user.
            int numSteps = int.Parse(Console.ReadLine());

            // Create an array called steps with a length equal to numSteps.
            string[] steps = new string[numSteps];

            // Loop through each step and prompt the user to enter it.
            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine("Enter step " + (i + 1) + ":");
                steps[i] = Console.ReadLine();
            }

            // Print out all of the ingredients using the PrintIngredient method.
            Console.WriteLine("Recipe:");
            ingredientDelegate = new IngredientDelegate(PrintIngredient);
            ingredientDelegate(null, 0, null);

            // Print out all of the steps using string.Join method.
            Console.WriteLine(string.Join(", ", steps));
        }

        // Method that adds an ingredient to a recipe.
        static void AddIngredient(string name, int quantity, string unit)
        {
            Console.WriteLine(quantity + " " + unit + " of " + name);
        }

        // Method that prints out all of the ingredients in a recipe.
        static void PrintIngredient(string name, int quantity, string unit)
        {
        }
    }
}