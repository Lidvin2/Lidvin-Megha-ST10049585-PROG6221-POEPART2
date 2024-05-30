using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_POEPART2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Recipe> recipes = new List<Recipe>();

            // Example to add and display recipes
            Recipe recipe1 = new Recipe("Pasta");
            recipe1.AddIngredient(new Ingredient("Noodles", 200, "Grains"));
            recipe1.AddIngredient(new Ingredient("Tomato Sauce", 100, "Vegetables"));
            recipe1.OnCaloriesExceeded += message => Console.WriteLine(message);

            recipes.Add(recipe1);

            // Display recipes in alphabetical order
            foreach (var recipe in recipes.OrderBy(r => r.Name))
            {
                Console.WriteLine(recipe.Name);
            }

            // Select a recipe to display
            string selectedRecipeName = "Pasta"; // Example selection
            Recipe selectedRecipe = recipes.FirstOrDefault(r => r.Name == selectedRecipeName);
            if (selectedRecipe != null)
            {
                Console.WriteLine($"Recipe: {selectedRecipe.Name}");
                Console.WriteLine("Ingredients:");
                foreach (var ingredient in selectedRecipe.Ingredients)
                {
                    Console.WriteLine($"- {ingredient.Name}, {ingredient.Calories} calories, {ingredient.FoodGroup}");
                }

                int totalCalories = selectedRecipe.CalculateTotalCalories();
                Console.WriteLine($"Total Calories: {totalCalories}");
            }
            Console.ReadKey();
        }
    }
}
