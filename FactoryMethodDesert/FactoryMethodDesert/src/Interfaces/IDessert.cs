namespace FactoryMethodDesert.Interfaces;

public interface IDessert
{
    string Name { get; }
    List<string> Ingredients { get; }
    List<string> Toppings { get; }
    List<string> Sauces { get; }
    void DisplayDesserts();
}