using FactoryMethodDesert.Interfaces;

namespace FactoryMethodDesert.Models;

public class Cake: IDessert
{
    public string Name => "Cake";
    public List<string> Ingredients { get;  }= new List<string>();
    public List<string> Toppings { get;  }= new List<string>();
    public List<string> Sauces { get;  }= new List<string>();
    public void DisplayDesserts()
    {
        Console.WriteLine($"{Name} Recipe:");
        Console.WriteLine("Ingredients:");
        foreach (var ingredient in Ingredients) Console.WriteLine($"- {ingredient}");
        Console.WriteLine("Toppings:");
        foreach (var topping in Toppings) Console.WriteLine($"- {topping}");
        Console.WriteLine("Sauces:");
        foreach (var sauce in Sauces) Console.WriteLine($"- {sauce}");
    }
}