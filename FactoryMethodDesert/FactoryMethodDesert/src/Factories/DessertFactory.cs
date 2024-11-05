using FactoryMethodDesert.Interfaces;
using FactoryMethodDesert.Models;

namespace FactoryMethodDesert.Factories;

public class DessertFactory
{
    public static IDessert CreateDessert(string dessertType)
    {
            return dessertType.ToLower() switch
            {
                "icecream" => new IceCreamSundae(),
                "cake" => new Cake(),
                _ => throw new ArgumentException("Unknown dessert type.")
            };
    }
}