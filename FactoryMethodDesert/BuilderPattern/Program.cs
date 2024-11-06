namespace BuilderPattern;

class Program
{
    static void Main(string[] args)
    {
        IComputerBuilder gamingComputerBuilder = new GamingComputerBuilder();
        ComputerDirector director = new ComputerDirector();

        Computer gamingComputer = director.Build(gamingComputerBuilder);
        gamingComputer.ShowConfiguration();
    }
}