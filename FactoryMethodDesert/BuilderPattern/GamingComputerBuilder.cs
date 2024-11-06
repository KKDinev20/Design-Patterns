namespace BuilderPattern;

public class GamingComputerBuilder : IComputerBuilder
{
    private Computer _computer = new Computer();

    public void BuildCPU() => _computer.CPU = "Intel Core i9";
    public void BuildGPU() => _computer.GPU = "NVIDIA RTX 3080";
    public void BuildRAM() => _computer.RAM = "32GB";
    public void BuildStorage() => _computer.Storage = "1TB SSD";

    public Computer GetComputer() => _computer;
}