
using System;
using FactoryMethodDesert.Builders;
using FactoryMethodDesert.Factories;
using FactoryMethodDesert.Interfaces;

namespace FactoryMethodDessert
{
    class Program
    {
        static void Main(string[] args)
        {
            IDessert iceCreamSundae = DessertFactory.CreateDessert("icecream");
            IDessert cake = DessertFactory.CreateDessert("cake");
            
            var sundaeBuilder = new DessertBuilder(iceCreamSundae);
            var cakeBuilder = new DessertBuilder(cake);

            cakeBuilder.AddIngredients("1 cup white sugar")
                .AddIngredients("1/2 cup unsalted butter")
                .AddIngredients("2 large eggs")
                .AddIngredients("2 teaspoons vanilla extract")
                .AddIngredients("1 1/2 cups all-purpose flour")
                .AddSauces("Cholocate Syrup")
                .AddToppings("Coconut");
            
            
            sundaeBuilder.AddIngredients("Vanilla Ice Cream")
                .AddSauces("Chocolate Syrup")
                .AddToppings("Whipped Cream")
                .AddToppings("Chopped Nuts")
                .AddIngredients("Cherry on Top")
                .Build();
            
            cake.DisplayDesserts();
            Console.WriteLine("--------------------------------");
            iceCreamSundae.DisplayDesserts();
            
            Console.WriteLine();
        }
    }
}