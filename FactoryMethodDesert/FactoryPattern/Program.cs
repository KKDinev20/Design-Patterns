namespace FactoryPattern;

class Program
{
    static void Main(string[] args)
    {
        ShapeFactory shapeFactory = new ShapeFactory();

        IShape circle = shapeFactory.CreateShape("Circle");
        circle.Draw();

        IShape rectangle = shapeFactory.CreateShape("Rectangle");
        rectangle.Draw();
    }
}