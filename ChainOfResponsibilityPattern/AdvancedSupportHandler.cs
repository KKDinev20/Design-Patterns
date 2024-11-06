namespace ChainOfResponsibilityPattern;

public class AdvancedSupportHandler : SupportHandler
{
    public override void HandleRequest(string request)
    {
        if(request == "Advanced")
            Console.WriteLine("Advanced Support: Handling advanced request.");
        else
            next?.HandleRequest(request);
    }
}