namespace BuilderPattern;

public class ComputerDirector
{
    public Computer Build(IComputerBuilder builder)
    {
        builder.BuildCPU();
        builder.BuildGPU();
        builder.BuildRAM();
        builder.BuildStorage();
        return builder.GetComputer();
    }
}