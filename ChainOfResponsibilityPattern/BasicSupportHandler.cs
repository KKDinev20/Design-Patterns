namespace ChainOfResponsibilityPattern;

public class BasicSupportHandler : SupportHandler
{
    public override void HandleRequest(string request)
    {
        if(request == "Basic")
            Console.WriteLine("Basic Support: Handling basic request.");
        else
            next?.HandleRequest(request);
    }
}