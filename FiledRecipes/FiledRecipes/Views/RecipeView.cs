using FiledRecipes.Domain;
using FiledRecipes.App.Mvp;
using FiledRecipes.Properties;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FiledRecipes.Views
{
    /// <summary>
    /// 
    /// </summary>
    public class RecipeView : ViewBase, IRecipeView
    {
        public void Show(IRecipe recipe)
        {
            Console.Clear();
            Header = recipe.Name;
            ShowHeaderPanel();
            Console.WriteLine();
            Console.WriteLine("Ingredienser");
            Console.WriteLine("============");
            foreach (Ingredient ingredient in recipe.Ingredients) 
            {
                Console.WriteLine(ingredient.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("Gör så här");
            Console.WriteLine("==========");
            int number = 0;
            foreach (string instruktion in recipe.Instructions)
            {
                number++;
                Console.WriteLine(string.Format("<{0}>", number));
                Console.WriteLine(instruktion);
            }           
        }

        public void Show(IEnumerable<IRecipe> recipes)
        {            
            foreach (Recipe recipe in recipes) 
            {
                Console.Clear();
                Header = recipe.Name;
                ShowHeaderPanel();
                
                Console.WriteLine();
                Console.WriteLine("Ingredienser");
                Console.WriteLine("============");
                foreach (Ingredient ingredient in recipe.Ingredients)
                {
                    Console.WriteLine(ingredient.ToString()); 
                }
                int number = 0;
                Console.WriteLine();
                Console.WriteLine("Gör så här");
                Console.WriteLine("==========");
                foreach (string instruktion in recipe.Instructions)
                {
                    number++;
                    Console.WriteLine(string.Format("<{0}>", number));
                    Console.WriteLine(instruktion); 
                }
                ContinueOnKeyPressed();
            }                     
        }
    }
}
