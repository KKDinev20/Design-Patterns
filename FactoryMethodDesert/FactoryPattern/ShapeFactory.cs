namespace FactoryPattern;

public class ShapeFactory
{
    public IShape CreateShape(string shapeType)
    {
        return shapeType switch
        {
            "Circle" => new Circle(),
            "Rectangle" => new Rectangle(),
            _ => throw new ArgumentException("Unknown shape type")
        };
    }
}