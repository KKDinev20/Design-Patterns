using FactoryMethodDesert.Interfaces;

namespace FactoryMethodDesert.Builders;

public class DessertBuilder
{
    private readonly IDessert _dessert;

    public DessertBuilder(IDessert dessert)
    {
        _dessert = dessert;
    }

    public DessertBuilder AddIngredients(string ingredient)
    {
        
        _dessert.Ingredients.Add(ingredient);
        return this;
    }
    public DessertBuilder AddToppings(string topping)
    {
        
        _dessert.Toppings.Add(topping);
        return this;
    }
    public DessertBuilder AddSauces(string sauce)
    {
        
        _dessert.Sauces.Add(sauce);
        return this;
    }

    public IDessert Build()
    {
        return _dessert;
    }
}