using System;

namespace TemplatePattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Coffee coffee = new Coffee();
            Tea tea = new Tea();

            Console.WriteLine("Preparing Coffee....");
            coffee.PrepareRecipe();

            Console.WriteLine("\nPreparing Tea....");
            tea.PrepareRecipe();

            Console.Read();
        }
    }
}