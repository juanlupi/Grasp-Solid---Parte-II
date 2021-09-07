using System;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        public static void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine(recipe.GetRecipeText());
        }
        /*Cree la clase ConsolePrinter para que se encargue de hacer la impresión en consola
        como lo pedía la letra.
        Esto a su vez quita una responsabilidad de la clase Recipe, siguiendo el SRP  */
    }
}