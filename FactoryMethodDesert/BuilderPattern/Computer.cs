namespace BuilderPattern;

public class Computer
{
    public string CPU { get; set; }
    public string GPU { get; set; }
    public string RAM { get; set; }
    public string Storage { get; set; }

    public void ShowConfiguration()
    {
        Console.WriteLine($"CPU: {CPU}, GPU: {GPU}, RAM: {RAM}, Storage: {Storage}");
    }
}